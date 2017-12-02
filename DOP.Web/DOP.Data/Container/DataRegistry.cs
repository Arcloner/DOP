using DOP.Data.Bussines;
using DOP.Data.Clients;
using DOP.Data.Services;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOP.Data.Container
{
    public class DataRegistry:Registry
    {
        public DataRegistry()
        {
            For<IConvert>().Use<Bussines.Convert>();
            For<IDOPClient>().Use<DOPClient>();
            For<IDOPService>().Use<Services.DOPService>();
        }
    }
}
