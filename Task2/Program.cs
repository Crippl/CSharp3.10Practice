using static System.Console;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte cardValue;
            byte cardSum = 0;
            string enteredNumber;
            WriteLine("Привет Игрок, Сколько карт у тебя на руках?");
            cardValue = byte.Parse(ReadLine());
            for (byte i = 1; i <= cardValue; i++)
            {
                Write($"Введите значение {i} карты ");
                enteredNumber = ReadLine();
                if (enteredNumber == "J" || enteredNumber == "Q" || enteredNumber == "K" || enteredNumber == "T")
                {
                    cardSum += 10;
                }
                else if (byte.TryParse(enteredNumber,out byte Value))
                {
                    switch (Value)
                    {
                        case 1:
                            cardSum += 1;
                            break;
                        case 2:
                            cardSum += 2;
                            break;
                        case 3:
                            cardSum += 3;
                            break;
                        case 4:
                            cardSum += 4;
                            break;
                        case 5:
                            cardSum += 5;
                            break;
                        case 6:
                            cardSum += 6;
                            break;
                        case 7:
                            cardSum += 7;
                            break;
                        case 8:
                            cardSum += 8;
                            break;
                        case 9:
                            cardSum += 9;
                            break;
                        default:
                            break;
                    }
                }
            }
            WriteLine($"Сумма ваших карт = {cardSum}");
            ReadLine();
        }
    }
}
