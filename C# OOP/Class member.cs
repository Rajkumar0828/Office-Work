using System;
using System.Xml;
using singleclass;
using Multiple_class_and_object;
namespace Class_members;

class  Memberofclass
{
    public static void Mclass()
    {  
        string brand4 ="swift";
        string brand5 ="Rolls Royce";
        string color ="red";
      int maxspeed =200;

      Car varmod6 = new Car(brand4,"Green",maxspeed);
      Car varmod7 = new Car(brand5,"White",maxspeed);
      Console.WriteLine(" The car is going as fast!!");

      varmod6.display();
      varmod7.display();

    }
}