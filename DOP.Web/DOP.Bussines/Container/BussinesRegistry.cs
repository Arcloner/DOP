using DOP.Bussines.Providers;
using StructureMap.Configuration.DSL;

namespace DOP.Bussines.Container
{
    public class BussinesRegistry : Registry
    {
        public BussinesRegistry()
        {
            For<IDOPProvider>().Use<DOPProvider>();
        }
    }
}
