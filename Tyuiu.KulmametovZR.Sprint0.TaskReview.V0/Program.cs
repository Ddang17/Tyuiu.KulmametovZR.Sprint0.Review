using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KulmametovZR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KulmametovZR.Sprint0.TaskReview.V0
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("y:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("z:");
            int z = int.Parse(Console.ReadLine());

           
            DataService dataService = new DataService();

          
            int result = dataService.Calc(x, y, z);

            
            Console.WriteLine($"Результат вычисления: {result}");

            
            
            Console.ReadKey();
        }
    }
}