using System;
using System.Collections.Generic;

namespace GradeBook {
  class Program {
    static void Main(string[] args) {

      var book = new Book("Scott's Grade Book");
      book.AddGrade(90);
      book.AddGrade(91.5);
      book.AddGrade(15.5);
      book.ShowStatistics();
    }
  }
}
