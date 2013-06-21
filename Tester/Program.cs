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
        const int basic = 125;
        static int allowedPoints = 125;
        static int totalPoints = 0;
        static int easyLoBound = 0, easyHiBound = 101;
        static int easyLoOp = 0, easyHiOp = 2, ValBound = 2, ValDev = 0;

        static int getNumValues()
        {
            Console.WriteLine("in getNumValues");
            int points=0;
            int numVals=2;
            int jews = (allowedPoints / 10) / 3;
            int hiBound = jews <= 2 ? jews + 3 : jews;
            numVals = new Random().Next(2, hiBound);
            points = 10 * numVals;
            //switch (numVals)
            //{
            //    case 2: points = 5;
            //        break;
            //    case 3: points = 10;
            //        break;
            //    case 4: points = 15;
            //        break;
            //    case 5: points = 25;
            //        break;
            //    case 6: points = 35;
            //        break;
            //    case 7: points = 45;
            //        break;
            //    case 8: points = 60;
            //        break;
            //    case 9: points = 75;
            //        break;
            //    case 10: points = 90;
            //        break;
            //    case 11: points = 105;
            //        break;
            //    case 12: points = 120;
            //        break;
            //    case 13: points = 150;
            //        break;
            //}
            totalPoints += points;
            allowedPoints -= points;
            return numVals;
        }

        static char[] getOperators(int numVals)
        {
            Console.WriteLine("in getOps");
            int numOps = numVals - 1;
            char[] ops = new char[numOps];
            int opPoints = 0;
            int totalOpPoints = 0;
            int rando = 0;
            char op = '+';
            for (int i = 0; i < numOps; i++)
            {
                rando = new Random().Next(0,allowedPoints/4+1);
                switch (rando%4)
                {
                    case 0: op = '+'; break;
                    case 1: op = '-'; break;
                    case 2: op = '*'; break;
                    case 3: op = '/'; break;
                }
                totalOpPoints += (rando+1)*10;
                allowedPoints -= (rando+1)*10;
                ops[i] = op;
            }
            totalPoints += totalOpPoints;
            
            return ops;
        }

        static int[] getValue(int numVals)
        {
            Console.WriteLine("in getValue");
            Console.WriteLine(numVals);
            int[] vals = new int[numVals];
            int totalValuePoints = 0;
            int valuePoints = 0;
            int hiBound, loBound;
            int value = new Random().Next(0, (allowedPoints/numVals)+1);
            for (int i = 0; i < numVals; i++)
            {
                value = new Random().Next(0, allowedPoints/numVals);
                valuePoints = value;
                //Console.WriteLine(value);
                
                totalValuePoints += valuePoints;
                allowedPoints -= valuePoints;
                vals[i] = value;
            }
            //Console.WriteLine("points = " + totalPoints);
            //Console.WriteLine("valuepoints = " + totalValuePoints);
            //Console.WriteLine("points - valuePoints = " + (totalPoints - totalValuePoints));
            //Console.WriteLine("points*.30 = " + (totalPoints * .30));
            totalPoints += totalValuePoints;
            return vals;
        }

        static void generateProblem()
        {
            int numVals = getNumValues();
            int[] values = getValue(numVals);
            char[] ops = getOperators(numVals);
            while (totalPoints >= basic + 50 || totalPoints <= basic-50)
            {
                totalPoints = 0;
                numVals = getNumValues();
                values = getValue(numVals);
                ops = getOperators(numVals);
            }
            Console.Write(values[0]);
            for (int i = 0; i < ops.Length; i++)
            {
                Console.Write(" " + ops[i] + " " + values[i + 1]);
            }
            Console.WriteLine();

        }



        static void Main(string[] args)
        {

            while (13 != 27)
            {
                Console.WriteLine("getting value for 125 points (easy)");
                generateProblem();
                Console.WriteLine(totalPoints);
                //double num = Convert.ToDouble(new DataTable().Compute("2 / 3", null).ToString());
                //Console.WriteLine("2/3 = " + num);
                //Console.WriteLine("num % 1 = " + num % 1 + "\n");
                //num = Convert.ToDouble(new DataTable().Compute("-2 / 3", null).ToString());
                //Console.WriteLine("-2/3 = " + num);
                //Console.WriteLine("num % 1 = " + num % 1 + "\n");
                //num = Convert.ToDouble(new DataTable().Compute("4 / 2", null).ToString());
                //Console.WriteLine("4/2 = " + num);
                //Console.WriteLine("num % 1 = " + num % 1 + "\n");
                //num = Convert.ToDouble(new DataTable().Compute("-4 / 2", null).ToString());
                //Console.WriteLine("-4/2 = " + num);
                //Console.WriteLine("num % 1 = " + num % 1 + "\n");
                allowedPoints = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            }
        }
    }
}
