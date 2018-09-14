using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class Calculator
    {
        public int Ope(int op1, int op2, char opr)
        {
            switch (opr)
            {
                case '+':
                    return add(op1,op2);
                    break;
                case '-':
                    return sub(op1,op2);
                    break;
                case '*':
                    return mul(op1,op2);
                    break;
                case '/':
                    return div(op1,op2);
                    break;
                default:
                    throw new System.FormatException("not usable");
                    break;
            }
        }
        #region private methods
        private int add(int op1, int op2)
        {
            return op1 + op2;
        }
        private int sub(int op1,int op2)
        {
            return op1 - op2;
        }
        private int mul(int op1, int op2)
        {
            return op1 * op2;
        }
        private int div(int op1, int op2)
        {
            if (op2 == 0)
            {
                return 0;
            }
            else return op1 / op2;
        }
        #endregion private methods
    }
}
