using System;
using System.Collections.Generic;
using System.Text;

namespace Djur
{
    public class Chihuahua : Dog
    {

        public string _size;
        public Chihuahua(int Age,string Name, string Color, string species, string speed, int power, string size)
            : base(Age, Name, Color, species, speed, power)
        {
            _age = Age;
            _name = Name;
            _color = Color;
            _species = species;
            _speed = speed;
            _power = power;
            _size = size;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Dog");
            Console.WriteLine("Animal information");
            Console.WriteLine("Age : " + _age);
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Color : " + _color);
            Console.WriteLine("Species : " + _species);
            Console.WriteLine("Speed : " + _speed);
            Console.WriteLine("Size : " + _size);
        }
        public override void MakeSound()
        {
            Console.WriteLine("The Chihuahua says bowwow!");
        }
    }
}
