using System;

namespace _01._11._2021_task2.Model
{
    public class LandVehicle :Vehicle
    {
        public string km;

        public LandVehicle(string type, int speed, string model, string km) : base(type, speed, model)
        {
            this.km = km;
        }
    }
}