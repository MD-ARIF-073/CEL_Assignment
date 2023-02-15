using System;


interface IExample     // interface declares two methods
{
    int GetIntValue();
    string GetStringValue();

}

class ExampleClass : IExample    //ExampleClass implements two methods 
{
    public int GetIntValue()
    {
        return 73;     //returns integer value
    }

    public string GetStringValue()
    {
        return "Welcome to C# Programming!";    //returns string value
    }
}


namespace interfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {

            IExample example = new ExampleClass();  //creates an instance of ExampleClass

            Console.WriteLine("Int value: " + example.GetIntValue()); //calling GetIntValue

            Console.WriteLine("String value: " + example.GetStringValue()); //calling GetStringValue
        }
    }
}


