using System;

namespace KRTask1ValidPath
{
  //The entry point of the program.
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        PathValidator validator = new PathValidator(args[0]);
        validator.IsThePathValid();
      }
      catch (WrongArgException ex)
      {
        Console.Write(ex.Message);
      }
      catch (Exception ex)
      {
        Console.Write(ex.Message);
      }

    }
  }
}

