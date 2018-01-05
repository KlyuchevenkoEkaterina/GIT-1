using System;

namespace ArrayRealNumbers
{
    //This class allows to call a method
    //that fills the two-dimensional array.
    class ArrayInitializer
    {
        const int NUMBEROFLINES = 4;
        const int NUMBEROFCOLUMS = 5;

        //Method fill a two-dimensional array with random real numbers
        //and outputs it to the console.
        public double[,] InitializeArray()
        {
            Random rand = new Random();
            double[,] array = new double[NUMBEROFLINES, NUMBEROFCOLUMS];
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.NextDouble() * 10;
                    Console.Write(array[i, j] + "   ");
                }
                Console.WriteLine();
            }            
            return array;
        }
    }
}
