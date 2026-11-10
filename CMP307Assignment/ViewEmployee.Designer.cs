namespace CMP307Assignment
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            Exit = new Button();
            DeleteEmployee = new Button();
            editasset = new Button();
            EmployeeInfo = new ListBox();
            searchemployee = new Button();
            employeeIDtextbox = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            Exit.Location = new Point(825, 434);
            Exit.Name = "Exit";
            Exit.Padding = new Padding(10);
            Exit.Size = new Size(242, 131);
            Exit.TabIndex = 30;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // DeleteEmployee
            // 
            DeleteEmployee.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            DeleteEmployee.Location = new Point(825, 205);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Padding = new Padding(10);
            DeleteEmployee.Size = new Size(242, 131);
            DeleteEmployee.TabIndex = 29;
            DeleteEmployee.Text = "Delete Employee";
            DeleteEmployee.UseVisualStyleBackColor = true;
            DeleteEmployee.Click += DeleteEmployee_Click;
            // 
            // editasset
            // 
            editasset.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            editasset.Location = new Point(486, 466);
            editasset.Name = "editasset";
            editasset.Padding = new Padding(10);
            editasset.Size = new Size(162, 99);
            editasset.TabIndex = 28;
            editasset.Text = "Edit";
            editasset.UseVisualStyleBackColor = true;
            editasset.Click += editasset_Click;
            // 
            // EmployeeInfo
            // 
            EmployeeInfo.FormattingEnabled = true;
            EmployeeInfo.ItemHeight = 15;
            EmployeeInfo.Location = new Point(12, 291);
            EmployeeInfo.Name = "EmployeeInfo";
            EmployeeInfo.Size = new Size(422, 274);
            EmployeeInfo.TabIndex = 27;
            // 
            // searchemployee
            // 
            searchemployee.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            searchemployee.Location = new Point(343, 194);
            searchemployee.Name = "searchemployee";
            searchemployee.Padding = new Padding(10);
            searchemployee.Size = new Size(131, 62);
            searchemployee.TabIndex = 26;
            searchemployee.Text = "Search";
            searchemployee.UseVisualStyleBackColor = true;
            searchemployee.Click += searchemployee_Click;
            // 
            // employeeIDtextbox
            // 
            employeeIDtextbox.Location = new Point(12, 233);
            employeeIDtextbox.Name = "employeeIDtextbox";
            employeeIDtextbox.Size = new Size(88, 23);
            employeeIDtextbox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 191);
            label1.Name = "label1";
            label1.Size = new Size(325, 30);
            label1.TabIndex = 24;
            label1.Text = "Please Enter Employee ID Number ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(ats);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1096, 130);
            panel1.TabIndex = 23;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(779, 41);
            ats.Name = "ats";
            ats.Size = new Size(288, 42);
            ats.TabIndex = 4;
            ats.Text = "Search Employee";
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
            // ViewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 613);
            Controls.Add(Exit);
            Controls.Add(DeleteEmployee);
            Controls.Add(editasset);
            Controls.Add(EmployeeInfo);
            Controls.Add(searchemployee);
            Controls.Add(employeeIDtextbox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ViewEmployee";
            Text = "ViewEmployee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Exit;
        private Button DeleteEmployee;
        private Button editasset;
        private ListBox EmployeeInfo;
        private Button searchemployee;
        private TextBox employeeIDtextbox;
        private Label label1;
        private Panel panel1;
        private Label ats;
        private PictureBox pictureBox1;
    }
}