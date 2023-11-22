using Data.Leyer.MyDbRoom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Leyer.Repositories.Art;

public class ArtRepository
{
    private readonly MyDb _db;
    public ArtRepository( MyDb db )
    {
        _db = db;
    }

}
