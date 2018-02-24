using Core.Injector;
using Core.Map;

namespace Core.Provider.AutoMapper
{
    public class AutoMapperBootstrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<IMap, MapProvider>();
        }
    }
}
