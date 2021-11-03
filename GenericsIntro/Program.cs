using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "1");

            //MyList<string> myList = new MyList<string>();
            //myList.Add("Engin");
            //Console.WriteLine(myList.Length);

            //myList.Add("Kerem");
            //Console.WriteLine(myList.Length);

            //foreach (var item in myList.Items)
            //{
            //    Console.WriteLine(item);
            //}

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "1");
            Console.WriteLine(myDictionary.Length);

            myDictionary.Add(2, "2");
            Console.WriteLine(myDictionary.Length);


            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine(myDictionary.Keys[i] + " " + myDictionary.Values[i]);
            }

            
        }
    }
}
