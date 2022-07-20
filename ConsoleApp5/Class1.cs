using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Class1
    {
        public int Calc(int a, int b,string x)
        {
            switch(x)
            {
                case "/":
                return a / b;
                break;
                case "+":
                    return a + b;
                    break;
                case "*":
                    return a * b;
                    break;
                case "-":
                    return a - b;
                    break;
            }
            return 0;
        }
        

       public enum Errorenum
        {
            Wrong_Symbol,
            Cannot_Divide_into_0,  
        }
            

    }
}
