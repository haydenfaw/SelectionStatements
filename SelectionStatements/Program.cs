using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine($"Try to guess my favorite number. It exists between 1 and 1000:");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"too high");
            }
            else
            {
                Console.WriteLine($"Nevermind");
            }
            Console.WriteLine($"The number was {favNumber}");
            //Console.WriteLine($"The number was {favNumber}.");

            Console.WriteLine($"What is your favorite school subject?");
            var favSchoolSubject = Console.ReadLine();
            
            switch (favSchoolSubject)
            {
                case "English":
                    Console.WriteLine($"You should consider becoming a writer!");
                    break;
                case "Math":
                    Console.WriteLine($"You should consider becoming an engineer!");
                    break;
                case "Science":
                    Console.WriteLine($"You should consider becoming a scientist!");
                    break;
                case "History":
                    Console.WriteLine($"You should consider becoming a history professor!");
                    break;
                case "Government":
                    Console.WriteLine($"You should consider running for office!");
                    break;
                default:
                    Console.WriteLine($"I am sorry, but I only know about the subjects: English, Math, Science, History, and Government");
                    break;
            }

        }
    }
}
