using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Leyer.Entities;

public class Art
{
    [Key]
    public int ArtId { get; set; }
    [Required]
    [StringLength(50 , ErrorMessage = "max is 50")]
    public string Title { get; set; }
    public string ArtImageName { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Created { get; set; } = DateTime.Now;

   
    public int ArtistId { get; set; }
    public Artist Artist { get; set; }
}
