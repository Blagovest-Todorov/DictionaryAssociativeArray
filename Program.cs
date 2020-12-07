using System;
using System.Collections.Generic;

namespace _14.AssociativeArrayMapHashTableDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray =  new int[5];
            integerArray[4] = 15;
            integerArray[1] = 6;
            integerArray[0] = 12;


            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            // We create  a new dictionarym new object
            // on dictionaries we have assosiation, key - > associated with a value; 
            //the value is associated woth key -> we specify the ytpe of teh key, the type of teh value
            phonebook["Jonh Dow"] = "0034567887"; // We initialize the dictionary 
            phonebook["John Dow"] = "12425"; // this will override the previus number //we add new telefone value
            //the associative arrays are key-value pairs
            //the normal arrays automatically make the indexing, when resizing /they dont store index, 
            // normal arrays store only values, they dotn store key-value pairs !

           // associative arrays are more flexible , we choose the type of key; string, int, double, ..

            //dictunary has a property Count !
        }
    }
}
