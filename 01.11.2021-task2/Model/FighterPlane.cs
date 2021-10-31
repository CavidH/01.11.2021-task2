namespace _01._11._2021_task2.Model
{
    public class FighterPlane:AirWecihle
    {
        public string RocketType;
        public int RocketQuantity;

        public FighterPlane(string type, int speed, string model, int wings, string rocketType, int rocketQuantity) : base(type, speed, model, wings)
        {
            RocketType = rocketType;
            RocketQuantity = rocketQuantity;
        }
    }
}