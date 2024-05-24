using System;

namespace oppguidedpw
{
    public class IntegerResult : Result
    {
        private int value;

        public IntegerResult(int value)
        {
            this.value = value;
        }

        public override Object GetValue()
        {
            return this.value;
        }
    }
}