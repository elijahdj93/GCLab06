using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing == true)
            {

            Console.WriteLine("Welcome to the Pig Latin Translator!");

            Console.WriteLine("Enter a line to be translated:");

            string str = Console.ReadLine().ToLower();//reads user input and converts to all lowercase

            if (str[0] == 'a' || str[0] == 'e' || str[0] == 'i' || str[0] == 'o' || str[0] == 'u')
            //READS if user input starts with a vowel (a,e,i,o,u)
            {
                Console.WriteLine(str + "way");

            }
            else
            {
                char[] vow = { 'a', 'e', 'i', 'o', 'u' };
                int index = str.IndexOfAny(vow);
                string str1 = (str.Substring(0, index));
                string str2 = (str.Substring(index));
                Console.WriteLine(str2 + str1 + "ay");

            }
          
            string userChoice;
            Console.WriteLine("Continue? (y/n)");
            userChoice = ReadValidContinue();
            if (userChoice == "n" )
            {
                keepGoing = false;
            }
            }
        }

        public static string ReadValidContinue()
        {
            string option = Console.ReadLine();
            while (option != "y" && option != "n")
            {
                Console.WriteLine("Please enter a y or n");
                option = Console.ReadLine();
            }

            return option;
        }

    }
}

