using System;

namespace Core.UtilsServices
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime Now() => DateTime.Now;

        public DateTime UtcNow() => DateTime.UtcNow;
    }
}
