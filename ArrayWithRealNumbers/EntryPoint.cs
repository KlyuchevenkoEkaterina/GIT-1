using System;
using System.Collections;

namespace ArrayRealNumbers
{ 
    //The entry point of the program
    class EntryPoint
    {
        static void Main(string[] args)
        {   
            ArrayInitializer arrayInitializer = new ArrayInitializer();
            double[,] resultarray  = arrayInitializer.InitializeArray();

            NewArrayMaker newArrayMaker = new NewArrayMaker();
            ArrayList outarray = newArrayMaker.MakeNewArray(resultarray);

            NotDuplicateElementChecker NotDuplicateElement = new NotDuplicateElementChecker();
            bool flag = NotDuplicateElement.CheckNotDuplicateElement(outarray);
            if (flag)
            {
                Console.Write("There are no duplicate elements!");
            }

            newArrayMaker.OutputNewArray(outarray);
            Console.ReadKey();          
        }
    }
}
