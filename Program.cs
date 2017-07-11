using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Krista"},
                {"age", "42"}
            });

            foreach (var member in myFamily)  {
                Console.WriteLine("{0} is my {1} and is {2} years old.", member.Value["name"], member.Key, member.Value["age"]);
            }
        }
    }
}
