using Microsoft.VisualBasic.ApplicationServices;

namespace Practical_Work_II
{
    public partial class Form1 : Form
    {
        private State state;
        
        public Form1(State s)
        {
            this.state = s;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.state.WriteUsers();
            this.state.ChangeState(0);
            this.Close();
        }

        private void singnInButton_Click(object sender, EventArgs e)
        {
            state.LogIn(usertxt.Text, txtpassword.Text);
            this.Close();
        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.state.ChangeState(3);
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.state.ChangeState(4);
            this.Close();   
        }
    }
}