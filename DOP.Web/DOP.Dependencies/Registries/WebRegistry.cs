using DOP.Bussines.Container;
using DOP.Data.Container;
using StructureMap.Configuration.DSL;

namespace DOP.Dependencies.Registries
{
    public class WebRegistry:Registry
    {
        public WebRegistry()
        {
            Scan(scan => {
                scan.Assembly(typeof(DataRegistry).Assembly);
                scan.Assembly(typeof(BussinesRegistry).Assembly);
                scan.WithDefaultConventions();
            });
        }
    }
}
