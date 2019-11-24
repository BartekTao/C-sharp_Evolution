#define example2
using System;

namespace Dynamic
{
    class Program
    {
#if example1
        static void Main(string[] args)
        {
            dynamic dyn = 1;
            object obj = 1;

            // Rest the mouse pointer over dyn and obj to see their
            // types at compile time.
            System.Console.WriteLine(dyn.GetType());
            System.Console.WriteLine(obj.GetType());
        }
#endif

#if example2
        static void Main(string[] args)
        {
            dynamic dynInt = 1;
            dynamic dynString = "thisIsString";
            int intValue = 1;

            addValue(intValue);
            addValue(dynInt);
            addValue(dynString);
#if example3
            string stringValue = "thisIsAnotherString";
            addValue(stringValue);
#endif

            static void addValue(int value)
            {
                Console.WriteLine(value + value);
            }
        }
#endif

    }
}
