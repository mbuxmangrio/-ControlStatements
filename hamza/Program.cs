using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;

namespace hamza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 149;
            //if (num >= 90 && num <= 100)
            //{
            //    Console.WriteLine("A1 Grade");
            //}
            //else if (num >= 80 && num <= 90)
            //{
            //    Console.WriteLine("A Grade");
            //}
            //else if (num >= 70 && num <= 80)
            //{
            //    Console.WriteLine("B Grade");
            //}
            //else if (num >= 60 && num <= 70)
            //{
            //    Console.WriteLine("C Grade");
            //}
            //else if (num >= 50 && num <= 60)
            //{
            //    Console.WriteLine("D Grade");
            //}
            //else if (num >= 0 && num <= 50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else if (num <= 0  || num >= 100)
            //{
            //    Console.WriteLine("INVALID NUMBER");
            //}

            //  int percentage = 4;

            //if (percentage <=100 && percentage >=95)
            //  {
            //      Console.WriteLine("A+ Grade");
            //  }

            //  else if (percentage <= 95 && percentage >= 85)
            //  {
            //      Console.WriteLine("A Grade");
            //  }
            //  else if (percentage <= 85 && percentage >= 75)
            //{
            //    Console.WriteLine("B Grade");
            //}

            //else if (percentage <= 75 && percentage >= 65)
            //{
            //    Console.WriteLine("C Grade");
            //}
            //else if (percentage <= 65 && percentage >= 55)
            //{
            //    Console.WriteLine("D Grade");
            //}
            //else if  (percentage <= 55 && percentage >= 50)
            //{
            //    Console.WriteLine("E");
            //}
            //else if (percentage <= 50)
            //{
            //    Console.WriteLine("Fail");
            //}
            //else if (percentage <= 0 || percentage >= 100)
            //{
            //     Console.WriteLine("Invalid Number"); 
            //}
            //int age = 17;
            //if (age >= 18)
            //{
            //    Console.WriteLine("YOU ARE ADULT");
            //}
            //else if (age <= 18)
            //{
            //    Console.WriteLine("YOU ARE NOT ADULT");
            //}
            //int age = 17;
            //if( age>=18)
            //{
            //    Console.WriteLine("The person is eligible for vote");
            //}
            //else
            //{
            //    Console.WriteLine("The person is not eligible for vote");
            //}
            //Console.WriteLine("Enter a number between 0 to 100:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n >= 0 && n < 20)
            //{
            //    Console.WriteLine("YOU HAVE TO SMILE NOW!!");
            //}
            //else if (n >= 20 && n < 40)
            //{
            //    Console.WriteLine("YOU HAVE TO LAUGH NOW!!");
            //}
            //else if (n >= 40 && n < 60)
            //{
            //    Console.WriteLine("YOU HAVE TO CRY NOW!!");
            //}
            //else if (n >= 60 && n < 80)
            //{
            //    Console.WriteLine("YOU HAVE TO SHOUT NOW!!");
            //}
            //else if (n >= 80 && n < 100)
            //{
            //    Console.WriteLine("YOU HAVE TO SING NOW!!");
            //}
            //else
            //{
            //    Console.WriteLine("Enter again.");
            //}

            //nested if else statement//



            //var animal = "turtle";
            //int speed = Convert.ToInt32(Console.ReadLine());
            //if ((animal == "horse" || animal == "donkey") && (speed > 40))
            //{
            //    Console.WriteLine("Run fast");
            //}
            //else if ((animal == "shark" || animal == "dolphin") && (speed > 45))
            //{
            //    Console.WriteLine("Swim fast");
            //}
            //else if (animal == "turtle" && (speed > 30))
            //{
            //    Console.WriteLine("Slow move");
            //}
            //     else if (animal == "tiger" && (speed >= 70))
            //{
            //    Console.WriteLine("Run very fast");
            //}

            //    var age = Convert.ToInt32(Console.ReadLine());
            //            if (age<=5)
            //            {
            //                Console.WriteLine("He should be admitted in a school");
            //            }
            //            else if (age <= 6)
            //{
            //    Console.WriteLine("He should be in one class");
            //}
            //else if (age <= 10)
            //            //{
            //    Console.WriteLine("He should be in class five");
            //}
            //else if(age<=11)
            //{
            //    Console.WriteLine("He should be in class six and must leave for Middle school ");
            //}
            //else if(age<=15)
            //{
            //    Console.WriteLine("He should be class X and should be in high school");
            //}
            //else if(age<=18)
            //{
            //    Console.WriteLine("He should be in any university");
            //}
            //else if(age<=24)
            //{
            //    Console.WriteLine("His masters should be completed");
            //}
            //else if(age<=25)
            //{
            //    Console.WriteLine("He should have good job in govt sector");
            //}
            //else
            //{
            //    Console.WriteLine("He should Enjoy");
            //}

            //Console.WriteLine("Enter a number:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} is an even number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is an odd number.");
            //}

            //Console.WriteLine("Even and Odd numbers from 1 to 100");
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i} is even,");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} is odd,");
            //    }
            //}



            //Find out names of four seasons on the basis of number of months:
            var month =Console.ReadLine();
                        
            switch(month)
            {
                case "1":
                case "2":
                case "11":
                case "12":
                    Console.WriteLine("it is Winter");
                    break;
                case "5":
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("it is Summer");
                    break;
                case "3":
                case "4":
                    Console.WriteLine("It is Spring");
                    break;
                case "9":
                case "10":
                    Console.WriteLine("it is Autumn");
                    break;
                default:
                    Console.WriteLine("INVALID NUMBER Please enter number from 1 to 12");
                    break;


            }






































        }


    } 
}
