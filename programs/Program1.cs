using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11._1
{
    class Car
    {
        string model;
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0 && value <= 300) 
                { speed = value; }
                else
                {
                    speed = 0;
                    if (value > 300) 
                    { Console.WriteLine($"Скорость не может превышать 300!"); }
                    else if (value < 0) { Console.WriteLine($"Скорость не может быть ниже 0!"); }
                }
            }
        }
        public string Model { get; set; } = "Unknown"; 
        public Car(int speed, string model)
        {
            Speed = speed;
            Model = model;
        }
        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
        }

        static void Main(string[] args)
        {
            Car car1 = new Car(300, "BMW");
            car1.Drive();

            Car car2 = new Car(400, "Renault");
            car2.Drive();

            Car car3 = new Car(-50, "Volswagen");
            car3.Drive();
        }
    }
}
