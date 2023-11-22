using Service.Leyer.ResponsesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service.Leyer.Repositories.ValidationRepo;

public class ValidationRepository : IValidationRepository
{
    public async Task<bool> IsAllString(string name)
    {
        var rgx = new Regex("[0-9]");
        if (rgx.IsMatch(name))
            return false;

        return true;
    }
}
