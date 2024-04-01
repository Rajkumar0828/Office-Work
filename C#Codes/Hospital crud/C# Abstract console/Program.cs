using System;
namespace Assignment3;
abstract class Rules{
    public abstract void Qualification();
    public void Eligibility(){
        Console.WriteLine("Enter the 12th mark cutoff :");
        int cutoff=Convert.ToInt32(Console.ReadLine());        
        if(cutoff<150 ){
            Console.WriteLine("Not Eligible for Higher Education:");
        }   
        }

    
    


}
class UGAdmission : Rules
{
    string? Ans;
    public override void Qualification(){
        Console.WriteLine("Welcome to UG Admission");
        Console.WriteLine("Enter Whether you have completed 12th Standard \n whether you have completed polytechnic  :");
         Ans=Console.ReadLine()?.ToUpper();
        if(Ans!="YES I HAVE COMPLETED 12TH STANDARD" || Ans!="YES I HAVE COMPLETED POLYTECHNIC"){
            Console.WriteLine("You need to complete 12th OR Polytechnic course to study Higher education");
        
        
    }else{
            Console.WriteLine("You are eligible for BE/BTech");
        }

    }
}
class PGAdmission : Rules
{

    string? Ans;
     string? Gate;

    
    public override void Qualification(){

       Console.WriteLine("Welcome to PG Admission");
        Console.WriteLine("Enter the degree you are completed :");
         Gate=Console.ReadLine();
         if(Gate!="BE"|| Gate!="BTech"){
            Console.WriteLine("You are not eligible for Gate Score");
            Console.WriteLine("You are not eligible for ME/MTech");
         }else{
            Console.WriteLine("Tell wheather you have Gate score: Yes or NO :");
        Ans=Console.ReadLine()?.ToUpper();
         if(Ans=="NO" ){
            Console.WriteLine("You are eleigible for ME/M TECH.You have no scholarship for PG Course");
            }
            else if(Ans=="YES" )
            {


                Console.WriteLine("Enter the Gatecutoff mark cutoff :");
               int Gatecutoff=Convert.ToInt32(Console.ReadLine());
               if(Gate=="BE"||Gate=="BTech" && Gatecutoff<32)
               {
                Console.WriteLine(" You are eleigible for ME/M TECH. you have scholarship for your PG course");


               }


            }
               else{
             Console.WriteLine("You have not eligible for scholarship");

                }
         }

        
    }
    

       
            }

         

         
         
        
       
      

public class Program{
    public static void Main(string[] args){
        UGAdmission ug=new UGAdmission();
        ug.Eligibility();
        ug.Qualification();
       PGAdmission pg=new PGAdmission();
       pg.Eligibility();
       pg.Qualification();
    }
}
