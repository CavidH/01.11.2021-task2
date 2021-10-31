namespace _01._11._2021_task2.Model
{
    public class AirWecihle :Vehicle
    {
        public int Wings;

        public AirWecihle(string type, int speed, string model, int wings) : base(type, speed, model)
        {
            Wings = wings;
        }
    }
}