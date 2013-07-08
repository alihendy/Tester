using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tester
{
    public class smtest
    {
        public static int totalPoints = 0;
        public static int allowedPoints;
        public static int basic;
        public static char[] ops;
        public static string diff = "EASY";

        public static int getNumValues()
        {
            Console.WriteLine("in getNumValues");
            int numVals = 2;
            int numValPoints = basic / 5; //not to exceed 20% of the total difficulty
            int maxNumVals = (numValPoints / 10 + 1) < numVals ? numVals + 2 : (numValPoints / 10 + 1);
            numVals = new Random().Next(numVals, maxNumVals);
            int points = numVals * 5;
            allowedPoints -= points;
            Console.WriteLine("numval points = " + points);
            return numVals;
        }

        public static char[] getOperators(int numVals)
        {
            Console.WriteLine("in getOps");
            int numOps = numVals - 1;
            ops = new char[numOps];
            int opPoints = 0;
            int maxAllowedOpPoints = basic / 5;
            int rando = 0;
            char op = '+';
            for (int i = 0; i < numOps; i++)
            {
                rando = new Random().Next(0,maxAllowedOpPoints);
                op = (rando < 20) ? '+' : (rando < 40) ? '-' : (rando < 80) ? '*' : '/';
                if (rando < 20)
                {
                    op = '+';
                }
                else if (rando >= 20 && rando < 40)
                {
                    op = '-';
                }
                else if (rando >= 40 && rando < 80)
                {
                    op = '*';
                }
                else
                {
                    op = '/';
                }
                opPoints += rando;
                maxAllowedOpPoints -= rando / 2;
                //switch (rando%4)
                //{
                //    case 0: op = '+'; break;
                //    case 1: op = '-'; break;
                //    case 2: op = '*'; break;
                //    case 3: op = '/'; break;
                //}
                ops[i] = op;
                Thread.Sleep(100);
            }
            allowedPoints -= opPoints;
            Console.WriteLine("oppoints = " + opPoints);
            
            return ops;
        }

        public static int[] getValue(int numVals)
        {
            Console.WriteLine("in getValue");
            Console.WriteLine(numVals);
            int maxAllowedPoints = (basic / 5);
            int maxAllowedValue;
            int totalValuePoints = 0;

            if (maxAllowedPoints <= 25)
                maxAllowedValue = 26;
            else if (maxAllowedPoints > 25 && maxAllowedPoints <= 35)
                maxAllowedValue = 51;
            else if (maxAllowedPoints > 35 && maxAllowedPoints <= 55)
                maxAllowedValue = 76;
            else if (maxAllowedPoints > 55 && maxAllowedPoints <= 75)
                maxAllowedValue = 101;
            else
                maxAllowedValue = 126;

            int[] vals = new int[numVals];
            int value;
            for (int i = 0; i < numVals; i++)
            {
                if (i < ops.Length && ops[i] == '/')
                {
                    int divisor = new Random().Next(2, maxAllowedValue / 10);
                    Thread.Sleep(50);
                    int tempQuot = new Random().Next(2, maxAllowedValue / 10);
                    int dividend = divisor * tempQuot;
                    vals[i] = dividend;
                    vals[++i] = divisor;
                    totalValuePoints += Math.Abs(dividend / 10);
                    totalValuePoints += Math.Abs(divisor / 10);
                    maxAllowedValue -= Math.Abs(dividend / 10);
                    maxAllowedValue -= Math.Abs(divisor / 10);
                }
                else if ((i < ops.Length && ops[i] == '*') || (i > 0 && ops[i-1] == '*'))
                {
                    int multiplicand = new Random().Next(2, maxAllowedValue / 8);
                    Thread.Sleep(50);
                    int multiplier = new Random().Next(2, maxAllowedValue / 8);
                    vals[i] = multiplicand;
                    vals[++i] = multiplier;
                    totalValuePoints += Math.Abs(multiplicand / 10);
                    totalValuePoints += Math.Abs(multiplier / 10);
                    maxAllowedValue -= Math.Abs(multiplicand / 10);
                    maxAllowedValue -= Math.Abs(multiplier / 10);
                }
                else
                {
                    value = new Random().Next(0, maxAllowedValue);
                    //Console.WriteLine(value);
                    totalValuePoints += Math.Abs(value / 10);
                    vals[i] = value;
                    maxAllowedValue -= Math.Abs(value / 10);
                }
                
                Thread.Sleep(100);
            }
            //Console.WriteLine("points = " + totalPoints);
            //Console.WriteLine("valuepoints = " + totalValuePoints);
            //Console.WriteLine("points - valuePoints = " + (totalPoints - totalValuePoints));
            //Console.WriteLine("points*.30 = " + (totalPoints * .30));
            allowedPoints -= totalValuePoints;
            Console.WriteLine("value points = " + totalValuePoints);
            return vals;
        }

        public static void generateProblem()
        {
            int numVals;
            int[] values;
            char[] ops;
            totalPoints = 0;
            int baseVal, dev = 50;
            
            switch (diff)
            {
                case "EASY": baseVal = 75; dev *= 1; break;
                case "MED": baseVal = 125; dev *= 1; break;
                case "HARD": baseVal = 175; dev *= 2; break;
                case "VHARD": baseVal = 275; dev *= 2; break;
                case "IMP": baseVal = 375; dev *= 4; break;
                default: baseVal = 75; dev *= 1; break;
            }
            basic = new Random().Next(baseVal-dev, baseVal+dev+1);
            Console.WriteLine("basic = " + basic + " baseVal = " + baseVal + "\n");
            allowedPoints = basic;
            numVals = getNumValues();
            ops = getOperators(numVals);
            values = getValue(numVals);
            totalPoints = basic - allowedPoints;
            Console.Write(values[0]);
            for (int i = 0; i < ops.Length; i++)
            {
                Console.Write(" " + ops[i] + " " + values[i + 1]);
            }
            Console.WriteLine();
            Console.WriteLine("Total points = " + totalPoints);
        }

    }
}
