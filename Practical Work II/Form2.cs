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
    public partial class Form2 : Form
    {
        private State state;

        

        public Form2(State s)
        {
            InitializeComponent();
            this.state = s;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.state.ChangeState(1);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " + ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " - ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " * ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " / ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " ^ ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + " % ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.state.GetCurrentUser().AddOperation();
            
            this.textBox1.Text = this.state.PerformOperation(this.textBox1.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + ",";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.state.ChangeState(5);
            this.Close();
        }
    }
}
