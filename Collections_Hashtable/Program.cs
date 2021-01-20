using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_Hashtable
{
    class Program
    {
        static void display(Hashtable hash)
        {
            foreach (DictionaryEntry i in hash)
            {
                Console.WriteLine($"The Key is: {i.Key} and Value is: {i.Value}");
            }

        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300 };
            string[] city = { "lahore", "karachi", "pindi" };

            var myDictionary1 = new Dictionary<int, string>();

            myDictionary1.Add(2, "wamik");
            myDictionary1.Add(4, "afaq");
            myDictionary1.Add(5, "umair");
            myDictionary1.Add(3, "askari");
            myDictionary1.Add(1, "ihtisham");
            myDictionary1.Add(7, "ihtisham");

            var myHashtable1 = new Hashtable(myDictionary1);

            myHashtable1.Add("p", "wamik");
            myHashtable1.Add("h", "afaq");
            myHashtable1.Add("z", "umair");
            myHashtable1.Add("x", "askari");
            myHashtable1.Add("y", "ihtisham");
            myHashtable1.Add("a", "ihtisham");

            var myHashtable2 = new Hashtable()
            {
                { 500, "Hunza" }, { 600, "Naran" }
            };

            for (int i = 0; i < 3; i++)
            {
                myHashtable2.Add(arr[i], city[i]);
            }


            Console.WriteLine("--------------------------------------------------First iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myHashtable1);
            Console.WriteLine("Displaying Cities");
            display(myHashtable2);

            var city1 = (string) myHashtable2[600];
            Console.WriteLine(city1);

            myHashtable1.Remove("z");
            myHashtable1.Remove(4);
            myHashtable2.Remove(200);

            Console.WriteLine("--------------------------------------------------Second iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myHashtable1);
            Console.WriteLine("Displaying Cities");
            display(myHashtable2);

            Console.WriteLine(myHashtable1.ContainsValue("wamik"));

            if (myHashtable1.ContainsKey("y"))
            {
                myHashtable1["y"] = "Ali";
            }

            if (myHashtable2.ContainsKey(300))
            {
                myHashtable2[300] = "Birminghim";
            }

            Console.WriteLine("--------------------------------------------------Third iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myHashtable1);
            Console.WriteLine("Displaying Cities");
            display(myHashtable2);
        }
    }
}
