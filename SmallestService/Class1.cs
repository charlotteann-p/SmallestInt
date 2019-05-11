using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
        public int FindSmallestInt(int[] arr)
        {
            if (arr.Length == 1)
                return arr[0];
            if (arr.Length == 2)
                return (arr[0] < arr[1] ? arr[0] : arr[1]);
            //if (arr.Length == 3)
            //{ 
            //  if (arr[0] < arr[1] && arr[0] < arr[2])
            //  {
            //      return arr[0];
            //  }
            //  else
            //  {
            //      if (arr[1] < arr[0] && arr[1] < arr[2])
            //      {
            //          return arr[1];
            //      }
            //      else
            //      {
            //          return arr[2];
            //      }
            //  }
            //}
            if (arr.Length > 3)
            {
                int max = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < max)
                        max = arr[i];
                }
                return max;
            }
            else
                throw new ArgumentException();
       
        }
    }
}
