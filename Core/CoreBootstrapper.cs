using Core.Data;
using Core.Data.Repository;
using Core.Injector;
using Core.UtilsServices;

namespace Core
{
    public class CoreBootstrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<IDateTimeService, DateTimeService>();
            injector.AddTransient<IRepositoryGeneric, RepositoryGeneric>();
            injector.AddTransient<IUnityOfWork, UnityOfWork>();
        }
    }
}
