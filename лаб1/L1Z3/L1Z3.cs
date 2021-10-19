using System;

namespace L1Z3
{
    class L1Z3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int select = (year-4) % 12;
            switch (select) 
            {
                case 0:
                    Console.WriteLine("Год Крысы");
                    break;
                case 1:
                    Console.WriteLine("Год Коровы");
                    break;
                case 2:
                    Console.WriteLine("Год Тигра");
                    break;
                case 3:
                    Console.WriteLine("Год Зайца");
                    break;
                case 4:
                    Console.WriteLine("Год Дракона");
                    break;
                case 5:
                    Console.WriteLine("Год Змеи");
                    break;
                case 6:
                    Console.WriteLine("Год Лошади");
                    break;
                case 7:
                    Console.WriteLine("Год Овцы");
                    break;
                case 8:
                    Console.WriteLine("Год Обезьяны");
                    break;
                case 9:
                    Console.WriteLine("Год Петуха");
                    break;
                case 10:
                    Console.WriteLine("Год Собаки");
                    break;
                case 11:
                    Console.WriteLine("Год Свиньи");
                    break;
            }
            Console.ReadLine();
        }
    }
}
