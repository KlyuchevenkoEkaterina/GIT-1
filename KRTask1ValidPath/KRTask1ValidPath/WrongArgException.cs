using System;

namespace KRTask1ValidPath
{
  class WrongArgException: Exception
  {
    public override string Message
    {
      get
      {
        return "Empty path.";
      }
    }
  }
}
