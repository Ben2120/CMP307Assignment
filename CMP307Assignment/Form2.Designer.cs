namespace CMP307Assignment
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            EditEmployee = new Button();
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
            panel1.Size = new Size(1134, 130);
            panel1.TabIndex = 1;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(752, 44);
            ats.Name = "ats";
            ats.Size = new Size(370, 42);
            ats.TabIndex = 4;
            ats.Text = "Employee Information";
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(304, 30);
            label1.TabIndex = 3;
            label1.Text = "Employee Identification Number";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(384, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 150);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 23);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 231);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(384, 264);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 23);
            textBox4.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(384, 231);
            label4.Name = "label4";
            label4.Size = new Size(147, 30);
            label4.TabIndex = 9;
            label4.Text = "E-mail Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 320);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 11;
            label5.Text = "Department";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Finance", "Human Resources", "Operations", "Sales", "Information Technology" });
            comboBox1.Location = new Point(12, 364);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 23);
            comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            button1.Location = new Point(807, 183);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(242, 131);
            button1.TabIndex = 20;
            button1.Text = "Save Information";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            button2.Location = new Point(807, 407);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(242, 131);
            button2.TabIndex = 21;
            button2.Text = "Exit ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EditEmployee
            // 
            EditEmployee.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            EditEmployee.Location = new Point(12, 407);
            EditEmployee.Name = "EditEmployee";
            EditEmployee.Padding = new Padding(10);
            EditEmployee.Size = new Size(242, 131);
            EditEmployee.TabIndex = 22;
            EditEmployee.Text = "Edit an Employee's Information";
            EditEmployee.UseVisualStyleBackColor = true;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 612);
            Controls.Add(EditEmployee);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
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
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button EditEmployee;
    }
}