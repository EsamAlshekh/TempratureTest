using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TempratureTest.Models
{
    public class Game
    {
        [Required(ErrorMessage = "The input must be anummber")]
        public int Enter { get; set; }

        public static string Result(int number)
        {
            string message = "";
            int randomNumber = int.Parse(HttpContext.Current.Session["randomNumber"].ToString());
            if (number == randomNumber)
            {
                message = "Congratulation";
            }
            else if (number > randomNumber)
            {
                message = "The number is high,Try again";
            }
            else
            {
                message = "The number is low,Try again";
            }
            return message;
        }



    }
}