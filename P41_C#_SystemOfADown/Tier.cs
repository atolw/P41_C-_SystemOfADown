using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41_C__SystemOfADown
{
    internal class Tier
    {
        public string Name { get; set; }
        public int Age { get; set; }

       
        public Tier(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
    
    class Tiger : Tier
    {
        public Tiger(string name, int age) : base(name, age)
        {
        }

        override public void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    }

    class Crocodile : Tier
    {
        public Crocodile(string name, int age) : base(name, age)
        {
        }

        override public void MakeSound()
        {
            Console.WriteLine("Growl");
        }
    }

    class Kangaroo : Tier
    {
        public Kangaroo(string name, int age) : base(name, age)
        {
        }

        override public void MakeSound()
        {
            Console.WriteLine("Chortle");
        }
    }
}
