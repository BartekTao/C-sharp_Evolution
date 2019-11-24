#define example2
#define example3
using System;

namespace StringPool
{
    class Program
    {
        static void Main(string[] args)
        {
#if example1
            string str1 = "abcd1234";
            string str2 = str1;
            string str3 = "abcd" + "1234";

            Console.WriteLine(string.Format("ReferenceEquals(str1, str2) = {0}", ReferenceEquals(str1, str2)));
            Console.WriteLine(string.Format("ReferenceEquals(str1, str3) = {0}", ReferenceEquals(str1, str3)));
#endif
#if example2
            var temp = "aaaa";
            string str1 = "aaaaaaaa";
            string str2 = temp + "aaaa";
            string str3 = new string('a', 8);
#if example3
            str2 = string.Intern(str2);
            str3 = string.Intern(str3);
#endif
            Console.WriteLine(string.Format("ReferenceEquals(str1, str2) = {0}", ReferenceEquals(str1, str2)));
            Console.WriteLine(string.Format("ReferenceEquals(str1, str3) = {0}", ReferenceEquals(str1, str3)));
#endif
        }
    }
}
