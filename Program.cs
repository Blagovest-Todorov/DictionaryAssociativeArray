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
            phonebook.Remove("George"); //@ We remove teh key-Value pair before we add it again!
            //  phonebook.Clear(); //clears all  content, result is defaut value 0
            phonebook.Add("George", "Hello");

            Console.WriteLine(phonebook.Count); //give me the value of teh key named -> George
            Console.WriteLine(String.Join(',', phonebook.Keys)); //printes collection of keys
            Console.WriteLine(String.Join(',', phonebook.Values)); //printes a collection of values
            Console.WriteLine(String.Join(',', phonebook)); //printes the pairs :  Key->Value;
                                                            // key-Value Entry -key-value record-> key value pair;

            // ContainsKey checks if we already have a key 

            //if (!phonebook.ContainsKey("George"))
            //{
            //    phonebook.Add("George", "+134566");   
            //}
            //Console.WriteLine(String.Join(',', phonebook));
            //Console.WriteLine(phonebook.ContainsKey("Jor")); //We look for a existing key with Contains.Key();
            //Console.WriteLine(phonebook["Jordan"]);

            if (!phonebook.ContainsValue("98745613"))  //checks if the value does not exist , then adds a value
            {
                Console.WriteLine("Key-Value added"); //executed this code 
            }


        }
    }
}
