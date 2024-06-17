using System;

namespace MovableObjects
{
    // Define the interface
    interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    class Car : IMovable
    {
        // Implement the Move method
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    class Bicycle : IMovable
    {
        // Implement the Move method
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Car
            Car car = new Car();
            car.Move(); // Output: Car is moving

            // Create an instance of Bicycle
            Bicycle bicycle = new Bicycle();
            bicycle.Move(); // Output: Bicycle is moving

            // Pause the console
            Console.ReadLine();
        }
    }
}
