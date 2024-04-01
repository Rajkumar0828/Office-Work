using System;
using System.Xml.Serialization;
using Class_members;
using singleclass;

namespace Multiple_class_and_object
{
class Brands
{
    public static void Brand()
    {
         string B1 = "Benz";
         string B2 = "Audi";
         string b3 = "Ford Mustang";
         string b4 ="swift";

      // Car   varmod1 = new Car();
    //   Car    varmod2 = new Car();
         Car  varmod3 = new   Car(b3,"red",220);
         Car varmod4 = new Car(B2,"white",150);
         Car varmod5 = new Car (B1, "Black",200);

         varmod5.display();
         varmod4.display();
         varmod3.display();
        

    }
}


}