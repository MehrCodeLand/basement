using Data.Leyer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Leyer.MyDbRoom;

public class MyDb : DbContext
{
    public MyDb(DbContextOptions<MyDb> options ) : base( options )
    {
        
    }


    public DbSet<Artist> Artists { get; set; }
    public DbSet<Art> Arts { get; set; }

}
