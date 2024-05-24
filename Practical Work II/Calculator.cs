using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Globalization;
using System.Linq;

namespace oppguidedpw
{
    public class Calculator
    {
        private List<Operation> operations;

        public Calculator()
        {
            this.operations = new List<Operation>();

            this.operations.Add(new Add("Add", " + "));
            this.operations.Add(new Subtract("Subtract", " - "));
            this.operations.Add(new Divide("Divide", " / "));
            this.operations.Add(new Multiply("Multiply", " * "));
            this.operations.Add(new Pow("Pow", "^"));
            this.operations.Add(new Modulus("Modulus", " % "));
        }

        public int Exit()
        {
            return this.operations.Count + 1;
        }
        private int GetOperationBySign(string sign)
        {
            for (int i = 0; i < this.operations.Count; i++)
            {
                if (sign == this.operations[i].GetSymbol()) return i + 1;
            }

            return 0;
        }

        public int PrintOperations()
        {
            int option = 0;

            while (option == 0)
            {
                try
                {

                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("--------------------------------------");

                    for (int i = 0; i < this.operations.Count; i++)
                    {
                        Console.WriteLine($" {i + 1}. {this.operations[i].GetName()}");
                    }

                    Console.WriteLine($" {this.Exit()}. Exit");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();

                    string tmp = Console.ReadLine();

                    if (tmp == "") return this.Exit();

                    option = int.Parse(tmp);
                }
                catch (FormatException)
                {
                }
            }

            if (option < 1 || option > this.Exit()) return this.Exit();             

            return option;
        }

        private string FixOperand(string operand)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;

            if (currentCulture.TwoLetterISOLanguageName == "es")
            {
                operand = operand.Replace(".", ",");
            }
            else
            {
                operand = operand.Replace(",", ".");
            }

            return operand;
        }

        private Boolean IsDecimalOperation(string op1, string op2)
        {
            ArrayList operators = new ArrayList(2);

            bool DecimalOp = false;

            if (op1.Contains(".") || op2.Contains(".")) DecimalOp = true;
            if (op1.Contains(",") || op2.Contains(",")) DecimalOp = true;

            return DecimalOp;
        }

        public Result PerformOperation(string operation)
        {
            string[] components = operation.Split(" ");

            MessageBox.Show(components.ToString());
            int op = this.GetOperationBySign(components[1]);

            if (op != 0)
            {
                return this.PerformOperation(op,components[0],components[2]);
            }

            return null;
        }

        public Result PerformOperation(int op, string op1, string op2)
        {

            try
            {
                Result result = null;

                op1 = FixOperand(op1);
                op2 = FixOperand(op2);

                if (IsDecimalOperation(op1, op2))
                {
                    result = this.operations[op - 1].Operate(Double.Parse(op1),Double.Parse(op2));
                }
                else
                {
                    result = this.operations[op - 1].Operate(Int32.Parse(op1),Int32.Parse(op2));
                }

                if (result != null)
                    return result;
                else
                    Console.WriteLine("This operation cannot be performed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("This operation cannot be performed.");
            }

            return null;
        }
    }
}