namespace NRE2_8
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Caladea", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 0;
            label1.Text = "User Login Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Caladea", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 1;
            label2.Text = "User ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Caladea", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(106, 102);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InfoText;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(106, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Caladea", 7F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(173, 144);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 5;
            button1.Text = "Forgot Password?";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new Font("Caladea", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 172);
            button2.Name = "button2";
            button2.Size = new Size(94, 47);
            button2.TabIndex = 6;
            button2.Text = "New User";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Caladea", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(186, 173);
            button3.Name = "button3";
            button3.Size = new Size(95, 47);
            button3.TabIndex = 7;
            button3.Text = "Log-in";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(303, 231);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "User Login Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}