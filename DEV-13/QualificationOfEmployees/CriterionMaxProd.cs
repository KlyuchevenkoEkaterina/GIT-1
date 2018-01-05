using System.Collections.Generic;
using System;

namespace QualificationOfEmployees
{
  /// <summary>
  /// This class is used to call the first criterion: max productivity within the sum.
  /// </summary>
  class CriterionMaxProd
  {
    /// <summary>
    /// The method gives the necessary emloyees corresponding to the first criterion.
    /// </summary>
    /// <param name="sum"> The sum entered by the user </param>    
    /// <param name="employee">List of employees</param>
    /// <returns> List of employees that corresponding to the first criterion.</returns>
    public List<Employee> SelectEmployees(int sum, List<Employee> employee)
    {    
      List<Employee> company = new List<Employee>();
     
      for (int i = 0; i < employee.Count; i++)
      {
        while (sum - employee[i].Salary >= 0)
        {
          company.Add(employee[i]);
          sum -= employee[i].Salary;
        }
      }
      return company;
    }
  }
}