using System.Collections.Generic;

namespace QualificationOfEmployees
{
  /// <summary>
  /// This class is used to call the third criterion: 
  /// The min number of employees that higher than the junior qualification for a fixed productivity.
  /// </summary>
  class CriterionMinNumOfEmp
  {
    /// <summary>
    /// The method gives the necessary emloyees corresponding to the third criterion.
    /// </summary>    
    /// <param name="productivity">The productivity entered by the user</param>
    /// <param name="employee">List of employees</param>
    /// <returns> List of employees that corresponding to the third criterion.</returns>
    public List<Employee> SelectEmployees(int productivity, List<Employee> employee)
    {      
      List<Employee> company = new List<Employee>();

      for (int i = 0; i < employee.Count; i++)
      {
        while (productivity - employee[i].Productivity >= 0)
        {
          company.Add(employee[i]);
          productivity -= employee[i].Productivity;
        }        
      }    
      return company;
    }   
  }
}