using DOP.Bussines.Providers;
using DOP.Bussines.Search;
using StructureMap.Configuration.DSL;

namespace DOP.Bussines.Container
{
    public class BussinesRegistry : Registry
    {
        public BussinesRegistry()
        {
            For<ISearchable>().Use<LevenshteinSearch>();
            For<IDOPProvider>().Use<DOPProvider>();            
        }
    }
}
