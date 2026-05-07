// Exercise: 7-6: AdmissionModularized.cs

using System;
using static System.Console;
using System.Globalization;

class AdmissionModularized
{
    static void Main() {
      double gpa;
      int test;
      string result;
      Write("Enter grade point average >> ");
      gpa = Convert.ToDouble(ReadLine());
      Write("Enter test score >> ");
      test = Convert.ToInt32(ReadLine());
      result = AcceptOrReject(gpa, test);
      WriteLine(result);
    }
    public static string AcceptOrReject(double gpa, int test) {
      string response;
      if ((gpa >= 3.0 && test >= 60) || (gpa < 3.0 && test >= 80)) {
        response = "Accept";
      }
      else {
        response = "Reject";
      }
      return response;
    }
}
