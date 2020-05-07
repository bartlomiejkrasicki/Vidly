using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class CustomerAgeValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.DateOfBirth == null)
                return new ValidationResult("Date of birth is required.");

            var customerAge = DateTime.Today.Year - customer.DateOfBirth.Value.Year;
                return (customerAge >= 18) ? ValidationResult.Success : new ValidationResult("Your should be at least 18 years ago to sign an agreement.");
        }
    }
}