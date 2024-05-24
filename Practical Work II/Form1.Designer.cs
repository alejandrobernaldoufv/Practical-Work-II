namespace Practical_Work_II
{
    partial class Form1
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            singnInButton = new Button();
            txtpassword = new TextBox();
            usertxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(267, 27);
            label1.Name = "label1";
            label1.Size = new Size(437, 62);
            label1.TabIndex = 0;
            label1.Text = "OOP CALCULATOR";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(singnInButton);
            groupBox1.Controls.Add(txtpassword);
            groupBox1.Controls.Add(usertxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(78, 119);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(751, 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(309, 211);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(125, 20);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(332, 356);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 229);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            label4.Click += label4_Click;
            // 
            // singnInButton
            // 
            singnInButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            singnInButton.Location = new Point(272, 277);
            singnInButton.Margin = new Padding(3, 4, 3, 4);
            singnInButton.Name = "singnInButton";
            singnInButton.Size = new Size(203, 64);
            singnInButton.TabIndex = 4;
            singnInButton.Text = "Sign In";
            singnInButton.UseVisualStyleBackColor = true;
            singnInButton.Click += singnInButton_Click;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(272, 180);
            txtpassword.Margin = new Padding(3, 4, 3, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(212, 27);
            txtpassword.TabIndex = 3;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // usertxt
            // 
            usertxt.Location = new Point(272, 68);
            usertxt.Margin = new Padding(3, 4, 3, 4);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(212, 27);
            usertxt.TabIndex = 2;
            usertxt.TextChanged += usertxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(116, 164);
            label3.Name = "label3";
            label3.Size = new Size(167, 46);
            label3.TabIndex = 1;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(106, 50);
            label2.Name = "label2";
            label2.Size = new Size(177, 46);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(776, 41);
            button1.Name = "button1";
            button1.Size = new Size(113, 48);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 600);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtpassword;
        private TextBox usertxt;
        private Label label3;
        private Button singnInButton;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
