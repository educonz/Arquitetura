using System;

namespace Core.UtilsServices
{
    public interface IDateTimeService
    {
        DateTime Now();
        DateTime UtcNow();
    }
}