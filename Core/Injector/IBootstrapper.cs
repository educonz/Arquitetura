namespace Core.Injector
{
    public interface IBootstrapper
    {
        void Load(IInjector injector);
    }
}
