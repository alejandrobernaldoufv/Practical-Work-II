using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practical_Work_II
{
    public partial class Form5 : Form
    {
        private State state;
        public Form5(State s)
        {
            InitializeComponent();
            this.state = s;
            this.textBox2.Text = this.state.GetCurrentUser().GetUsername();
            this.textBox3.Text = this.state.GetCurrentUser().GetPassword();
            this.textBox4.Text = this.state.GetCurrentUser().GetEmail();
            this.textBox1.Text = this.state.GetCurrentUser().GetName();
            this.label8.Text = this.state.GetCurrentUser().GetOperations().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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
            if (textBox3.Text.Length >= 8 && passwordIsLower(textBox3.Text) && passwordIsUpper(textBox3.Text) && passwordHasANumber(textBox3.Text) && passwordHasACharacter(textBox3.Text))
            {
                if (textBox1.Text != textBox3.Text)
                {
                    this.state.ChangeUser(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text);
                    this.state.ChangeState(2);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Name can't be the same as username");
                }
            }
            else
            {
                MessageBox.Show("Password doesn't meet the requirements");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            state.ChangeState(1);
            this.Close();
        }
    }
}
