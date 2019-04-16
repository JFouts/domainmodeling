using System;

namespace Slick.Net.Core.Logging
{
    public interface ILogger<T>
    {
        void LogWarning(string message);
        void LogError(Exception exception, string message);
        void LogInformation(string message);
    }
}
