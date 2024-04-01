using System;
namespace Circle_radius;
class Circle
{
    public static void Circle_radius(){
        Console.WriteLine("Enter the radius of the circle : ");
      double r = Convert.ToInt32(Console.ReadLine());
      double pi=3.14;
      double perimeter=2*pi*r;
        Console.WriteLine("Perimeter of Circle : "+perimeter);

    }

}
