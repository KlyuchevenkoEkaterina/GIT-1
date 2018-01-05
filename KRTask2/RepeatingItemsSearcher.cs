using System.Collections.Generic;

namespace Task2
{  
  class RepeatingItemsSearcher
  {
    //This method is used to search and count repeating items.
    public int SearchRepeatingItems(List<int> listnumbers)
    {
      List<int> resultList = new List<int>();
      listnumbers.Sort();
      for (int i = 0; i < listnumbers.Count-1; i++)
      {
        if (listnumbers[i] == listnumbers[i + 1] || listnumbers[i + 1] == listnumbers[i + 2])
        {
          if (!resultList.Contains(listnumbers[i + 1]))
          {
            resultList.Add(listnumbers[i + 1]);
          }
        }
      }      
      return resultList.Count;
    }
  }
}