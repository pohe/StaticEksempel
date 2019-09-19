using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public static class Calculator
    {

        // Add two int numbers return an int
        public static int Add(int a, int b)
        {
            return a + b;
        }

        //Minus beregning på to int

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        //Multiplikation af to int tal

        public static int Mult(int jens, int oskar)
        {
            return jens * oskar;
        }

        //DivisionInt af to heltal retur heltal

        public static int DivisionInt(int a, int b)
        {
            return a / b;
        }


        //DivisionDec af to heltal retur decimal

        public static double DivisionDec(int a, int b)
        {
            return a / (b*1.0);
        }



    }
}
