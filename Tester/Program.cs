using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Extensions;


namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeProbs pp = new PracticeProbs();
            String jerk = "POOP";
            jerk.derp();
            pp.printYo();
            Console.WriteLine("\n" + pp.nthOfFib(20));
            for (int i = 0; i < 1; i++)
            {
                //if (i < 20)
                //    smtest.diff = "EASY";
                //else if (i >= 20 && i < 40)
                //    smtest.diff = "MED";
                //else if (i >= 40 && i < 60)
                //    smtest.diff = "HARD";
                //else if (i >= 60 && i < 80)
                //    smtest.diff = "VHARD";
                //else
                    smtest.diff = "IMP";

                smtest.generateProblem();

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
                //Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
