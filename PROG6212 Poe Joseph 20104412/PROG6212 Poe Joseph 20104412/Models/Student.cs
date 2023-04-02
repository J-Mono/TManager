using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PROG6212_Poe_Joseph_20104412.Models
{
    public class Student
    {
        //setting the primary key
        //Getters and setters are known as encapsulation.encapsulation hides data from the user(w3schools, 2021)
        [Key]
        public int StudentNr { get; set; }

        //Get and Set for the student
        //new name property
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        //new surname property
        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }

        //new email property
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")]
        public string Email { get; set; }

        //new password property
        [Required(ErrorMessage = "Please Provide a password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //new confirm password property
        [Required(ErrorMessage = "Re-enter your password")]
        [Compare("Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}