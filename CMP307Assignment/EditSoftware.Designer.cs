namespace CMP307Assignment
{
    partial class EditSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSoftware));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            exitbutton = new Button();
            savebutton = new Button();
            dateadded = new DateTimePicker();
            label5 = new Label();
            OperatingSystemManufacturer = new TextBox();
            label4 = new Label();
            OperatingSystemVersion = new TextBox();
            label3 = new Label();
            OperatingSystemName = new TextBox();
            label1 = new Label();
            softwareID = new TextBox();
            label2 = new Label();
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
            panel1.Size = new Size(1129, 130);
            panel1.TabIndex = 2;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(832, 45);
            ats.Name = "ats";
            ats.Size = new Size(285, 42);
            ats.TabIndex = 4;
            ats.Text = "Editing Software";
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
            // exitbutton
            // 
            exitbutton.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            exitbutton.Location = new Point(840, 415);
            exitbutton.Name = "exitbutton";
            exitbutton.Padding = new Padding(10);
            exitbutton.Size = new Size(242, 131);
            exitbutton.TabIndex = 65;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            // 
            // savebutton
            // 
            savebutton.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            savebutton.Location = new Point(840, 194);
            savebutton.Name = "savebutton";
            savebutton.Padding = new Padding(10);
            savebutton.Size = new Size(242, 131);
            savebutton.TabIndex = 64;
            savebutton.Text = "Save Software";
            savebutton.UseVisualStyleBackColor = true;
            // 
            // dateadded
            // 
            dateadded.Location = new Point(30, 529);
            dateadded.Name = "dateadded";
            dateadded.Size = new Size(193, 23);
            dateadded.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 496);
            label5.Name = "label5";
            label5.Size = new Size(114, 30);
            label5.TabIndex = 62;
            label5.Text = "Date Added";
            // 
            // OperatingSystemManufacturer
            // 
            OperatingSystemManufacturer.Location = new Point(30, 448);
            OperatingSystemManufacturer.Name = "OperatingSystemManufacturer";
            OperatingSystemManufacturer.Size = new Size(258, 23);
            OperatingSystemManufacturer.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 415);
            label4.Name = "label4";
            label4.Size = new Size(301, 30);
            label4.TabIndex = 60;
            label4.Text = "Operating System Manufacturer";
            // 
            // OperatingSystemVersion
            // 
            OperatingSystemVersion.Location = new Point(30, 361);
            OperatingSystemVersion.Name = "OperatingSystemVersion";
            OperatingSystemVersion.Size = new Size(258, 23);
            OperatingSystemVersion.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 328);
            label3.Name = "label3";
            label3.Size = new Size(246, 30);
            label3.TabIndex = 58;
            label3.Text = "Operating System Version";
            // 
            // OperatingSystemName
            // 
            OperatingSystemName.Location = new Point(30, 272);
            OperatingSystemName.Name = "OperatingSystemName";
            OperatingSystemName.Size = new Size(258, 23);
            OperatingSystemName.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 239);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 56;
            label1.Text = "Operating System Name";
            // 
            // softwareID
            // 
            softwareID.Location = new Point(30, 194);
            softwareID.Name = "softwareID";
            softwareID.ReadOnly = true;
            softwareID.Size = new Size(258, 23);
            softwareID.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 161);
            label2.Name = "label2";
            label2.Size = new Size(292, 30);
            label2.TabIndex = 54;
            label2.Text = "Software Identifcation Number";
            // 
            // EditSoftware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 613);
            Controls.Add(exitbutton);
            Controls.Add(savebutton);
            Controls.Add(dateadded);
            Controls.Add(label5);
            Controls.Add(OperatingSystemManufacturer);
            Controls.Add(label4);
            Controls.Add(OperatingSystemVersion);
            Controls.Add(label3);
            Controls.Add(OperatingSystemName);
            Controls.Add(label1);
            Controls.Add(softwareID);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "EditSoftware";
            Text = "EditSoftware";
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
        private Button exitbutton;
        private Button savebutton;
        private DateTimePicker dateadded;
        private Label label5;
        private TextBox OperatingSystemManufacturer;
        private Label label4;
        private TextBox OperatingSystemVersion;
        private Label label3;
        private TextBox OperatingSystemName;
        private Label label1;
        private TextBox softwareID;
        private Label label2;
    }
}