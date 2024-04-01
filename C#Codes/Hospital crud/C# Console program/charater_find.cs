using System;
namespace Character_Find;

class Character{
    public static void Character_Find (){
        Console.WriteLine("Enter a character");
char letter=Convert.ToChar(Console.ReadLine());

if(letter=='A'||letter=='E'||letter=='I'||letter=='O'||letter=='U'){
        Console.WriteLine("It is a Uppercase vowel");
}

else if(letter=='a'||letter=='e'||letter=='i'||letter=='o'||letter=='u'){
        Console.WriteLine("It is a lowercase vowel");
    }


else if(letter >= '0' && letter <= '9'){

        Console.WriteLine("It is a digit");
    

}
else {

        Console.WriteLine("It is another symbol");
    

}


    }
}