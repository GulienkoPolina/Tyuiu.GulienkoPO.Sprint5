﻿using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GulienkoPO.Sprint5.Task5.V5.Lib
{
    public class DataService : ISprint5Task5V5
    {
        public double LoadFromDataFile(string path)
        {
            string n = File.ReadAllText(path);
            string[] array = n.Split(' ');
            double[] x = new double[array.Length];

            double max = 20;
            double min = -10;
            for (int i = 0; i < array.Length; i++)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
                if (x[i] < min)
                {
                    min = x[i];
                }
            }
            return Math.Round(max - min, 3);
        }
    }
}