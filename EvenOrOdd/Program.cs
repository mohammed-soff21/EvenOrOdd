namespace EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            char cUserChoice = ' ';
            int number = 0;
            while (true)
            {
                // welcome message
                WelcomeApp("check the number is even or odd");
                // read an integer number from the user and validate it
                if (!IsNumber("the number to check", out number))
                    return;
                // apply IsEven method logic and print the output
                if (!IsEven(number))
                    Print($"The number {number} is odd");
                else
                    Print($"The number {number} is even");

                // to read user choice to continue in the app again and validate the user input
                if (!IsChar(" y to check another number else enter n", out cUserChoice))
                    return;
                // convert the character to lower 
                cUserChoice = Char.ToLower(cUserChoice);
                // to check the user input in the right format (y,n)
                if (!IsInRightFormat(cUserChoice))
                    return;
                // to check if the user want to continue or not
                if (!WantToContinue(cUserChoice))
                    return;
            }
        }

        #region app-methods

        // 1) this method to welcome user in the beginning of the application
        static void WelcomeApp(String welcomeMessage)
        {
            Console.Clear();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($"  Welcome to {welcomeMessage} Application!");
            Console.WriteLine("  This app is designed to make your life easier.");
            Console.WriteLine("  Let's get started!");
            Console.WriteLine("  Developed by: Mohammed Salem");
            Console.WriteLine("*********************************************************************************");
        }

        // 2) this method to print message in a beatiful form
        static void Print(String message)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        // 3) this method to read and validate int number from the user
        static bool IsNumber(string field, out int nValue)
        {
            Console.Write($"Please, enter {field}: ");
            if (!int.TryParse(Console.ReadLine(), out nValue))
            {
                Print("Please, enter a valid number");
                return false;
            }
            return true;
        }

        // 4) this method takes an integer then check if is even or not
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 5) this method to read and validate character from the user
        static bool IsChar(string field, out char character)
        {
            Console.Write($"Please, enter {field}: ");
            if (!char.TryParse(Console.ReadLine(), out character))
            {
                Print("Please, enter a valid character");
                return false;
            }
            return true;
        }

        // 6) this method to check that the user entered (y,n) only
        static bool IsInRightFormat(char input)
        {
            if (input == 'y' || input == 'n')
                return true;
            Print("Please, enter (y) to continue in the application again else enter (n)");
            return false;
        }

        // 7) this method to check the user choice if he wants to continue in the app or not
        static bool WantToContinue(char input)
        {
            if (input == 'y')
                return true;
            Print("The program ended : see you soon again");
            return false;
        }

        #endregion
    }
}
