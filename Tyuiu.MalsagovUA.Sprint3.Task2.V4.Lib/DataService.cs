using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MalsagovUA.Sprint3.Task2.V4.Lib
{
    public class DataService : ISprint3Task2V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;
            do
            {
                multiplySeries *= Math.Pow(startValue / (Math.Pow(Math.Sin(1), -7)), -2);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(multiplySeries, 3);
        }
    }
}
