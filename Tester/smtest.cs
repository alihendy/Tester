using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class smtest
    {
        const int basic = 125;
        static int allowedPoints = 125;
        static int totalPoints = 0;
        static int easyLoBound = 0, easyHiBound = 101;
        static int easyLoOp = 0, easyHiOp = 2, ValBound = 2, ValDev = 0;

        static int getNumValues()
        {
            Console.WriteLine("in getNumValues");
            int numVals = 2;
            

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

    }
}
