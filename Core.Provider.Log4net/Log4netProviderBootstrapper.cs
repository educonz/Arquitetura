using Core.Injector;
using Core.Logger;

namespace Core.Provider.Log4net
{
    public class Log4netProviderBootstrapper : IBootstrapper
    {
        public void Load(IInjector injector)
        {
            injector.AddTransient<ILogger, LoggerProvider>();
        }
    }
}
