using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator {
    class Program {
        static void Main(string[] args) {

            int numb1; 
            int numb2;

            int result = 0;

            string answer;

            Console.WriteLine("Hi there! Welcome to the Calculator!");
            Console.WriteLine("Enter the first number: ");

            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numb1);

            Console.WriteLine("Enter the second number: ");

            numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numb2);

            System.Console.WriteLine("What type of operation would you like to do?");
            System.Console.WriteLine("Enter 'a' for Addition, 's' for Subtraction, 'm' for Multipliation, or 'd' for division");

            answer = Console.ReadLine();

            if(answer == "a") {

                result = numb1 + numb2;
            }
            else if(answer == "s") {
                result = numb1 - numb2;
            }
            else if(answer == "m") {
                result = numb1 * numb2;
            }
            else if(answer == "d") {
                result = numb1/numb2;
            }
            else {
                Console.WriteLine("You entered a key that is not an operation.");
            }

            Console.WriteLine("The result is " + result);

            Console.ReadKey();
        }
    }
}
