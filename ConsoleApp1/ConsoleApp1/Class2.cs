using System;
using System.Collections.Generic;

public class Class2
{

  public Class2() {
    grades = new List<double>();
  }
  public void AddGrade(double grade) {
    Console.WriteLine("Hello from Class2");
    grades.Add(grade);
  }
  List<double> grades = new List<double>();
}
