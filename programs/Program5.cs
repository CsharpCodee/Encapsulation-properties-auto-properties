using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic11._5
{
    class Product
    {
        private decimal price;
        private decimal discount;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                { price = value; }
                else
                {
                    Console.WriteLine("Цена не может быть отрицательной!");
                    price = 0;
                }
            }
        }
        public decimal Discount
        {
            get { return discount; }
            set
            {
                if (value >= 0 && value <= 100)
                { discount = value; }
                else
                {
                    Console.WriteLine("Скидка должна быть от 0 до 100!");
                    discount = 0;
                }
            }
        }
        public decimal FinalPrice => Price * (1 - Discount / 100);
        public string Name { get; set; } = "Без названия";
        public Product(int price, int discount)
        {
            Price = price;
            Discount = discount;
        }
        public void Show()
        {
            Console.WriteLine($"{Name}: {FinalPrice} (скидка {Discount}%)");
        }


        static void Main(string[] args)
        {
            Product product1 = new Product(100000, 20); 
            product1.Name = "Ноутбук";
            product1.Show(); 

            product1.Discount = 10; 
            product1.Show(); 

            Product product2 = new Product(-500, 15); 
            product2.Show(); 
        }
    }
}