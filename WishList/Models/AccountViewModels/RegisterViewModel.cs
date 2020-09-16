using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required,StringLength(maximumLength: 100,MinimumLength =8),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,Compare("Password"),DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
