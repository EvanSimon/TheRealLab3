using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Program = true;
            while (Program)
            {
                bool Validate = true;
                while (Validate)
                {
                    int userNum, newNum; // declaring varables 

                    Console.WriteLine("Hello!! Please enter your name");// entering a name and storing it in Username
                    string Username = Console.ReadLine();

                    Console.WriteLine("Hello {0}, enter a integer between 1 and 100", Username);
                    userNum = int.Parse(Console.ReadLine());
                    newNum = userNum % 2; // mod function to make number odd or even

                    while (userNum < 1 | userNum > 100)
                    { 
                        Console.WriteLine("your number must be between a intager between 1 and 100");
                        Validate = true;
                        Program = false;
                        userNum = int.Parse(Console.ReadLine());
                    }

                    if (newNum == 0) // if number is even the block off code bellow will run
                    {
                       if (userNum <= 25 && userNum >= 2)
                       {
                            Console.WriteLine("{0} your number is even and less than 25", Username);
                            Validate = false;
                            Program = false;
                       }
                       else if (userNum > 26 && userNum < 60)
                       {
                            Console.WriteLine("{0} your number is even", Username);
                            Validate = false;
                            Program = false;
                       }
                       else if (userNum > 60 || userNum > 100)
                       {
                            Console.WriteLine("{0} your number is even", Username);
                            Validate = false;
                            Program = false;
                       }
                    }

                     else if (newNum == 1) // if number is odd the block off code bellow will run
                     {
                        Console.WriteLine("{0} your Number is {1} and odd", Username, userNum);
                        Validate = false;
                        Program = false;
                     }
                }
            }
            bool response = true;
            while (response)
            {
                Console.WriteLine("Would you like to run the program agian y/n?"); //asking user to rerun code
                string cont = Console.ReadLine().ToLower();
                if (cont == "y")
                {
                    response = false;
                }
                else if (cont == "n")
                {
                    Console.WriteLine("Goodbye");
                    response = false;
                    Program = false;
                }
                else
                {
                    Console.WriteLine("Sorry I didnt catch that, please try agian");
                }
            }
        }
         
    }
}
