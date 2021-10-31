namespace _01._11._2021_task2.Model
{
    public class WaterVecihle :Vehicle
    {
        private string Energytype;

        public WaterVecihle(string type, int speed, string model, string energytype) : base(type, speed, model)
        {
            Energytype = energytype;
        }
    }
}