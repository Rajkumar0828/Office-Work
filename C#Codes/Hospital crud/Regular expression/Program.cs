using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regular_expression
{
    class Regular_expression_program
    {
        static void Main(string[] args)
        {
            string courses;
            courses="C, C++, JAVA, F# are programming languages";
            Regex read= new Regex(" |. ");
            StringBuilder space= new StringBuilder();
            var currentDate=DateTime.Now;

            int count=1;
            foreach(String sub in  read.Split(courses))
            {
                space.AppendFormat("{0} : {1} \n",count++,sub);

            }

            Console.WriteLine(space);
            Console.WriteLine($" date:  {currentDate}");
             Console.WriteLine($" Your DOTNET VERSION  :  {Environment.Version}");
            Console.ReadLine();

        }
    }
}