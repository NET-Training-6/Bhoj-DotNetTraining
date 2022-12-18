

// using System;
// class entry
// {
//     public static void Main()
//     {
//         // Number: integers and floating point
//         // integer
//         byte a = 12;
//         short b = 2350;
//         int c = 23456;
//         long d = 223455555;
//         //floating 
//         float e = 234.59545677655f;
//         double f = 3456.456;
//         decimal g = 2345675.45345544566m;

//         //Text
//         string name = "Bhoj joshi";
//         char gender = 'm';
//         //Boolean
//         bool areYouMale = true;
//         Console.WriteLine("the integer value test=" + a);
//         Console.WriteLine(b);
//         Console.WriteLine(c);
//         Console.WriteLine("Byte=" + d);
//         Console.WriteLine("Byte=" + a);
//         Console.WriteLine("Byte=" + a);
//         Console.WriteLine("Byte=" + a);


class test
{
    public static void Main()
    {
    //    var input = Console.ReadLine();
    //     var Number = int.par;
    //     if (Number % 2 == 0)
    //     {
    //         Console.WriteLine(Number + " is even");
    //     }
    //     else
    //     {
    //         Console.WriteLine(Number + " is odd");
    //     }
     Console.Write("Enter an amount:");
    int amt = int.Parse(Console.ReadLine());
    Console.Write ("Enter a Time period:");
    int ti = int.Parse(Console.ReadLine());
    Console.Write("Enter interest:");
    int rate = int.Parse(Console.ReadLine());
    int si= amt*ti*rate/100;
    Console.WriteLine("the simple interest is="+si); 
    }
   

}

