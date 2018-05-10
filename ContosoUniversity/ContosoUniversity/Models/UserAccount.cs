using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Aikman Ong, 8160156118
/// Attempt to make a log in page
/// Source: https://www.youtube.com/watch?v=Uq0y8oxnx-8
/// </summary>
namespace ContosoUniversity.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-mail is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
