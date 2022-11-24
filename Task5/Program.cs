using static System.Console;
using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomizer = new Random();
            int maxRange;
            int randomNumber;
            int userNumber;
            string userNumberString;
            bool exitCheck = false;

            Write("Введите максимальное целое число диапазона: ");
            maxRange = int.Parse(ReadLine());
            randomNumber = randomizer.Next(0, maxRange);

            while (exitCheck==false)
            {
                Write("Введите число: ");
                userNumberString =ReadLine();
                if (String.IsNullOrEmpty(userNumberString))
                {
                    WriteLine($"Загаданное число = {randomNumber}");
                    break;
                }
                else
                {
                    userNumber = int.Parse(userNumberString);
                    if (userNumber < randomNumber)
                    {
                        WriteLine($"Загаданное число БОЛЬШЕ, чем {userNumber}");
                    }
                    else if (userNumber > randomNumber)
                    {
                        WriteLine($"Загаданное число МЕНЬШЕ, чем {userNumber}");
                    }
                    else
                    {
                        WriteLine($"Верно! Загаданное число = {randomNumber}");
                        break;
                    }
                }
            }
            ReadLine();
        }
    }
}
