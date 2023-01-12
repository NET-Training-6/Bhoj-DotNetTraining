using System;
using System.Collections.Generic;

class CollectionLearner22
{
    //list of something
  
        //     List<int> numbers = new List<int>();
        //     numbers.Add(2345);
        //     numbers.Add(4355);
        //     numbers.Add(123);
        //     numbers.Add(2555);
        //     numbers.Add(2654);
        //     numbers.Add(83757);
        //     numbers.Remove(123);

        //     foreach (var num in numbers)
        //     {
        //         Console.WriteLine(num);
        //     }

        //create list to store name of 10 people

//         List<string> Peoples = new List<string>();
//         Peoples.Add("Bikash");
//         Peoples.Add("Hari");
//         Peoples.Add("mahesh");
//         Peoples.Add("Bhoj");
//         Peoples.Add("Khem");
//         Peoples.Add("Gopal");
//         Peoples.Add("Ram");
//         Peoples.Add("Velubaze");
//         Peoples.Add("vote");
//         Peoples.Add("paso");

//         foreach (var name in Peoples)
//         {

            
//             {
//                 Console.WriteLine(name.ToUpper());
//             }
//         }
//     }
// }
// public void LearnDictionary()
// {
// key values paris
// Dictionary<string, byte> people = new ();
// people.Add("Ram", 43);
// people.Add("Shyam", 23);
// people.Add("Paso", 53);
// people.Add("Vote", 15);
// people.Add("Suraj", 25);
// people.Add("Bhoj", 17);
// people.Add("Pream", 35);
// people.Add("Gopal", 18);
// foreach(var person in people)
// {
//     Console.WriteLine($"{person.Key} => {person.Value}");
// }
//}
// create a data structure to store list of country name, its population and area in square meter
public void TupleList()
{
    // (string cName , long population,double area) = 
    List<(string country, long population, double area)> contries = new ();
    contries.Add(("Nepal",247567,3456.43));
    contries.Add(("India",247567234,345634.4543));
    contries.Add(("China",467567,34556.4343));
    contries.Add(("Usa",2474667,345746.54643));
    foreach(var country in contries)
    {
 Console.WriteLine($"country : {country.country} \nPopulatoon : {country.population}\narea : {country . area}\n\n");
    }
   
}
 }



    

 