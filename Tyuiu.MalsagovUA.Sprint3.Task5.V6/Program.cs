using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalsagovUA.Sprint3.Task5.V6.Lib;
namespace Tyuiu.MalsagovUA.Sprint3.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;
            Console.Title = "Спринт #3 | Выполнил: Мальсагов У.А. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Вычислить сумму ряда.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Старт шага первой суммы ряда: {startValue1}");
            Console.WriteLine($"Конец шага первой суммы ряда: {startValue2}");
            Console.WriteLine($"Старт шага второй суммы ряда: {stopValue1}");
            Console.WriteLine($"Конец шага второй суммы ряда: {stopValue2}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write($"Результат = {dataService.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2)}");
            Console.ReadKey();
        }
    }
}
