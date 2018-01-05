using System;

namespace QualificationOfEmployees
{
  /// <summary>
  /// This class is used to input sum and productivity.
  /// </summary>
  class Inputer
  {
    const string SUM = "Input sum: ";
    const string PRODUCTIVITY = "Input productivity: ";

    public int InputSum()
    {
      Console.WriteLine(SUM);
      int sum = 0;
      bool sumInputNeeded = true;
      while (sumInputNeeded)
      {
        try
        {
          sum = int.Parse(Console.ReadLine());          
          sumInputNeeded = false;         
        }       
        catch
        {
          Console.WriteLine("Error! Wrong format. Try again.");
          Console.WriteLine(SUM);
        }       
      }
      return sum;
    }

    public int InputProductivity()
    {
      Console.WriteLine(PRODUCTIVITY);
      int productivity = 0;
      bool prodInputNeeded = true;
      while (prodInputNeeded)
      {
        try
        {
          productivity = int.Parse(Console.ReadLine());
          prodInputNeeded = false;
        }      
        catch
        {
          Console.WriteLine("Error! Wrong format. Try again.");
          Console.WriteLine(PRODUCTIVITY);
        }
      }
      return productivity;
    }
  }
}