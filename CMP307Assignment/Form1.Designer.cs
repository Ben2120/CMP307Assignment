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
            pictureBox1 = new PictureBox();
            ats = new Label();
            panel3 = new Panel();
            addingSoftwarebutton = new Button();
            editsoftwarebutton = new Button();
            editassetsbutton = new Button();
            Employee = new Button();
            addasset = new Button();
            panel5 = new Panel();
            login = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(ats);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 130);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
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
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 28F, FontStyle.Bold);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(666, 42);
            ats.Name = "ats";
            ats.Size = new Size(386, 43);
            ats.TabIndex = 3;
            ats.Text = "Asset Tracking System";
            // 
            // panel3
            // 
            panel3.Location = new Point(361, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(375, 208);
            panel3.TabIndex = 0;
            // 
            // addingSoftwarebutton
            // 
            addingSoftwarebutton.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addingSoftwarebutton.Location = new Point(666, 473);
            addingSoftwarebutton.Name = "addingSoftwarebutton";
            addingSoftwarebutton.Padding = new Padding(10);
            addingSoftwarebutton.Size = new Size(178, 98);
            addingSoftwarebutton.TabIndex = 7;
            addingSoftwarebutton.Text = "Add Software";
            addingSoftwarebutton.UseVisualStyleBackColor = true;
            addingSoftwarebutton.Click += addingSoftwarebutton_Click;
            // 
            // editsoftwarebutton
            // 
            editsoftwarebutton.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editsoftwarebutton.Location = new Point(893, 473);
            editsoftwarebutton.Name = "editsoftwarebutton";
            editsoftwarebutton.Padding = new Padding(10);
            editsoftwarebutton.Size = new Size(178, 98);
            editsoftwarebutton.TabIndex = 8;
            editsoftwarebutton.Text = "View/Edit Software";
            editsoftwarebutton.UseVisualStyleBackColor = true;
            editsoftwarebutton.Click += editsoftwarebutton_Click;
            // 
            // editassetsbutton
            // 
            editassetsbutton.Font = new Font("Georgia", 15.75F, FontStyle.Bold);
            editassetsbutton.Location = new Point(444, 473);
            editassetsbutton.Name = "editassetsbutton";
            editassetsbutton.Padding = new Padding(10);
            editassetsbutton.Size = new Size(178, 98);
            editassetsbutton.TabIndex = 6;
            editassetsbutton.Text = "View/Edit Assets";
            editassetsbutton.UseVisualStyleBackColor = true;
            editassetsbutton.Click += SystemInfo_Click;
            // 
            // Employee
            // 
            Employee.Font = new Font("Georgia", 15.75F, FontStyle.Bold);
            Employee.Location = new Point(223, 471);
            Employee.Name = "Employee";
            Employee.Padding = new Padding(10);
            Employee.Size = new Size(178, 98);
            Employee.TabIndex = 6;
            Employee.Text = "Employees";
            Employee.UseVisualStyleBackColor = true;
            Employee.Click += button2_Click;
            // 
            // addasset
            // 
            addasset.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addasset.Location = new Point(11, 471);
            addasset.Name = "addasset";
            addasset.Padding = new Padding(10);
            addasset.Size = new Size(178, 98);
            addasset.TabIndex = 6;
            addasset.Text = "Add Asset";
            addasset.UseVisualStyleBackColor = true;
            addasset.Click += addasset_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(login);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(addasset);
            panel5.Controls.Add(Employee);
            panel5.Controls.Add(editassetsbutton);
            panel5.Controls.Add(editsoftwarebutton);
            panel5.Controls.Add(addingSoftwarebutton);
            panel5.Location = new Point(0, 128);
            panel5.Name = "panel5";
            panel5.Size = new Size(1084, 586);
            panel5.TabIndex = 8;
            // 
            // login
            // 
            login.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.Location = new Point(12, 198);
            login.Name = "login";
            login.Padding = new Padding(10);
            login.Size = new Size(178, 98);
            login.TabIndex = 11;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(845, 31);
            label2.TabIndex = 10;
            label2.Text = "Please begin by logging in and choosing any option from the bottom tab bar.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(668, 31);
            label1.TabIndex = 9;
            label1.Text = "Welcome to the Asset Tracking System for ScottishGlen.";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1084, 711);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScottishGlen - Asset Tracking System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label ats;
        private Button addingSoftwarebutton;
        private Button editsoftwarebutton;
        private Button editassetsbutton;
        private Button Employee;
        private Button addasset;
        private Panel panel5;
        private Button login;
        private Label label2;
        private Label label1;
    }
}
