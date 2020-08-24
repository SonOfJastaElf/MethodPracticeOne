using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's write you a short story");
            Console.WriteLine("Tell me your name");
            string name = Console.ReadLine();
            Console.WriteLine("Where do you live?");
            string place = Console.ReadLine();
            Console.WriteLine("Now tell me how old you are");
            string age = Console.ReadLine();
            Console.WriteLine("What kind of pet do you have?");
            string pet = Console.ReadLine();
            Console.WriteLine("And what is its name?");
            string petName = Console.ReadLine();

            Console.WriteLine("Based on what you've told me, here's your story:");
            Console.WriteLine($"There once was a person called {name} from {place} and this person was {age} years old.");
            Console.WriteLine($"This person had a {pet} called {petName} and the two lived pretty well together.");
            Console.WriteLine("There, that was easy.");
        }
    }
}
