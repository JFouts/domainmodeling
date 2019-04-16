using System;
using Slick.Net.Core.Interfaces;

namespace Slick.Net.Core
{
    public class CommandFactory : ICommandFactory
    {
        public virtual T Create<T>(Func<T> instantiationFunction) where T : Command
        {
            var command = instantiationFunction();
            return command;
        }
    }
}