using System;
using System.ComponentModel.DataAnnotations;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required]
		[Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
		[NumberValidation]
        public int? Number { get; set; }
    }
}
