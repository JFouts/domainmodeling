using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Slick.Net.Core.Exceptions;

namespace Slick.Net.Core
{
    public class ValidatedCommandFactory : CommandFactory
    {
        public override T Create<T>(Func<T> instantiationFunction)
        {
            var command = base.Create(instantiationFunction);
            AssertModelValid(command);
            return command;
        }

        private static void AssertModelValid(object model)
        {
            var validationContext = new ValidationContext(model);
            var results = new List<ValidationResult>();

            // TODO: Validator is a hidden dependency let's pull that out and inject it
            if (!Validator.TryValidateObject(model, validationContext, results))
                throw new InvalidModelStateException(results);
        }
    }
}