using System;
using System.Collections.Generic;
using System.Text;

namespace Djur
{
    public class Dog : Animals
    {
        public int _power;

        //Subconstructor
        public Dog(int Age, string Name, string Color, string Species, string Speed, int power)
            : base(Age, Name, Color, Species, Speed)
        {
            _age = Age;
            _name = Name;
            _color = Color;
            _species = Species;
            _speed = Speed;
            _power = power;
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
            Console.WriteLine("Power : " + _power);
        }

        public override void MakeSound()
        {
            Console.WriteLine("The dog says VOFF!");
        }
        

        
    }
    
}
