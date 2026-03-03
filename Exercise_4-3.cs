// Admission.cs

using System;
using static System.Console;
using System.Globalization;

class Admission {

  static void Main() {
    Write("Enter high school GPA: ");
    double gpa = Convert.ToDouble(ReadLine());
    Write("Enter admission test score: ");
    double testScore = Convert.ToDouble(ReadLine());

    if (gpa >= 3.0 && testScore >= 60 || gpa < 3.0 && testScore >= 80) {
      WriteLine("Accept");
    } else {
      WriteLine("Reject");
    }
  }
}
