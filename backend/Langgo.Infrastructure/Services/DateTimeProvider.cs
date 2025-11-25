using Langgo.Application.Common.Interfaces.Services;

namespace Langgo.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}