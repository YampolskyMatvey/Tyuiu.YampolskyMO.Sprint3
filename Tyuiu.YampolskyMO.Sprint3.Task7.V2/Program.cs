using System;
using Tyuiu.YampolskyMO.Sprint3.Task7.V2.Lib;

namespace Tyuiu.YampolskyMO.Sprint3.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Ямпольский М. О. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Дополнительные примеры работы со структурами циклов               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Ямпольский М. О. | ИИПб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (cos(x) / (x - 0.7)) - sin(x) * 12x + 2                          *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Проверка деления на ноль (вернуть 0).   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(x)   |");
            Console.WriteLine("+----------+----------+");

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine("| {0,7:d}  | {1,8:f2} |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadKey();
        }
    }
}
