using ClassLibraryForPoe;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROG6212_Poe_Joseph_20104412.Models
{
    public class StudyHours
    {
        //creating the primary key for our table
        [Key]
        public int SH_ID { get; set; }

        //Creating the new study hours required property
        [Required(ErrorMessage = "Enter the study hours required")]
        public string study_hours_required { get; set; }

        //Creating hours studied property
        [Required(ErrorMessage = "Enter the hours studied")]
        public int hoursStudied { get; set; }

        //creating Remaining Study hours property
        [Required(ErrorMessage = "Enter the remaining study hours")]
        public int RemainingStudyHours { get; set; }
    }
}