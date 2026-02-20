using System;

namespace DemoWebCSharp.Utility
{
    //Simple     Class
    public class SimpleClass
    {
        public string message;


        public SimpleClass()//construcror without parameter
        {
            message = "This is a simple class (Constructor Called)";
        }
        public string Message()
        {
            return message;
        }
    }

    //Encapsulation
    public class EncapsulationExample
    {
        private string name;// data member

        
        public EncapsulationExample(string name)//Constructor one parameter
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    //Inheritance
    public class Parent
    {
        protected string parentMessage;

        // Constructor
        public Parent()
        {
            parentMessage = "Message from Parent (Constructor)";
        }
        
        public string ParentMessage()//Member function
        {
            return parentMessage;
        }
    }

    public class Child : Parent
    {
        public string childMessage;
        public Child()//constructor
        {
            childMessage = "Message from Child (Constructor)";
        }

        public string ChildMessage()
        {
            return parentMessage +"+" +childMessage;
        }
    }
    public class Animal
    {
        public Animal()
        {
        }

        public virtual string Speak()
        {
            return "Animal Sound";
        }
    }

    public class Dog : Animal
    {
        // Constructor
        public Dog()
        {
        }

        public override string Speak()
        {
            return "Dog Barking";
        }
    }
    //Overloading
    public class Calculator
    {
        public Calculator()
        {
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}

