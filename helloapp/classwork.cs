using System.Collections.Generic;
using System;
 class collectionSolution
{
    public void ListNumber()
    {
            List<long> number = new List<long>(){15, 456, 7678,76554, 6578,789,345};
            foreach(long num in number)
            {
                if (num %3 == 0 && num % 5 == 0)
                {
                Console.WriteLine(num);
                }
           
            }        
    }
    // create list of date if birth of 8 people print those dobs in console oldest first
    public void listDobs()
    {
        List<DateTime>dobs = new List<DateTime>()
        {

        
     new DateTime(1999, 12, 12),
     new DateTime(1989, 11, 22),
     new DateTime(1959, 09, 30),
     new DateTime(1943, 04, 24),
     new DateTime(1998, 03, 23),
     new DateTime(1957, 05, 21),
     new DateTime(1956, 04, 15)
        
    };
    dobs.Sort();
    foreach (DateTime dob in dobs)
    {
        Console.WriteLine(dob.ToString("MMMM dd, yyyy"));
    }
    
    }
}   
    



