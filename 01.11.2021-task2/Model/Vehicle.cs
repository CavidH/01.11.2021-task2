namespace _01._11._2021_task2.Model
{
    public class Vehicle
    {
        public Vehicle(string type, int speed, string model)
        {
            this.type = type;
            this.speed = speed;
            this.model = model;
        }

        public string type;
        public int speed;
        public string model;
        public virtual void run()
        {
            
        }
    }
}