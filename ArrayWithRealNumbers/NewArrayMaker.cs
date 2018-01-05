using System;
using System.Collections;
  
namespace ArrayRealNumbers
{
    //This class is used to call the method of searching for duplicate elements
    //and the method of outputting them to the console.
    class NewArrayMaker
    {             
        const double EPSILON = Double.Epsilon;

        //The method allows to find duplicate elemets.
        public ArrayList MakeNewArray(double[,] array)
        {    
            ArrayList newarraylist = new ArrayList();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int count = 0;
                    for (int k = 0; k < array.GetLength(0); k++)
                    {
                        for (int l = 0; l < array.GetLength(1); l++)
                        {
                            if (Math.Abs(array[i, j] - array[k, l]) < EPSILON)
                            {
                                count++;
                                break;
                            }                            
                        }
                    }
                    if (count >= 2)
                    {
                        if (!newarraylist.Contains(array[i, j]))
                        {
                            newarraylist.Add(array[i, j]);
                        }
                        break;
                    }
                }
            }
            return newarraylist;
        }

        //The method of outputting duplicate elemets to the console.
        public void OutputNewArray(ArrayList newarraylist)
        {
            for (int i = 0; i < newarraylist.Count; i++)
            {
                Console.Write("\nDyblicate element: " + newarraylist[i] + " ");
            }
        }
    }
}
            
      




      
    

    



