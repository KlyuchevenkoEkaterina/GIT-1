using System;
using System.Collections.Generic;

namespace Task2
{
  //The entry point of the program.
  class EntryPoint
  {
    static void Main(string[] args)
    {
      List<int> listNumbers = new List<int>() { 8, 8, 45 };     
      RepeatingItemsSearcher repeatingItemsSearcher = new RepeatingItemsSearcher();
      Console.WriteLine(repeatingItemsSearcher.SearchRepeatingItems(listNumbers));      
    }
  }
}