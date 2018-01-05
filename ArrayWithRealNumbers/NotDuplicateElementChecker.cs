using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRealNumbers
{
    //This class is used to check the existence of duplicate elements.
    class NotDuplicateElementChecker
    {
        //The method of checking whether or not duplicate elements in a new array.
        public bool CheckNotDuplicateElement(ArrayList newarraylist)
        {           
            if (newarraylist.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
