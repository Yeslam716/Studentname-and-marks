using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp18
{


    class Progrm
    {

        static void Main(string[] args)
        {
            Courseresult s = new Courseresult();
            Console.WriteLine("Enter studentName:");
            s.Studentname = Console.ReadLine();
            
            Console.WriteLine("enter Marks:");

            s.mark = int.Parse
                (Console.ReadLine());


            Console.WriteLine($"The Name: {s.Studentname}");
            Console.Write("Final result= ");
            Console.WriteLine(s.Grade);
               
            
        }

    }
}