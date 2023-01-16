// Language integrated query- LinkQ
//way thchnique to query collenction
using System;
using System.Collections.Generic;
using System.Linq;

class Linq
{
    int[] numbers = { 2, 3, 4, 5, 6, 7, 50, 60, 70 };
    List<string> names = new () {"bhoj" , "Niranjana", "bhagrati", "bishnu", "Amar", "Anju"};

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
            Console.WriteLine(n);
        }
        // get all peosin names with less then 4 characters and convert then to upercace
    }
}