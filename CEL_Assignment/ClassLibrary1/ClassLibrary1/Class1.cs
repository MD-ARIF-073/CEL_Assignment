using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int PublicInt { get; set; }
        private int PrivateInt { get; set; }
        protected int ProtectedInt { get; set; }
        internal protected int InternalProtectedInt { get; set; }

        public Class1()
        {
            PublicInt = 1;
            PrivateInt = 2;
            ProtectedInt = 3;
            InternalProtectedInt = 4;
        }
    }
}

