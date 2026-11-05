namespace CMP307Assignment
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            Employee = new Button();
            editassetsbutton = new Button();
            addasset = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(ats);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 130);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(702, 35);
            ats.Name = "ats";
            ats.Size = new Size(370, 42);
            ats.TabIndex = 3;
            ats.Text = "Asset Tracking System";
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
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(361, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 208);
            panel3.TabIndex = 0;
            // 
            // Employee
            // 
            Employee.Font = new Font("Georgia", 15.75F, FontStyle.Bold);
            Employee.Location = new Point(18, 8);
            Employee.Name = "Employee";
            Employee.Padding = new Padding(10);
            Employee.Size = new Size(349, 235);
            Employee.TabIndex = 6;
            Employee.Text = "Employees";
            Employee.UseVisualStyleBackColor = true;
            Employee.Click += button2_Click;
            // 
            // editassetsbutton
            // 
            editassetsbutton.Font = new Font("Georgia", 15.75F, FontStyle.Bold);
            editassetsbutton.Location = new Point(25, 8);
            editassetsbutton.Name = "editassetsbutton";
            editassetsbutton.Padding = new Padding(10);
            editassetsbutton.Size = new Size(342, 235);
            editassetsbutton.TabIndex = 6;
            editassetsbutton.Text = "View/Edit Assets";
            editassetsbutton.UseVisualStyleBackColor = true;
            editassetsbutton.Click += SystemInfo_Click;
            // 
            // addasset
            // 
            addasset.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addasset.Location = new Point(12, 8);
            addasset.Name = "addasset";
            addasset.Padding = new Padding(10);
            addasset.Size = new Size(342, 235);
            addasset.TabIndex = 6;
            addasset.Text = "Add Asset";
            addasset.UseVisualStyleBackColor = true;
            addasset.Click += addasset_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Location = new Point(0, 377);
            panel5.Name = "panel5";
            panel5.Size = new Size(1084, 337);
            panel5.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Controls.Add(editassetsbutton);
            panel4.Location = new Point(712, 128);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 251);
            panel4.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SteelBlue;
            panel7.Controls.Add(addasset);
            panel7.Location = new Point(0, 128);
            panel7.Name = "panel7";
            panel7.Size = new Size(350, 251);
            panel7.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(Employee);
            panel2.Location = new Point(346, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 251);
            panel2.TabIndex = 6;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1084, 711);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScottishGlen - Asset Tracking System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label ats;
        private Button Employee;
        private Button editassetsbutton;
        private Button addasset;
        private Panel panel5;
        private Panel panel4;
        private Panel panel7;
        private Panel panel2;
    }
}
