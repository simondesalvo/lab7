using System;
using System.Text.RegularExpressions;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            while (x) //quick way to do "start again" loops to make it easier to test
            {
                Console.WriteLine("Put in your name (first and last)");
                string nameInput = Console.ReadLine();
                NameCheck(nameInput);

                Console.WriteLine("Put in your email");
                string emailInput = Console.ReadLine();
                EmailCheck(emailInput);

                Console.WriteLine("Phone number?");
                string phoneInput = Console.ReadLine();
                PhoneCheck(phoneInput);

                Console.WriteLine("Date mm/dd/yyyy ?");
                string dateInput = Console.ReadLine();
                DateCheck(dateInput);

                Console.WriteLine("Try again? y/n"); //"start again" loops to make it easier to test
                string answer = Console.ReadLine();
                while (answer == "y")
                {
                    break;
                }
                while (answer == "n")
                {
                    Console.WriteLine("Fine, bye");
                    x = false;
                    break;
                }
            }
        }



        public static void NameCheck(string nameInput) //tbh I did first and last to challenge myself because I couldn't get the space validation to work at first, but this is easily split for first and last name
        {
            if (Regex.IsMatch(nameInput, @"(^[A-Z][a-z]{1,29} ?[A-Z][a-z]{1,29}$)"))
            {
                Console.WriteLine("Works!");
            }
            else
            {
                Console.WriteLine("Oopsie poopsie");
            }
        }

       
        public static void EmailCheck (string emailInput)
        {
            if (Regex.IsMatch(emailInput, @"^([\w 0-9]{5,30})*@((([\-\w]{5,10}\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$"))
            {
                Console.WriteLine("Solid");
            }
            else
            {
                Console.WriteLine("Yah gunked up");
            }
        }

        public static void PhoneCheck (string phoneInput)
        {
            if (Regex.IsMatch(phoneInput, @"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$"))
            {
                Console.WriteLine("Yay a number");
            }
            else
            {
                Console.WriteLine("Boo");
            }
        }

        public static void DateCheck (string dateInput)
        {
            if (Regex.IsMatch(dateInput, @"^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$"))
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("Noooooo!");
            }
        }

    }
}
