using System;
using System.Collections.Generic;

namespace HOME_TASK_TO_24_SEP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //User registrasiya səhifəsi olsun, username və password təyin etsin, 
            //forget password səhifəsi olsun passwordu dəyi3şdirə bilsin,  
            //əlbəttə duz daxil etdikdə səhifəyə girsin, girdikdə successfully logged in yazılsın.


            

            string main_username = "onur";
            int previous_password = 2705;
            int pin1;
            string username;
            breakpoint:
            Console.WriteLine("Please enter an username");
            username = Console.ReadLine();

            try
            {
                Console.WriteLine("Please enter a password");
                pin1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input int was not in a correct format");            
                goto breakpoint;
            }

            if (main_username == username && previous_password == pin1)
            {
                Console.WriteLine("Successfully logged in\n");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect Userame or Password\n");
                Console.WriteLine("Forget password !!!");
                Console.Write(ForgetPassword(previous_password));
                return;
            }
        }
        public static int ForgetPassword( int previous_password)
        {
            Console.WriteLine("Enter your new pin");
            int pin2 = int.Parse(Console.ReadLine());
            previous_password = pin2;
            Console.WriteLine("Your pin is changed");
            return previous_password;

        }
    }
}
