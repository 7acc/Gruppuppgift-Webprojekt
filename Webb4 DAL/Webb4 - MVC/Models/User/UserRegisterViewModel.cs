using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Webb4___MVC.Models.User
{
    public class UserRegisterViewModel
    {
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "UserName Is Required")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
       
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Please Confirm Your Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="StreetName is required")]


        //adressModel


        public string Street { get; set; }
        [Required(ErrorMessage = "Postalcode is required")]
        public string PostalNumber { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }

    }
}