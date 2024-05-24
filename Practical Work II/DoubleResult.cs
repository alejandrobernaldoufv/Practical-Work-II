using System;

namespace oppguidedpw
{
    public class DoubleResult : Result
    {
        private double value;

        public DoubleResult(double value)
        {
            this.value = value;
        }

        public override Object GetValue()
        {
            return this.value;
        }
    }
}
