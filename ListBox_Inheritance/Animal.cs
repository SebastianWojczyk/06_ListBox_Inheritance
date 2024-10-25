using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox_Inheritance
{
    abstract public class Animal 
    {
        private String name;
        public String Name
        { get { return name; } }
        public Animal(String name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"{name} ({Sound})";
        }
        abstract public String Sound
        {
            get;
        }
    }

    public class Dog : Animal
    {
        public Dog(String name) : base(name)
        {
        }
        public override String Sound
        { 
            get { return "bark"; }
        }
    }

    public class Cat : Animal
    {
        public Cat(String name) : base(name)
        {
        }
        public override String Sound
        {
            get { return "meow"; }
        }
    }


}
