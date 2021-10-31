using System;

namespace _01._11._2021_task2.Model
{
    public class Car :LandVehicle
    {
        public string EngineType;
        public override void run()
        {
            Console.WriteLine("car ia runned");
        }

        public Car(string type, int speed, string model, string km, string engineType) : base(type, speed, model, km)
        {
            EngineType = engineType;
        }
    }
}