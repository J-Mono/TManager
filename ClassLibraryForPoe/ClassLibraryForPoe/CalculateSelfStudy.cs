using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForPoe
{
    public class CalculateSelfStudy
    {

        //method to calculate the study hours weekly
        public int calcStudyHours(string Credits, int Nr_of_weeks, string class_hp)
        {
            //weekly study hours = credits time 10. 
            //then that ansswer is divided by the number of weeks
            //then that answer is subtracted by the class hours
            int credits = Convert.ToInt32(Credits);
            int classhours = Convert.ToInt32(class_hp);

            return(credits * 10 / Nr_of_weeks) - classhours;
        }
    }
}
