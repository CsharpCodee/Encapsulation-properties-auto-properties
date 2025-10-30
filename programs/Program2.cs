using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11._2
{
    class Phone
    {
        private int battery;
        public int BatteryLevel
        {
            get { return battery; }
            set
            {
                if (value >= 0 && battery <= 100) 
                { battery = value; }
                else { battery = 0; 
                    Console.WriteLine("Заряд не может быть за пределами (0-100)!"); }
            }
        }
        public string Brand {get; init; }
        public Phone(int batteryLevel, string brand)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }
        public void Use()
        {
            if (battery >= 10)
            {
                battery -= 10;
                Console.WriteLine($"{Brand}: заряд [{BatteryLevel}]%.");
            }
            else
            {
                Console.WriteLine($"{Brand}: недостаточно заряда для использования.");
            }
        }
        static void Main(string[] args)
        {
            Phone phone1 = new Phone(46, "Iphone");
            phone1.Use();
            phone1.Use();
            phone1.Use();
            Phone phone2 = new Phone(150, "Samsung");
            phone2.Use();
            Phone phone3 = new Phone(-10, "Tesla");
            phone3.Use();
        }
    }
}