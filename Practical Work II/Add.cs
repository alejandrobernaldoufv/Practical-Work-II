﻿using System;

namespace oppguidedpw
{
    public class Add : Operation
    {
        public Add(string name, string symbol) : base(name, symbol)
        {
        }

        public override Result Operate(int op1, int op2)
        {
            return new IntegerResult(op1 + op2);
        }
        public override Result Operate(double op1, double op2)
        {
            return new DoubleResult(op1 + op2);
        }
    }
}
