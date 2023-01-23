// Managed and unmanaged code
// Memrory management

using System;

class animal1
{
    public string animalName;
    public int noOfLegs;
    public bool isDomestic;

    // Default parameterless constructor
    public animal1()
    {        
    }

    // Parameterized constructor
    public animal1(string name, bool isDomestic)
    {
        animalName = name;
        this.isDomestic = isDomestic;
    }

    public animal1(string name, bool isDomestic, int legs)
    {
        animalName = name;
        this.isDomestic = isDomestic;
        noOfLegs = legs;
    }
}

class Test1
{
    internal void country1()
    {
        throw new NotImplementedException();
    }

    void Test2()
    {
        animal1 animal1 = new animal1("Dog", true);
        animal1 animal2 = new animal1();
    }
}