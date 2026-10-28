using System;
using Tyuiu.YampolskyMO.Sprint3.Task3.V23.Lib;

namespace Tyuiu.YampolskyMO.Sprint3.Task3.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Ямпольский М. О. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Ямпольский М. О. | ИИПб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы s на цифру 8 в строке:            *");
            Console.WriteLine("* fdsst siu vsrs                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "fdsst siu vsrs";
            char chr = 's';
            char rep = '8';

            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Символ для замены: " + chr);
            Console.WriteLine("Символ на замену: " + rep);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результат: " + ds.ReplaceCharOnNum(str, chr, rep));

            Console.ReadKey();
        }
    }
}