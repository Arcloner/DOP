using DOP.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Bussines.Search
{
    public interface IDOPSearch
    {
        List<Personnel> SearchPersonnels(string LNM, List<Personnel> searchList);
        int GetDistance(string string1, string string2);
    }
}
