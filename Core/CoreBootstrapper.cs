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
            injector.AddScoped<IDateTimeService, DateTimeService>();
            injector.AddScoped<IRepository, Repository>();
            injector.AddScoped<IUnityOfWork, UnityOfWork>();
        }
    }
}
