using System;
using System.Collections.Generic;

namespace QualificationOfEmployees
{
  /// <summary>
  /// The entry point of the program.
  /// </summary>
  class EntryPoint
  {    
    const string CRITERION= "Choose criterion: \n1) Max productivity within the sum,\n2) Min cost with a fixed productivity, \n3) Min number of employees for fixed productivity";

    static void Main(string[] args)
    {
      Inputer input = new Inputer();
      int sum = input.InputSum();
      int productivity = input.InputProductivity();
      do
      {
        Console.WriteLine(CRITERION);
        string criterion = Console.ReadLine();
        Employee junior = new Junior();
        Employee middle = new Middle();
        Employee senior = new Senior();
        Employee lead = new Lead();
        Checker checker = new Checker();
        Outputer outPut = new Outputer();
        try
        {
          switch (criterion)
          {
            case "1":
              CriterionMaxProd maxProd = new CriterionMaxProd();
              List<Employee> empMaxProd = new List<Employee>();//arranged in descending order of productivity.
              empMaxProd.Add(lead);
              empMaxProd.Add(senior);
              empMaxProd.Add(middle);
              empMaxProd.Add(junior);              
              checker.CheckSum(sum);
              List<Employee> compMaxProd = maxProd.SelectEmployees(sum, empMaxProd);
              outPut.Output(compMaxProd);
              break;
            case "2":
              CriterionMinValue minValue = new CriterionMinValue();
              List<Employee> empMinValue = new List<Employee>();// arranged in increasing productivity.
              empMinValue.Add(junior);
              empMinValue.Add(middle);
              empMinValue.Add(senior);
              empMinValue.Add(lead);
              checker.CheckProductivity(productivity);
              List<Employee> compMinValue = minValue.SelectEmployees(productivity, empMinValue);
              outPut.Output(compMinValue);
              break;
            case "3":
              CriterionMinNumOfEmp minNumOfEmp = new CriterionMinNumOfEmp();
              List<Employee> empMinNumOfEmp = new List<Employee>();//arranged in descending order of productivity.
              empMinNumOfEmp.Add(lead);
              empMinNumOfEmp.Add(senior);
              empMinNumOfEmp.Add(middle);
              checker.CheckProductivity(productivity);
              List<Employee> compMinNum = minNumOfEmp.SelectEmployees(productivity, empMinNumOfEmp);
              outPut.Output(compMinNum);
              break;
            default:
              Console.WriteLine("Wrong number! Press any button to continue or escape to exit.");
              break;
          }
        }
        catch (WrongSumException ex)
        {
          Console.WriteLine(ex.Message);
        }
        catch (WrongProductivityException ex)
        {
          Console.WriteLine(ex.Message);
        }
      }
      while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
  }             
}