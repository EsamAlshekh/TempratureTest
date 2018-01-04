using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TemperatureTest.Models
{
    public class Person
    {
        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter your email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "pleas enter invaled email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "please enter your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "The input must be anummber")]
        public  int Temperature { get; set; }

        //
        public static string Theresult(int temperature)
        {
            if (temperature == 37)
            {
                return "Great!you are ok ,And your temperature is normal.";
            }
            else if (temperature > 37)
            {
                return "Your temperature is  high ,you have to visit the doctor.";
            }
            else
            {
                 return "Your temperature is  low ,you have to visit the doctor.";
            }
           
        }
    }
}