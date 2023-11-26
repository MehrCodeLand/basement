using Data.Leyer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Leyer.Repositories.ArtistRepo;
using Service.Leyer.ResponsesModels;
using Service.Leyer.ViewModels.ArtistVms;

namespace basement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ArtistController : ControllerBase
{
    private readonly IArtistRepository _artist;

    public ArtistController( IArtistRepository artist )
    {
        _artist = artist;
    }

    [HttpPost]
    public async Task<IActionResult> CreateArtist( CreateArtistVm artistVm)
    {
        var response = await _artist.CreateArtist( artistVm );
        if(response.HasError)
            return NotFound();

        return Ok(); 
    }
}
