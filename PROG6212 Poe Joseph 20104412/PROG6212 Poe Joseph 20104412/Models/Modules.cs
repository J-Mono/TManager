using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROG6212_Poe_Joseph_20104412.Models
{
    public class Modules
    {
        // Get and set for the module
        //Primary Key was created
        //Getters and setters are known as encapsulation. encapsulation hides data from the user (w3schools, 2021)
        [Key]
        public int Module_Code { get; set; }

        //new module name property
        [Required(ErrorMessage ="Enter a module name")]
        public string ModuleName { get; set; }

        //new credits property
        [Required(ErrorMessage ="Enter number of credits")]
        public string Credits { get; set; }

        //  new class hours per week property
        [Required(ErrorMessage ="Enter class hours per week")]
        public string Class_Hours_per_week { get; set; }

        //new number of weeks property
        [Required(ErrorMessage = "Enter the number of weeks")]
        public int Nr_of_Weeks { get; set; }

        //new semester start date property
        [Required(ErrorMessage = "Enter the start date")]
        public string Semester_Start_Date { get; set; }
    }
}