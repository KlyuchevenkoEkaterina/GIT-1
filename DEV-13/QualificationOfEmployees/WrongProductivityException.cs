using System;

namespace QualificationOfEmployees
{
  class WrongProductivityException: Exception
  {
    public override string Message
    {
      get
      {
        return "Productivity must be higher 50";
      }
    }
  }
}
