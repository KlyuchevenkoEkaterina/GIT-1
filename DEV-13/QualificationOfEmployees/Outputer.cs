using System;
using System.Collections.Generic;

namespace QualificationOfEmployees
{
  /// <summary>
  /// This class is used to output necessary emloyees.
  /// </summary>
  class Outputer
  {
    public void Output(List<Employee> company)
    {
      foreach (Employee emp in company)
      {
        Console.WriteLine(emp.Qualification);
      }
    }   
  }
}