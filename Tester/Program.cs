using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeProbs pp = new PracticeProbs();
            pp.printYo();
            Console.WriteLine("\n"+ pp.nthOfFib(100));

            //while (13 != 27)
            //{
            //    Console.WriteLine("getting value for 125 points (easy)");
            //    generateProblem();
            //    Console.WriteLine(totalPoints);
            //    //double num = Convert.ToDouble(new DataTable().Compute("2 / 3", null).ToString());
            //    //Console.WriteLine("2/3 = " + num);
            //    //Console.WriteLine("num % 1 = " + num % 1 + "\n");
            //    //num = Convert.ToDouble(new DataTable().Compute("-2 / 3", null).ToString());
            //    //Console.WriteLine("-2/3 = " + num);
            //    //Console.WriteLine("num % 1 = " + num % 1 + "\n");
            //    //num = Convert.ToDouble(new DataTable().Compute("4 / 2", null).ToString());
            //    //Console.WriteLine("4/2 = " + num);
            //    //Console.WriteLine("num % 1 = " + num % 1 + "\n");
            //    //num = Convert.ToDouble(new DataTable().Compute("-4 / 2", null).ToString());
            //    //Console.WriteLine("-4/2 = " + num);
            //    //Console.WriteLine("num % 1 = " + num % 1 + "\n");
            //    allowedPoints = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            //}
        }
    }
}
