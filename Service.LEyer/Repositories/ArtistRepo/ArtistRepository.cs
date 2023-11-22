using Data.Leyer.Entities;
using Data.Leyer.MyDbRoom;
using Microsoft.EntityFrameworkCore;
using Service.Leyer.Repositories.ValidationRepo;
using Service.Leyer.ResponsesModels;
using Service.Leyer.Security;
using Service.Leyer.ViewModels.ArtistVms;


namespace Service.Leyer.Repositories.ArtistRepo;

public class ArtistRepository : IArtistRepository
{
    private readonly MyDb _db;
    private readonly IValidationRepository _validation;
    public ArtistRepository(MyDb db, IValidationRepository validation)
    {
        _validation = validation;
        _db = db;
    }

    public async Task<Responses<Artist>> CreateArtist(CreateArtistVm artistVm)
    {
        if (!(await _validation.IsAllString(artistVm.Username)))
            return new Responses<Artist>()
            {
                HasError = true,
                ErrorMessage = Message.DataType_String
            };

        if (await IsArtistExist(artistVm.Username.ToUpper()))
            return new Responses<Artist>()
            {
                HasError = true,
                ErrorMessage = Message.DataExist
            };

        var artist = new Artist()
        {
            Username = artistVm.Username.ToUpper(),
            Password = HashPasswordC.EncodePasswordMd5(artistVm.Password)
        };

        _db.Artists.Add(artist);
        Save();
        if (!await IsArtistExist(artist.Username))
            return new Responses<Artist>()
            {
                HasError = true,
                ErrorMessage = Message.SomthingWrong
            };

        return new Responses<Artist>();
    }


    private async Task<bool> IsArtistExist(string username)
    {
        return await _db.Artists.AnyAsync(x => x.Username == username);
    }
    private void Save()
    {
        _db.SaveChanges();
    }
}
