using Data.Leyer.Entities;
using Service.Leyer.ResponsesModels;
using Service.Leyer.ViewModels.ArtistVms;

namespace Service.Leyer.Repositories.ArtistRepo
{
    public interface IArtistRepository
    {
        Task<Responses<Artist>> CreateArtist(CreateArtistVm artistVm);
    }
}