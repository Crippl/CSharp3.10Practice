using static System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber;

            WriteLine("Введите целое число");
            enteredNumber = int.Parse(ReadLine());
            if (enteredNumber%2==0)
            {
                WriteLine($"Ваше число {enteredNumber} четное");
            }
            else
            {
                WriteLine($"Ваше число {enteredNumber} нечетное");
            }
            ReadLine();
        }
    }
}
