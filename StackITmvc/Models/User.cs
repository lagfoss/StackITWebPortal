using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StackITmvc.Models
{
    public class User : IdentityUser<int>
    {

        public AuthorizationLevel AuthorizationLevel { get; set; }

        [Required,
            StringLength(50),
            Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required,
            StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters."),
            Column("FirstName"),
            Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        [Display(Name = "Company")]
        public int CustomerId { get; set; }

        public Customer Company { get; set; }

        [DataType(DataType.EmailAddress),
            Required]
        public string Email { get; set; }

        [DataType(DataType.Password),
            Display(Name = "Password"),
            Required]
        public string Password { get; set; }

        [DataType(DataType.Password),
            Display(Name = "Confirm password"),
            Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Phone No."),
            DataType(DataType.PhoneNumber),
            StringLength(20)]
        public string PhoneNumber { get; set; }

        public ICollection<UserSubscriptions> UserSubscriptions { get; set; }
    }
}
