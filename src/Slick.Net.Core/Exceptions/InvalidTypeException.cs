using System;

namespace Slick.Net.Core.Exceptions
{
    public class InvalidTypeException : Exception
    {
        public InvalidTypeException(string message)
            :base(message)
        {
        }
    }
}