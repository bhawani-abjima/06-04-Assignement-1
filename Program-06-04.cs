using System;
using System.Runtime.ConstrainedExecution;

enum Months
{
    January,    // 0
    February,   // 1
    March,      // 2
    April,      // 3
    May,        // 4
    June,       // 5
    July        // 6
}
public class Customer
{
    public string Name { get; set; }
    public Gender Gender { get; set; }
}
public enum Gender
{
    Unkown,
    Male,
    Female
}
class Program
{
    enum Level           //enum declaration and uses   
    {
        Low,
        Medium,
        High
    }

    private string model = "Mustang";    //using private access modifier 
    public string Toyta = "Supra";       //using public access modifier
    static void Main(string[] args)
    {
        Customer[] CST = new Customer[3];
        CST[0]= new Customer
        {
            Name = "Mark",
            Gender = Gender.Unkown
        };
        CST[1] = new Customer
        {
            Name = "Adam",
            Gender = Gender.Male
        };
        CST[2] = new Customer
        {
            Name = "Eve",
            Gender = Gender.Female
        };

        foreach(Customer PP in  CST)
        {
          Console.WriteLine("Name={0} && Gender={1}",PP.Name,PP.Gender);
        }
        static string GetGender(Gender gender)
        {
            switch(gender) 
            {
                case Gender.Unkown:
                    return "unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data detected";
            }
        }

        Level myVar = Level.Medium;
        Console.WriteLine(myVar);

        int myNum = (int)Months.April;
        Console.WriteLine(myNum);

        Program myObj = new Program();
        Console.WriteLine(myObj.model);

        Program SST = new Program();
        Console.WriteLine(myObj.model);
    }
}

