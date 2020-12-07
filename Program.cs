using System;
using System.Collections.Generic;

namespace _15.AssociativeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            phonebook["Jordan"] = "555112212";
            phonebook["George"] = "1234564789";
            phonebook["Peter"] = "98745612";
            phonebook["Aleks"] = "98745613";
            Console.WriteLine(phonebook.Count); //give me the value of teh key named -> George
            Console.WriteLine(String.Join(',', phonebook.Keys)); //printes collection of keys
            Console.WriteLine(String.Join(',', phonebook.Values)); //printes a collection of values
            Console.WriteLine(String.Join(',', phonebook)); //printes the pairs :  Key->Value;
            // key-Value Entry -key-value record-> key value pair;

        }
    }
}
