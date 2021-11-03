using System;
using System.Collections.Generic;
using System.Text;

namespace Djur
{
    class Dolphin : Fish
    {
        public int _intellect;
        public Dolphin(int Age, string Name, string Color, string species, string speed, string Swim, int Intellect)
            : base(Age, Name, Color, species, speed, Swim)
        {
            _age = Age;
            _name = Name;
            _color = Color;
            _species = species;
            _speed = speed;
            _intellect = Intellect;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Fish");
            Console.WriteLine("Animal information");
            Console.WriteLine("Age : " + _age);
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Color : " + _color);
            Console.WriteLine("Species : " + _species);
            Console.WriteLine("Speed : " + _speed);
            Console.WriteLine("Swim : " + _swim);
            Console.WriteLine("Intellect : " + _intellect);
        }
        public override void MakeSound()
        {
            Console.WriteLine("The dolphin says CLICKCLICK!");
        }
    }
}
