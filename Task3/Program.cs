using static System.Console;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber;
            int i = 1;
            bool check=false;

            WriteLine("Введите целое число");
            enteredNumber =int.Parse(ReadLine());

            while (i<enteredNumber-1)
            {
                i++;
                if (enteredNumber%i==0)
                {
                    check =true;
                    break;
                }
            }
            if (check==false)
            {
                WriteLine($"Число {enteredNumber} простое");
            }
            else
            {
                WriteLine($"Число {enteredNumber} не простое");
            }

            ReadLine();
        }
    }
}
