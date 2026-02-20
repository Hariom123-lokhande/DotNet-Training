using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace DemoWebCSharp.Utility
{
    public class CollectionDemo
    {
        string[] arr = { "Rajesh", "Amit", "Sneha" }; // array with fixed size

        ArrayList arrayList = new ArrayList() // dynamic size
        {
            "Apple", "Banana", "Mango"
        };

        List<string> list = new List<string>() // list-type safe collection
        {
            "Rahul", "Kiran", "Anjali"
        };

        // dictionary (key and value)
        Dictionary<int, string> dict = new Dictionary<int, string>()
        {
            {1, "Employee A"},
            {2, "Employee B"},
            {3, "Employee C"}
        };

//constructor

        //Default Constructor
        public CollectionDemo()
        {
            //it will called automatically when object is AdCreatedEventArgs;
        }

        // Parameterized Constructor
        public CollectionDemo(string message)
        {
            Console.WriteLine("Parameterized Constructor Called: " + message);
        }

        // Copy Constructor
        public CollectionDemo(CollectionDemo obj)
        {
            Console.WriteLine("Copy Constructor Called");
        }

        //Static Constructor
        static CollectionDemo()
        {
            Console.WriteLine("Static Constructor Called");
        }

        //Private Constructor
        private CollectionDemo(int x)
        {
            Console.WriteLine("Private Constructor Called");
        }

        


        //destructor
        ~CollectionDemo()
        {
            Console.WriteLine("Destructor Called");
        }

        //COLLECTION

        public string GetArrayValue(int index)
        {
            if (index >= 0 && index < arr.Length)
                return arr[index];
            else
                return "Invalid Index";
        }
        public string GetArrayListValue(int index)
        {
            if (index >= 0 && index < arrayList.Count)
                return arrayList[index].ToString();
            else
                return "Invalid Index";
        }

        public string GetListValue(int index)
        {
            if (index >= 0 && index < list.Count)
                return list[index];
            else
                return "Invalid Index";
        }

        public string GetDictionaryValue(int key)
        {
            if (dict.ContainsKey(key))
                return dict[key];
            else
                return "Key Not Found";
        }
    }
}