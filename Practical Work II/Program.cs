using Microsoft.VisualBasic.ApplicationServices;

namespace Practical_Work_II
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            State s = new State();

            while (s.GetState() != 0)
            {
                switch (s.GetState())
                {
                    case 1:
                        Application.Run(new Form1(s));
                        break;

                    case 2:
                        Application.Run(new Form2(s));
                        break;

                    case 3:
                        Application.Run(new Form3(s));
                        break;

                    case 4:
                        Application.Run(new Form4(s));
                        break;

                    case 5:
                        Application.Run(new Form5(s));
                        break;
                }
            }
        }
    }
}