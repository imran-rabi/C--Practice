using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInput userInput = new UserInput();
            userInput.GetUserInput();
        }
    }

    class UserInput
    {
        public void GetUserInput()
        {
            Console.WriteLine("Please Input your name:");
            string userName = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Hello " + userName + "!");
        }
    }
}



