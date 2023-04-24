using ConsiderTheSourceCode.Application.Interfaces;

namespace ConsiderTheSourceCode.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}