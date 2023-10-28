using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MalsagovUA.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task0V17
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries *= Math.Pow(2 / (Math.Cos(1)), startValue);
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
