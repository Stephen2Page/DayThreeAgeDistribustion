﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeAgeDistribustion
{
    class Program
    {
        /*
        From 15 to 18: 'High School' 
        From 19 to 22: 'College'
        From 23 to 65: 'Working for the Man' 
        From 66 to 100: 'The Golden Years' 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");

            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 0 && userAge <= 2) 
            {
                Console.WriteLine("Still in MaMa's Arms");
            }
            else if (userAge >= 3 && userAge <=4) // or can be expressed as (userAge == 3 || userAge == 4)
            {
                Console.WriteLine("Prescool Maniac");
            }
            else if (userAge >= 5 && userAge <= 11)
            {
                Console.WriteLine("Elementry School");
            }
            else if (userAge >= 12 && userAge <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (userAge >= 15 && userAge <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (userAge >= 19 && userAge <= 22)
            {
                Console.WriteLine("College");
            }
            else if (userAge >= 23 && userAge <= 65)
            {
                Console.WriteLine("Working for the Man");
            }
            else if (userAge >= 66 && userAge <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else
            {
                Console.WriteLine("This program is for humans");
            }
        }       
    }
}
