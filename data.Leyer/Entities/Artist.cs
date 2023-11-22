using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Leyer.Entities;

public class Artist
{
    [Key]
    public int ArtistId { get; set; }
    [Required]
    [MinLength(5 , ErrorMessage = "min is 5")]
    [MaxLength(100 , ErrorMessage = "max is 100")]
    public string Username { get; set; }
    [DataType(DataType.Password)]
    public string Password { get; set; }
    public string Description { get; set; } = string.Empty;

    public ICollection<Art> Arts { get; set; }
}
