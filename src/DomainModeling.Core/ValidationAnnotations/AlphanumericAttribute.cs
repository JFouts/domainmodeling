﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DomainModeling.Core.Exceptions;

namespace DomainModeling.Core.ValidationAnnotations
{
    public class AlphanumericAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            const ValidationResult success = null;
            var error = new ValidationResult($"{validationContext?.DisplayName} must be alphanumeric.");

            switch (value)
            {
                case string s:
                    return IsAlphanumeric(s) ? success : error;
                case IEnumerable<string> l:
                    return l.Any(text => !IsAlphanumeric(text)) ? error : success;
                case null:
                    return success;
                default:
                    throw new InvalidTypeException($"{nameof(AlphanumericAttribute)} can only be applied to {nameof(String)} or {nameof(IEnumerable<string>)} but was applied to {value.GetType().Name}");
            }
        }

        private static bool IsAlphanumeric(string text) => text.All(char.IsLetterOrDigit);
    }
}