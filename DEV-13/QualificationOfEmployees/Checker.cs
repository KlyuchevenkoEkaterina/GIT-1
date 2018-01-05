namespace QualificationOfEmployees
{
  class Checker
  {
    public void CheckSum(int sum)
    {
      if (sum < 100)
      {
        throw new WrongSumException();
      }
    }

    public void CheckProductivity(int productivity)
    {
      if (productivity < 50)
      {
        throw new WrongProductivityException();
      }
    }
  }
} 