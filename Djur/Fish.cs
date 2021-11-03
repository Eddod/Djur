using System;
using System.Collections.Generic;
using System.Text;

namespace Djur
{
    public class Fish : Animals
    {
        public string _swim;

        //Subconstructor
        public Fish(int Age, string Name, string Color, string Species, string Speed, string Swim)
            : base(Age, Name, Color, Species, Speed)
        {
            _age = Age;
            _name = Name;
            _color = Color;
            _species = Species;
            _speed = Speed;
            _swim = Swim;

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
        }
        public override void MakeSound()
        {
            Console.WriteLine("The fish goes BLUBB!");
        }
        
    }

}
