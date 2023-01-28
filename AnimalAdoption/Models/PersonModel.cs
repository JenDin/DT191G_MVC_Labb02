using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace AnimalAdoption.Models
{
	public class PersonModel
	{
        [Required(ErrorMessage = "* Enter your first name")]
        [Display(Name = "First name")]
		public string? FirstName { get; set; }

        [Required(ErrorMessage = "* Enter your last name")]
        [Display(Name = "Last name")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "* Enter your email")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "* Enter your phone number")]
        [Phone]
        [Display(Name = "Phone number")]
        public string? PhoneNo { get; set; }

        //[Required]
        [Display(Name = "Animal category")]
        public string? AnimalCategory { get; set; }

        [BindProperty]
        public string Gender { get; set; }
        public string[] Genders = new[] { "Male", "Female" };

        public string? Message { get; set; }

    }
}

