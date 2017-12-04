using DOP.Common.Models;
using System.Collections.Generic;

namespace DOP.Bussines.Search
{
    public interface ISearchable
    {
        List<Personnel> SearchPersonnels(string LNM,List<Personnel> searchList);
        int GetDistance(string string1, string string2);
    }
}
