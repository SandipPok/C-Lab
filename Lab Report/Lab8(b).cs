using System;
namespace Lab_Report
{
    interface IAnimal
    {
        void animalSound();
    }
    class Dog : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: Hello World");
        }
    }
    class Iface
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.animalSound();
            Console.WriteLine("Lab8(b)\tName:Sandip Pokharel\tRoll No.:20900");
        }
    }
}
