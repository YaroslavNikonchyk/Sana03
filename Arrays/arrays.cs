using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class arrays
    {
        public static double[] GenerateArray(int elementsCount, double minValue = -10, double maxValue = 10, int digitCount = 2)
        {
            double[] array = new double[elementsCount];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = Math.Round(minValue + (random.NextDouble() * (maxValue - minValue)), digitCount);
            return array;
        }
        public static double SumOfNegativeElements(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) sum += array[i];
            return sum;
        }
        public static double ArrayMinElement(double[] array)
        {
            double min = double.MaxValue;
            for(int i = 0;i < array.Length;i++) 
            if (min > array[i]) min = array[i];
            return min;
        }
        public static double MaxElementIndex(double[] array)
        {
            double max = array[0];
            int maxIndex = 0;
            for(int i=0; i < array.Length; i++)
            if (max < array[i])
            {
                max = array[i];
                maxIndex = i;
            }
            return maxIndex;
        }
        public static double AbsMaxElement(double[] array)
        {
            double abs = double.MinValue;
            double absMax = 0;
            for (int i =0;i< array.Length;i++)
            if (abs < Math.Abs(array[i]))
            {
                abs = Math.Abs(array[i]);
                absMax = array[i];
            }
            return absMax;
        }
        public static double IndexSumOfPositiveElements(double[] array)
        {
            int indexSum=0;
            for (int i=0;i< array.Length;i++)   
            if (array[i] > 0) indexSum += i;
            return indexSum;
        }
        public static double CountOfIntegers(double[] array)
        {
            int count=0;
            for(int i=0;i< array.Length;i++)
            if (array[i] == (double)Math.Round(array[i])) count++;
            return count;
        }
    }
}
