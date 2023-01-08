
class entry
{
    public static void Main()
    {
        //   string address = "Tinkune, Kathmandu-Nepal";
        //   address = address.Replace("-","-,").Replace(" ","");
        //   var arr = address.Split(",");
        //   Console.WriteLine(address);
        //   string locality = arr[0];
        //   string name = arr[1];
        //   string country = arr[2];
        //   Console.WriteLine($"locality : {locality}");
        //   Console.WriteLine($"city : {name}");
        //   Console.WriteLine($"country : {country}");

      
         var story = @"When the C# program is executed//
    , the assembly is loaded into the CLR.//
     The CLR performs Just-In-Time (JIT) compilation to convert the IL code to native machine instructions.//
      The CLR provides other services related to automatic garbage collection, exception handling, and resource management.//
       Code that's executed by the CLR is sometimes referred to as//
       is compiled into native machine language that targets a specific platform.";
      
      
        char[]separators = {'.','?'};
        string[] sentences = story.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int noOfsentance = sentences.Length;
        Console.WriteLine("total number of sentance in the story is:"+ sentences);
    foreach(var s in sentences )
    {
        Console.WriteLine("total number of owrds in the story is:"+ sentences);
        
    }
       
    }
}

