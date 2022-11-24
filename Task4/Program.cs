using static System.Console;;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceLength;
            int minValue = int.MaxValue;
            int currentValue;

            WriteLine("Сколько чисел будете вводить?");
            sequenceLength = int.Parse(ReadLine());

            for (int i = 1; i <= sequenceLength; i++)
            {
                Write($"Введите {i} число: ");
                currentValue = int.Parse(ReadLine());
                if (minValue>currentValue)
                {
                    minValue = currentValue;
                }
            }
            WriteLine($"Минимальное число последовательности = {minValue}");
            ReadLine();
        }
    }
}
