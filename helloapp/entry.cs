
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
        int wrd, l, s, sent;
        l = 0;
        wrd = 1;
        s=0;
        sent = 0;
        while (l <= story.Length - 1)
        {
            if (story[l] == ' ' )
            {
                wrd++;
            }

            l++;

        }
        Console.Write("Total number of words in the story is : {0}\n", wrd);

        while (s <= story.Length -1)
        {
            if (story[s] == '.' )
            {
                sent++;
            }

            s++;

        }
        Console.Write("Total number of sentence in the story is : {0}\n", sent);

    }
}

