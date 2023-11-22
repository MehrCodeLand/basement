using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Leyer.ViewModels.ArtistVms;

public class CreateArtistVm
{
    [Required]
    public string Username { get; set; }
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [DataType(DataType.Password)]
    [Required]
    [Compare("Password")]
    public string RePassword { get; set; }
}
