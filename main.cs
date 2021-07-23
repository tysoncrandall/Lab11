using System;


class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Testing Faculty 1");
    Faculty f1 = new Faculty("Tyson", "Crandall");
    f1.DateOfBirth = Convert.ToDateTime("01/01/2005");
    f1.PermanentAddress.AddressLine1 = "4121 Ohio Street";
    f1.PermanentAddress.City = "Fairview Park";
    f1.PermanentAddress.State = "OH";
    f1.PermanentAddress.Zipcode = "44126";
    f1.Title = "Instructor";
    f1.Employer = "Cuyahoga County Community College";
    f1.YearlySalary = 39000;
    f1.Tenured = true;
    f1.DateOfEmployment = Convert.ToDateTime("03/07/2012");
    f1.Intro();
    f1.GrantTenure();
    f1.Promote();
    
  }
}