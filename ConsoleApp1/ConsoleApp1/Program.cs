  using System;
  using System.Collections.Generic;

namespace ConsoleApp1
  {
  class Program
  {   
      //Method Main (.net run looks for Main). Strongly typed lang. Type args stringarray
      static void Main(string[] args)
      {
          double x = 32.1;
          double y = 2.1;
          Console.WriteLine(x + y);

          double[] numbers = new double[3]; //can hold 3 floatnumbers
          numbers[0] = 13.4;
          numbers[1] = 20.2;
          numbers[2] = 20.2;

          var numbers2 = new double[] { 1, 2, 3 };

          var numbers3 = new[] { 1, 2, 3 };
          var grades = new List<double>() { 12.5, 13.4, 7.11 };
          grades.Add(56.1);

          //using class2 in class1
          var book = new Class2();
          book.AddGrade(55.5);
            


          if(args.Length>0)
          {
              Console.WriteLine("Hello" + args[0] + "!");
              Console.WriteLine($"Hello {args[0]} !");
          }
          else
          {
              Console.WriteLine("Hello!");
          }
      }
  }
}
