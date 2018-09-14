using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class Calculator
    {
        #region public methods
        public int add(int op1, int op2)
        {
            return op1 + op2;
        }
        public int sub(int op1,int op2)
        {
            return op1 - op2;
        }
        public int mul(int op1, int op2)
        {
            return op1 * op2;
        }
        public int div(int op1, int op2)
        {
            if (op2 == 0)
            {
                return 0;
            }
            else return op1 / op2;
        }
        #endregion public methods
    }
}
