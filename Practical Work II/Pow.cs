using System;

namespace oppguidedpw
{
    public class Pow : Operation
    {
        public Pow(string name, string symbol) : base(name, symbol)
        {
        }

        public override Result Operate(int op1, int op2)
        {
            int result = op1;

            if (op2 == 0) return new IntegerResult(1);

            for (int i = 1; i < op2; i++)
            {
                result = result * op1;
            }

            return new IntegerResult(result);
        }

        public override Result Operate(double op1, double op2)
        {
            return null;
        }
    }
}
