using System;
namespace KRTask1ValidPath
{
  //This class is used to determine whether the path is valid.
  public class PathValidator
  {
    char[] unacceptableSymbols = { '*', '|', '"', '<', '>', '?', '/' };
    string[] unacceptableNames = { "CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "LPT1", "LPT2", "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9" };

    private string path;
    public string Path
    {
      get
      {
        return path;
      }
      set
      {
        path = value;
        if (path == String.Empty)
        {
          throw new WrongArgException();
        }
      }
    }

    public PathValidator(string path)
    {
      Path = path.ToUpper();
    }
    
    public bool SearchUnacceptableSymbols()
    {
      string[] substr = Path.Split('\\');
      foreach (var s in unacceptableSymbols)
      {
        for (int i = 0; i < substr.Length; i++)
        {
          if (substr[i].ToUpper().Contains(s.ToString()))
          {
            return false;
          }
        }
      }
      return true;
    }
  
    public bool SearchUnacceptableNames()
    {
      string[] substrings = Path.Split('\\', '.');
      foreach (var s in substrings)
      {
        foreach (var n in unacceptableNames)
        {
          if (s == n)
          {
            return false;
          }
        }
      }
      return true;
    }

    public bool SearchSpacePeriodInTheEndOfTheFilename()
    {
      return (!(Path[Path.Length - 1] == ' ' || Path[Path.Length - 1] == '.'));
    }

    public bool CheckBeginningRelativePath()
    {
      return ((Path[0] == '.' && Path[1] == '.' && Path[2] == '\\') || (Path[0] == '.' && Path[1] == '\\'));
    }

    public bool CheckBeginningAbsolutePath()
    {
      if (CheckAbsolutePathWithTwoColons())
      {
         return false;
      }
      if (((Path[0] >= 'A' && Path[0] <= 'Z') && Path[1] == ':') 
        || ((Path[0] >= 'A' && Path[0] <= 'Z') && (Path[1] == ':') && (Path[2] == '\\')))
      {
        return true;
      }
      return false;
    }

    public bool CheckAbsolutePathWithTwoColons()
    {
      int checkColons = 0;
      for (int i = 0; i < Path.Length; i++)
      {
        if (Path[i].Equals(':'))
        {
          checkColons++;
        }
      }
      return checkColons >= 2;
    }

    public bool CheckAbsolutePathWithOneLetter()
    {
      return ((Path[0] >= 'A' && Path[0] <= 'Z') && Path.Length == 1);
    }   

    public bool CheckSpaceAfterDiskname()
    {
      return (!(Path[0] >= 'A' && Path[0] <= 'Z') && (Path[1] == ' '));
    }
    
    public void IsThePathValid()
    {
      if ((CheckAbsolutePathWithOneLetter() || CheckBeginningAbsolutePath() || CheckBeginningRelativePath())
        && SearchUnacceptableNames()
        && SearchUnacceptableSymbols()
        && SearchSpacePeriodInTheEndOfTheFilename())     
      {
        Console.WriteLine("True");
      }
      else
      {
        Console.WriteLine("False");
      }
    }
  }
}