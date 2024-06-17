using System;

namespace AnimalSounds
{
    // Base class
    class Animal
    {
        // Virtual method
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        // Overriding the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        // Overriding the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Animal
            Animal genericAnimal = new Animal();
            genericAnimal.MakeSound(); // Output: Some generic sound

            // Create an instance of Dog
            Dog dog = new Dog();
            dog.MakeSound(); // Output: Bark

            // Create an instance of Cat
            Cat cat = new Cat();
            cat.MakeSound(); // Output: Meow

            // Pause the console
            Console.ReadLine();
        }
    }
}
