using System;
using singleclass;
namespace Same_Class;
class College
{
string? category; // by default it is private
 private string? location;

 public void getCollegeDetails(string collCat, string collLoc)
 { 
category = collCat;
location = collLoc; 
}
 public string showCollegeDetails()
 {
return category +" college is located in " + location;
 } }
 class Program{
public void Print_1()
{
College mycoll1 = new College();
 mycoll1.getCollegeDetails("University college of engineering","Ariyalur"); 
Console.WriteLine(mycoll1.showCollegeDetails());
}
}