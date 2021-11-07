using System;

namespace EggDropProblem
{
  class Solution
  {
    static void Main()
    {
      EggDrop(2, 300);
    }
    static void EggDrop(int n, int k)
    {
      if (n == 1 || k == 1 || k == 0)
      {
        Console.WriteLine(k);
      }
      // Write an answer using Console.WriteLine()
      // To debug: Console.Error.WriteLine("Debug messages...");
      double floor = Math.Floor((-1 + Math.Sqrt(1 + 8 * k)) / 2);
      Console.WriteLine(floor);
      int result = 0;
      double tryFloor = 0;
      for (int i = 0; i < k; i++)
      {
        Console.WriteLine("scenario: " + i);
        tryFloor = floor - i + tryFloor;
        Console.WriteLine("tryFloor: " + tryFloor);
        if (tryFloor >= k || floor - i < 0)
        {
          break;
        }
        result++;
      }
      Console.WriteLine(result);
    }
  }

  class GFG
  {

    /* Function to get minimum number of
    trials needed in worst case with n
    eggs and k floors */
    static int eggDrop(int n, int k)
    {
      // If there are no floors, then
      // no trials needed. OR if there
      // is one floor, one trial needed.
      if (k == 1 || k == 0)
        return k;

      // We need k trials for one egg
      // and k floors
      if (n == 1)
        return k;

      int min = int.MaxValue;
      int x, res;

      // Consider all droppings from
      // 1st floor to kth floor and
      // return the minimum of these
      // values plus 1.
      for (x = 1; x <= k; x++)
      {
        res = Math.Max(eggDrop(n - 1, x - 1),
                       eggDrop(n, k - x));
        if (res < min)
          min = res;
      }

      return min + 1;
    }

    // Driver code
    static void Main()
    {
      int n = 2, k = 10;
      Console.Write("Minimum number of "
                    + "trials in worst case with "
                    + n + " eggs and " + k
                    + " floors is " + eggDrop(n, k));
    }
  }
}

/*
 * n = 100
 * k = 2
 * x = floor
 * 
 * x(x+1)/2 = n
 * x(x+1)/2 = 100 <=> x^2+x = 200 <=> x^2 = 200 - x <=> x = sqrt(200-x) => x = 14-sqrt(x)
 * 
 * 
 */