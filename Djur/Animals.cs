using System;
using System.Collections.Generic;
using System.Text;

namespace Djur
{
    public class Animals
    {
        public int _age;
        public string _name;
        public string _species;
        public string _color;
        public string _speed;

        //Baseconstructor
        public Animals(int Age, string Name, string Species, string Color, string Speed)
        {
            _age = Age;
            _name = Name;
            _species = Species;
            _color = Color;
            _speed = Speed;
        }     
        public void Sleep()

        {
            Console.WriteLine(_name + " is sleeping");
        }
        public void Moving()
        {
            Console.WriteLine("The " + _species + _name + " is moving in the speed of " + _speed);
        }
        public void Eat()
        {
            Console.WriteLine("The " + _color + _species + _name + " is eating");
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Animal information : {0}", _age, _name, _color, _species, _speed);
        }
        public virtual void MakeSound()
        {

        }


    }

}
