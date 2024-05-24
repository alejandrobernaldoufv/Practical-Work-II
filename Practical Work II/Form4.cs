using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Work_II
{
    public partial class Form4 : Form
    {
        private State state;
        public Form4(State s)
        {
            this.state = s;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.state.ChangeState(1);
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

            
            bool userfound = state.searchUser(textBox1.Text, textBox2.Text, textBox3.Text);


            if (userfound == true)
            {
                if (textBox4.Text.Length >= 8 && passwordIsLower(textBox4.Text) && passwordIsUpper(textBox4.Text) && passwordHasANumber(textBox4.Text) && passwordHasACharacter(textBox4.Text) && textBox4.Text == textBox5.Text)
                {
                    this.state.ChangeUser(this.textBox2.Text, this.textBox4.Text, this.textBox3.Text, this.textBox1.Text);
                    this.state.ChangeState(1);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password doesn't meet the requirements.");
                }
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
