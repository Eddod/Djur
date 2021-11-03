using System;

namespace Djur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Dog dog1 = new Dog (10,"Edwin ","Brown ","Rottweiler ","50km/h ",10);
            Bird bird = new Bird(10, "Bernard ", "Blue ", "Eagle ", "300km/h ", "Can fly ");
            Fish fish = new Fish(10, "Konrad ", "Golden ", "Guldfisk ", "100km/h ", "Can swim ");
            Dolphin dolphin = new Dolphin(10, "Tobias ", "Blue ", "Späckhuggare ", "60km/h ", "Can swim ", 30);
            Chihuahua dog2 = new Chihuahua(5, "Kalle ", "Brown ", "Chihuahua ", "3km/h ", 2, "Small ");

            dog1.PrintInfo();
            dog1.MakeSound();
            dog1.Moving();
            Console.WriteLine("-----------------------------");
            bird.PrintInfo();
            bird.MakeSound();
            bird.Moving();
            Console.WriteLine("-----------------------------");
            fish.PrintInfo();
            fish.MakeSound();
            fish.Eat();
            Console.WriteLine("-----------------------------");
            dolphin.PrintInfo();
            dolphin.MakeSound();
            dolphin.Sleep();
            Console.WriteLine("-----------------------------");
            dog2.PrintInfo();
            dog2.MakeSound();
            dog2.Moving();
            Console.ReadLine();
            Console.Beep();

            
        }
    }
}
