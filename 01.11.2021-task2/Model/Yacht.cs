using System;

namespace _01._11._2021_task2.Model
{
    public class Yacht :WaterVecihle
    {
        public string YachtType;
        public int Storey;

        public Yacht(string type, int speed, string model, string energytype, string yachtType, int storey) : base(type, speed, model, energytype)
        {
            YachtType = yachtType;
            Storey = storey;
        }

        public override void run()
        {
            Console.WriteLine("car ia runned");
        }
    }
}