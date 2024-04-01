using System;

namespace Carapp
{
    class Speed
    {
        public int speeding
        {
           get; set; 
        }

    }
    class Car
    {
        
        public string color { get; set; }
        public string model { get; set; }
        
    }

    class Program : Car
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.model = "Audi";
            car.color = "Red";

        Speed speed= new Speed();
            speed.speeding = 250;

        Console.WriteLine(car.model +" "+ car.color +"  "+ speed.speeding);
        }
    }
}
