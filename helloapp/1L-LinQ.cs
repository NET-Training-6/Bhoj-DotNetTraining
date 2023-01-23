// Language integrated query- LinkQ
//way thchnique to query collenction
using System;
using System.Collections.Generic;
using System.Linq;

class Linq
{
    int[] numbers = { 2, 3, 4, 5, 6, 7, 50, 60, 70 };
    List<string> names = new () {"bhoj" , "Niranjana", "bhagrati", "bishnu", "Amar", "Anju", "Bam", "Ram"};
    List<Employee> employees = new()
    {
        new Employee() {Name = "shyam karki", Age = 33, Department = "HR", designation = "software Engineering"},
        new Employee() {Name = "Ram basnet", Age = 23, Department = "HR", designation = "software Engineering"},
        new Employee() {Name = "Bhoj Joshi", Age = 23, Department = "R&d", designation = "Computer Engineering"},
        new Employee() {Name = "suraj Bam", Age = 24, Department = "Huminaties", designation = "arts"},
        new Employee() {Name = "Mahesh Bhatt", Age = 25, Department = "HR", designation = "software Engineering"},
    };
    public void Test()
    {
        // get even number is "numbers"
        List<int> evenNumbers = new List<int>();
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evenNumbers.Add(num);
            }
        }
        // ta this poing "evenNumber" has only even number in it
        //Get all Odd number in "Numbers"
        //Get all numberds which ends with "0"
        var evenNumber = evenNumbers.Where(num => num % 2 == 0);

        var oddNumber = numbers.Where(num => num % 2 != 0);

        var numsEnding0 = numbers.Where(num => num.ToString().EndsWith("0"));

    
        foreach (var n in numsEnding0)
        {
           // Console.WriteLine(n);

        }

        var greaternumber = numbers.Where(num => num > 50).Select(numbers => numbers);
        foreach (var n in greaternumber)
        {

           // System.Console.WriteLine(n);
        }
        // Get all person names which starts with Latter 'A' in "Names" List
        var name = names.Where(name=> name.StartsWith("A"));
        foreach(var n in name)
        {
          //  Console.WriteLine(n);
        }
        // get all peosin names with less then 4 characters and convert then to upercace
      var person = names.Where(numbers => numbers.Length < 4).Select(n => n.ToUpper());

        foreach (string names in person)
        {
            //Console.WriteLine(names);
        }
        // Get initial (first Later) of names which contains "is" in it.
        
    }
     
    
     public void LinQDay2()
    {
        // find if "Numbers" array contain any even number 
         
         var hasEven = numbers.Any(n=> n % 2 == 0);
      // find if "Numbers" array has all even number 
      var allEven = numbers.All (n => n % 2 == 0);

      // Get first 5 elements from number 
      var firstFive = numbers.Take(5);

      //Get first 5 elements Skipping first 2 from numbers
      var X = numbers.Skip(2).Take(5); 

    }
  public void LearnToQueryComplexCollection()
  {
    // Get all employee in HR department
    var x = employees.Where(e => e.Department == "HR");
    // Get number of employee in HR department

    var x1 = employees.Where(e=> e.Department == "HR").Select(E => E.Name);
      
      
    // Get all software engineering under age of 20
    var softwareEngineering = employees.Where(employee=> employee.designation == "SE" && employee.Age == 22);
    foreach(var employee in softwareEngineering)
    {
       // Console.WriteLine(employee.Name);
    }
    var enenNumber = numbers.Where(num => num % 2 == 0);
     var evenNums = from num in numbers
    where num % 2 == 0
    select num;

    // get all odd numbers in "numbers"
     var oddNums = from num in numbers 
    where num % 2 == 0
    select num;
}
 public void country1()
 {
 List<Country> countries = new()
        {
            new Country(name: "Nepal",continent:"Asia",area:21115.45,gdp:4500),
            new Country(name : "India",continent : "Asia",area : 178.23,gdp : 155478),
            new Country(name : "China",continent : "Asia",area : 9823443.23,gdp : 154672),
            new Country(name : "Africa",continent : "Africa",area : 455645.23,gdp : 125545647),
            new Country(name : "Pakistan",continent : "South asia",area : 7895462165.23,gdp : 110000),
            new Country(name : "Iran",continent : "Europe",area : 85216479.23,gdp : 122598),
            new Country(name : "Turkey",continent : "Asia",area : 1234599.23,gdp : 12545677),
            new Country(name : "Afghanistan",continent : "Asia",area : 1255879444.23,gdp : 9500),
            
        };

        //Sorting countries by area
        var countriesByArea = countries.OrderBy(country => country.area);
        //Expression syntax
        countriesByArea = from country in countries orderby country.area select country;
        foreach (var country in countriesByArea)
        {
            Console.WriteLine($"Country : {country.name}, Area : {country.area.ToString("N0")} ");
        }

        //sorting countries by their gdp
        var countriesByGDP = countries.OrderBy(country => country.gdp);
        //Expression syntax 
        countriesByGDP = from country in countries orderby country.gdp select country;
        Console.WriteLine("\n\n");
        foreach (var country in countriesByGDP)
        {
            Console.WriteLine($"Country : {country.name}, GDP : {country.gdp.ToString("N0")} ");
        }

    }
   public class Country
{
    public string name;
    public string continent;
    public double area;
    public double gdp;

    public Country(string name, string continent, double area, double gdp)
    {
        this.name = name;
        this.continent = continent;
        this.area = area;
        this.gdp = gdp;

    }

}
 }
 
 
public class Employee
{
    public string Name {get;set;}
    public int  Age{get; set; }
    public string Department {get; set;}
    public string designation {get; set;}
}



