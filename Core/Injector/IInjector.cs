using System;

namespace Core.Injector
{
    public interface IInjector : IDisposable
    {
        void AddScoped<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        void AddSingleton<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        void AddTransient<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        TImplementation Resolve<TImplementation>()
            where TImplementation : class;
    }
}
