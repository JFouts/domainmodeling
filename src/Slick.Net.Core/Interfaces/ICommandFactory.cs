using System;

namespace Slick.Net.Core.Interfaces
{
    public interface ICommandFactory
    {
        T Create<T>(Func<T> instantiationFunction) where T : Command;
    }
}