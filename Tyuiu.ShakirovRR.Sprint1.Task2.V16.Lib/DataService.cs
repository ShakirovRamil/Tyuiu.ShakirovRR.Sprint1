﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShakirovRR.Sprint1.Task2.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public double CalculatePerimetrCircle(int value)
        {
            return value * 2 * 3.14;
        }
    }
}
