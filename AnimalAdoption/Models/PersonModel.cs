using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AnimalAdoption.Models
{
	public class PersonModel
	{
        // First name
        [Required(ErrorMessage = "* Enter your first name")]
        [Display(Name = "First name")]
		public string? FirstName { get; set; }

        // Last name
        [Required(ErrorMessage = "* Enter your last name")]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }

        // Email
        [Required(ErrorMessage = "* Enter your email")]
        [EmailAddress]
        public string? Email { get; set; }

        // Phone number
        [Required(ErrorMessage = "* Enter your phone number")]
        [Phone]
        [Display(Name = "Phone number")]
        public string? PhoneNo { get; set; }

        // Animal category
        [Display(Name = "Choose a category")]
        public Category AnimalCategory { get; set; }

        // Gender
        [Required(ErrorMessage = "* Choose your gender")]
        [BindProperty]
        public string? Gender { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        public string[] Genders = new[] { "Male", "Female" };

        // Message
        public string? Message { get; set; }
    }
}

