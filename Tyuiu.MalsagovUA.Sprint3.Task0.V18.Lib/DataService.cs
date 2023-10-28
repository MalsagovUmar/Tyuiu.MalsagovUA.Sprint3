using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MalsagovUA.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            int i;
            double res = 1;
            for (i = startValue; i <= stopValue; i++)
            {
                res *= Math.Pow(2 / (Math.Cos(value) + 0.5), i);
            }
            return Math.Round(res, 3);
        }
    }
}
