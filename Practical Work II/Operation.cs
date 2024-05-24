using System;

namespace oppguidedpw
{
    public abstract class Operation
    {
        protected string symbol;
        protected string name;

        public Operation(string name, string symbol)
        {
            this.name = name;
            this.symbol = symbol;
        }

        public abstract Result Operate(int op1, int op2);
        public abstract Result Operate(double op1, double op2);

        public void Print(string op1, string op2, Result result)
        {
            Console.WriteLine($"{op1}{this.symbol}{op2} = {result.GetValue()}");
        }

        public string GetName()
        {
            return this.name;
        }
        public string GetSymbol()
        {
            return this.symbol.Trim();
        }
    }
}