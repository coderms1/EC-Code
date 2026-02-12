// ProjectedRaises.cs

using System;
using static System.Console;
using System.Globalization;
  

class ProjectedRaises {

    public static void Main() 
    {

	// INPUT
	const double PAY_RAISE = 0.04;
	
	double salary1 = 25000;
	double salary2 = 38000;
	double salary3 = 51000;
	
	// LOGIC (calculation) 
	double salary1Next = salary1 + (salary1 * PAY_RAISE);
	double salary2Next = salary2 + (salary2 * PAY_RAISE);
	double salary3Next = salary3 + (salary3 * PAY_RAISE);
	
	// OUTPUT
	WriteLine("Next year's salary for the first employee will be {0}", salary1Next.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	WriteLine("Next year's salary for the second employee will be {0}", salary2Next.ToString("C", CultureInfo.GetCultureInfo("en-US")));
	WriteLine("Next year's salary for the third employee will be {0}", salary3Next.ToString("C", CultureInfo.GetCultureInfo("en-US")));
		
    }
}
