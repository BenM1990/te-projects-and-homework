using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            int listOneLength = listOne.Count;
            int listTwoLength = listTwo.Count;
            int remaining;
            
            List<int> finalList = new List<int>();

            if (listOneLength == listTwoLength)
            {
                for (int i = 0; i < listTwo.Count; i++)
                {
                    finalList.Add(listOne[i]);
                    finalList.Add(listTwo[i]);
                }
            }

            else if (listOneLength > listTwoLength)
            {

                for (int i = 0; i < listTwo.Count; i++)
                {
                    finalList.Add(listOne[i]);
                    finalList.Add(listTwo[i]);
                }
                remaining = listOneLength - listTwoLength;

                for (int i = listOneLength - remaining; i < listOne.Count; i++)
                {
                    finalList.Add(listOne[i]);
                    
                }
            }
            else
            {
                for (int i = 0; i < listOne.Count; i++)
                {
                    finalList.Add(listOne[i]);
                    finalList.Add(listTwo[i]);
                }
                remaining = listTwoLength - listOneLength;

                for (int i = listTwoLength - remaining; i < listTwo.Count; i++)
                {
                    
                    finalList.Add(listTwo[i]);
                }

            }

                return finalList;
            
        }
    }
}
