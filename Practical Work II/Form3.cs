using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Work_II
{
    public partial class Form3 : Form
    {
        private State state;

        public Form3(State s)
        {
            this.state = s;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.state.ChangeState(1);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                MessageBox.Show("CALCULATOR TERMS AND CONDITIONS OF USE\r\n\r\n1. ACCEPTANCE OF TERMS\r\n\r\nBy using this calculator and creating an account, you agree to these terms and conditions in their entirety. If you do not agree with any part of these terms, you must not use the calculator.\r\n\r\n2. DESCRIPTION OF SERVICE\r\n\r\nThis calculator is an online tool that allows you to perform mathematical calculations. To use all features, you must create an account and log in. Upon doing so, your calculations will be recorded for your reference.\r\n\r\n3. USE OF THE CALCULATOR\r\n\r\n3.1. Account Registration: You must provide accurate and complete information when creating your account. You are responsible for maintaining the confidentiality of your password.\r\n3.2. Calculation Logging: The calculator logs your calculations so that you can review them later.\r\n3.3. Acceptable Use: You must not use the calculator for any illegal, fraudulent, or infringing purposes.\r\n4. INTELLECTUAL PROPERTY\r\n\r\nAll intellectual property rights in the calculator, including source code, design, and logos, are owned by the calculator owner. You may not copy, modify, or distribute any element of the calculator without express permission.\r\n\r\n5. PRIVACY\r\n\r\nThe calculator collects and processes your personal data in accordance with our Privacy Policy. By using the calculator, you consent to the collection and use of your data as described in the Privacy Policy.\r\n\r\n6. LIMITATION OF LIABILITY\r\n\r\n6.1. Calculation Accuracy: The calculator owner does not guarantee the accuracy of calculations. You use the calculator at your own risk.\r\n6.2. Damages: The calculator owner is not liable for any direct, indirect, incidental, or consequential damages arising from the use or inability to use the calculator.\r\n7. MODIFICATION OF TERMS\r\n\r\nThe calculator owner reserves the right to modify these terms and conditions at any time. We will notify you of any significant changes.\r\n\r\n8. GOVERNING LAW AND JURISDICTION\r\n\r\nThese terms and conditions are governed by the laws of [Your Country/State]. Any disputes arising from these terms will be subject to the exclusive jurisdiction of the courts of [Your Country/State].");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool passwordIsLower(string password)
        {
            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool passwordIsUpper(string password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool passwordHasANumber(string password)
        {
            foreach (char c in password)
            {
                if (char.IsNumber(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool passwordHasACharacter(string password)
        {
            foreach (char c in password)
            {
                if (c == '.' || c == ',' || c == '!' || c == '?' || c == '@' || c == '#' || c == '$' || c == '%' || c == '^' || c == '&' || c == '*' || c == '(' || c == ')' || c == '-' || c == '_' || c == '+' || c == '=' || c == '[' || c == ']' || c == '{' || c == '}' || c == '|' || c == ';' || c == ':' || c == '<' || c == '>' || c == '/' || c == '\\' || c == '`' || c == '~')
                {
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text.Length >= 8 && passwordIsLower(textBox2.Text) && passwordIsUpper(textBox2.Text) && passwordHasANumber(textBox2.Text) && passwordHasACharacter(textBox2.Text) && textBox2.Text == textBox5.Text)
            {
                if(textBox1.Text != textBox4.Text)
                {
                    if (checkBox1.Checked == true)
                    {
                        User user = new User(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        state.AddUser(user);
                        state.WriteUsers();
                    }
                    else
                    {
                        MessageBox.Show("You must agree to the terms and conditions");
                    }
                    this.state.ChangeState(1);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Name can't be the same as username");
                }
            }
            else
            {
                MessageBox.Show("Password doesn't meet the requirements.");
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
