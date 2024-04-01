using System;
using System.Runtime.CompilerServices;
using Multiple_class_and_object;
using  Class_members;

namespace singleclass
{
  
    
public class Car
  {
   public  Car(string carname,string color, int maxspeed){
      this.carname = carname;
  this.color=color;
  this.maxspeed=maxspeed;
    }
   
   
  //  public Car()
  //  {
  //  }
    
    public string carname=null;
    
    public string color= null;
    public int maxspeed=0;
    public void display(){
       {
            Console.WriteLine(this.carname  +"  "+this.color + "   " +this.maxspeed);
         }
    }
    public static void Main(string[] args)
    {
      
      
    //  Car myObj = new Car();
    //  Console.WriteLine(myObj.color);
     Brands.Brand();
     Memberofclass.Mclass();
     

    }
   }
}
