using System;
using System.Collections.Generic;
using System.Text;

namespace Djur
{
    public class Bird : Animals
    {
        public string _fly;

        //Subconstructor
        public Bird(int Age, string Name, string Color, string Species, string Speed, string Fly)
            : base(Age, Name, Color, Species, Speed)
        {
            _age = Age;
            _name = Name;
            _color = Color;
            _species = Species;
            _speed = Speed;
            _fly = Fly;

        }
        public override void PrintInfo()
        {
            Console.WriteLine("Bird");
            Console.WriteLine("Animal information");
            Console.WriteLine("Age : " + _age);
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Color : " + _color);
            Console.WriteLine("Species : " + _species);  
            Console.WriteLine("Speed : " + _speed);
            Console.WriteLine("Flight : " + _fly);
        }
        public override void MakeSound()
        {
            Console.WriteLine("The bird says PIP!");
        }

    }
}
