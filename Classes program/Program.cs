using System;

 namespace CarApplication
 {
    class Speed
    {
       public  int maxSpeed;

        public  Speed(int max)
        {
            maxSpeed=max;
        }
    }
 

class Car 
{
    public string Model;
    public string color;
    public Car(string ModelName, string Modelcolor)
    {
        Model = ModelName;
        color = Modelcolor;
     }
}

class Program{

    public static void Main(string[] args)
    {
        Car Ford = new Car("ford","Red");
        Speed speed= new Speed(200);

        Console.WriteLine(Ford.Model +"  "+ Ford.color +"  "+ speed.maxSpeed);
    }
}
}