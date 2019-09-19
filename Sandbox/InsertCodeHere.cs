using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Calculator c = new Calculator();
            int addResult= Calculator.Add(12, 23);
            double divDecResult = Calculator.DivisionDec(23, 12);
            
            Console.WriteLine(divDecResult);

            // The LAST line of code should be ABOVE this line
        }
    }
}