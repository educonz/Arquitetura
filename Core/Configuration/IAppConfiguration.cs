using Microsoft.Extensions.Configuration;

namespace Core.Configuration
{
    public interface IAppConfiguration
    {
        IConfigurationRoot Configuration { get; }
        IConfigurationRoot Configure();
    }
}
