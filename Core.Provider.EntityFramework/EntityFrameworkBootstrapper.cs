using Core.Data;
using Core.Injector;

namespace Core.Provider.EntityFramework
{
    public class EntityFrameworkBootstrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<IDataContext, EntityFrameworkContext>();
        }
    }
}
