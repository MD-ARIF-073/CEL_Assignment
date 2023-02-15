using System;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class Class2 : Class1
    {
        public void PrintValues()
        {
            Console.WriteLine("PublicInt: " + PublicInt);
            Console.WriteLine("ProtectedInt: " + ProtectedInt);
            Console.WriteLine("InternalProtectedInt: " + InternalProtectedInt);

            // The following line will result in a compilation error because the private member cannot be accessed
            // Console.WriteLine("PrivateInt: " + PrivateInt);
        }
    }
}

