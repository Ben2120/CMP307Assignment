namespace CMP307Assignment
{
    partial class EditingEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditingEmployee));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            updateinformation = new Button();
            Departmentsbox = new ComboBox();
            label5 = new Label();
            email = new TextBox();
            label4 = new Label();
            lastname = new TextBox();
            label3 = new Label();
            firstname = new TextBox();
            label2 = new Label();
            employeeID = new TextBox();
            label1 = new Label();
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
            panel1.Size = new Size(1157, 130);
            panel1.TabIndex = 2;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(607, 43);
            ats.Name = "ats";
            ats.Size = new Size(529, 42);
            ats.TabIndex = 4;
            ats.Text = "Updating Employee Information";
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
            // button2
            // 
            button2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            button2.Location = new Point(821, 425);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(242, 131);
            button2.TabIndex = 33;
            button2.Text = "Exit ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // updateinformation
            // 
            updateinformation.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            updateinformation.Location = new Point(821, 201);
            updateinformation.Name = "updateinformation";
            updateinformation.Padding = new Padding(10);
            updateinformation.Size = new Size(242, 131);
            updateinformation.TabIndex = 32;
            updateinformation.Text = "Update Information";
            updateinformation.UseVisualStyleBackColor = true;
            updateinformation.Click += updateinformation_Click;
            // 
            // Departmentsbox
            // 
            Departmentsbox.FormattingEnabled = true;
            Departmentsbox.Items.AddRange(new object[] { "Finance", "Human Resources", "Operations", "Sales", "Information Technology" });
            Departmentsbox.Location = new Point(26, 382);
            Departmentsbox.Name = "Departmentsbox";
            Departmentsbox.Size = new Size(258, 23);
            Departmentsbox.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 338);
            label5.Name = "label5";
            label5.Size = new Size(120, 30);
            label5.TabIndex = 30;
            label5.Text = "Department";
            // 
            // email
            // 
            email.Location = new Point(398, 282);
            email.Name = "email";
            email.Size = new Size(258, 23);
            email.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(398, 249);
            label4.Name = "label4";
            label4.Size = new Size(147, 30);
            label4.TabIndex = 28;
            label4.Text = "E-mail Address";
            // 
            // lastname
            // 
            lastname.Location = new Point(26, 282);
            lastname.Name = "lastname";
            lastname.Size = new Size(258, 23);
            lastname.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 249);
            label3.Name = "label3";
            label3.Size = new Size(106, 30);
            label3.TabIndex = 26;
            label3.Text = "Last Name";
            // 
            // firstname
            // 
            firstname.Location = new Point(398, 201);
            firstname.Name = "firstname";
            firstname.Size = new Size(258, 23);
            firstname.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(398, 168);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 24;
            label2.Text = "First Name";
            // 
            // employeeID
            // 
            employeeID.Location = new Point(26, 201);
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(258, 23);
            employeeID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 168);
            label1.Name = "label1";
            label1.Size = new Size(304, 30);
            label1.TabIndex = 22;
            label1.Text = "Employee Identification Number";
            // 
            // EditingEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 632);
            Controls.Add(button2);
            Controls.Add(updateinformation);
            Controls.Add(Departmentsbox);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(lastname);
            Controls.Add(label3);
            Controls.Add(firstname);
            Controls.Add(label2);
            Controls.Add(employeeID);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "EditingEmployee";
            Text = "EditingEmployee";
            Load += EditingEmployee_Load;
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
        private Button button2;
        private Button updateinformation;
        private ComboBox Departmentsbox;
        private Label label5;
        private TextBox email;
        private Label label4;
        private TextBox lastname;
        private Label label3;
        private TextBox firstname;
        private Label label2;
        private TextBox employeeID;
        private Label label1;
    }
}