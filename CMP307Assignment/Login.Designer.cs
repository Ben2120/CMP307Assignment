namespace CMP307Assignment
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            emailaddress = new TextBox();
            label2 = new Label();
            password = new TextBox();
            homebtn = new Button();
            loginbutton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(ats);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1145, 130);
            panel1.TabIndex = 3;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(880, 42);
            ats.Name = "ats";
            ats.Size = new Size(197, 42);
            ats.TabIndex = 4;
            ats.Text = "Login Page";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(339, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 184);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 26;
            label1.Text = "Email Address";
            // 
            // emailaddress
            // 
            emailaddress.Location = new Point(21, 217);
            emailaddress.Name = "emailaddress";
            emailaddress.Size = new Size(258, 23);
            emailaddress.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(515, 184);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 28;
            label2.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(515, 217);
            password.Name = "password";
            password.Size = new Size(258, 23);
            password.TabIndex = 29;
            // 
            // homebtn
            // 
            homebtn.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            homebtn.Location = new Point(835, 473);
            homebtn.Name = "homebtn";
            homebtn.Padding = new Padding(10);
            homebtn.Size = new Size(242, 131);
            homebtn.TabIndex = 54;
            homebtn.Text = "Exit";
            homebtn.UseVisualStyleBackColor = true;
            homebtn.Click += homebtn_Click;
            // 
            // loginbutton
            // 
            loginbutton.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            loginbutton.Location = new Point(21, 473);
            loginbutton.Name = "loginbutton";
            loginbutton.Padding = new Padding(10);
            loginbutton.Size = new Size(242, 131);
            loginbutton.TabIndex = 53;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 652);
            Controls.Add(homebtn);
            Controls.Add(loginbutton);
            Controls.Add(password);
            Controls.Add(label2);
            Controls.Add(emailaddress);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label ats;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox emailaddress;
        private Label label2;
        private TextBox password;
        private Button homebtn;
        private Button loginbutton;
    }
}