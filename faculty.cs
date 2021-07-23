using System;

class Faculty : Person
{
  public string Id{get; set;}
  public string Title {get; set;}
  public string Employer {get; set;}
  public decimal YearlySalary {get; set;}
  public bool Tenured {get; set;}
  public int experience {get; set;}

  /*public override DateTime DateOfEmployment {
    get{return base.DateOfEmployment;}
    
    set{

      int time = DateTime.Today.Year - value.Year;
      if (time > 0)
        base.DateOfEmployment = value;
      else
        Console.WriteLine("Employment will be set to 0");  
        base.DateOfEmployment = 0;   
      }
  }*/

    public override DateTime DateOfEmployment {
    get{return base.DateOfEmployment;}
    
    set{

      experience = DateTime.Today.Year - value.Year;
      Console.WriteLine("Employment time= "+ experience);
      base.DateOfEmployment = value;   
      }
    }
  public Faculty() : base()
  {
  Console.WriteLine("Instructor constructor");
  Title = "Instructor";
  }

  public Faculty(string fname, string lname) : base(fname, lname)
  {
    Console.WriteLine("Instructor constructor");
    Title="Instructor";
  }

  public void GrantTenure()
  {
    if (DateTime.Today.Year - DateOfEmployment.Year > 5)
    {
      Tenured = true;
    }
    else
    {
      Tenured = false;
    }
  }

    public void Promote()
  {
    if ((Title == "Instructor") && (experience > 2))
    {
      Title = "Assistant Professor";
      Console.WriteLine("Faculty promoted to " + Title + " rank");
    }
    else if ((Title == "Assistant Professor") && (experience > 5))
    {
      Title = "Associate Professor";
      Console.WriteLine("Faculty promoted to " + Title + " rank");
    }
    else if ((Title == "Associate Professor") && (experience > 10))
    {
      Title = "Professor";
      Console.WriteLine("Faculty promoted to " + Title + " rank");
    }
    else
    {
      Console.WriteLine("No more promotion possible");
    }
  }

  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("I work as a(n) " + Title + " at " + Employer + " since " + DateOfEmployment);
  }
}