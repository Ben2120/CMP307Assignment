namespace CMP307Assignment
{
    partial class AddingSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingSoftware));
            panel1 = new Panel();
            softwarelabel = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            softwareID = new TextBox();
            label1 = new Label();
            OperatingSystemName = new TextBox();
            label3 = new Label();
            OperatingSystemVersion = new TextBox();
            label4 = new Label();
            OperatingSystemManufacturer = new TextBox();
            label5 = new Label();
            dateadded = new DateTimePicker();
            savebutton = new Button();
            exitbutton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(softwarelabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 130);
            panel1.TabIndex = 3;
            // 
            // softwarelabel
            // 
            softwarelabel.AutoSize = true;
            softwarelabel.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            softwarelabel.ForeColor = SystemColors.ButtonFace;
            softwarelabel.Location = new Point(848, 42);
            softwarelabel.Name = "softwarelabel";
            softwarelabel.Size = new Size(286, 42);
            softwarelabel.TabIndex = 4;
            softwarelabel.Text = "Adding Software";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(292, 30);
            label2.TabIndex = 24;
            label2.Text = "Software Identifcation Number";
            // 
            // softwareID
            // 
            softwareID.Location = new Point(12, 186);
            softwareID.Name = "softwareID";
            softwareID.ReadOnly = true;
            softwareID.Size = new Size(258, 23);
            softwareID.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 231);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 26;
            label1.Text = "Operating System Name";
            // 
            // OperatingSystemName
            // 
            OperatingSystemName.Location = new Point(12, 264);
            OperatingSystemName.Name = "OperatingSystemName";
            OperatingSystemName.Size = new Size(258, 23);
            OperatingSystemName.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 320);
            label3.Name = "label3";
            label3.Size = new Size(246, 30);
            label3.TabIndex = 28;
            label3.Text = "Operating System Version";
            // 
            // OperatingSystemVersion
            // 
            OperatingSystemVersion.Location = new Point(12, 353);
            OperatingSystemVersion.Name = "OperatingSystemVersion";
            OperatingSystemVersion.Size = new Size(258, 23);
            OperatingSystemVersion.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 407);
            label4.Name = "label4";
            label4.Size = new Size(301, 30);
            label4.TabIndex = 30;
            label4.Text = "Operating System Manufacturer";
            // 
            // OperatingSystemManufacturer
            // 
            OperatingSystemManufacturer.Location = new Point(12, 440);
            OperatingSystemManufacturer.Name = "OperatingSystemManufacturer";
            OperatingSystemManufacturer.Size = new Size(258, 23);
            OperatingSystemManufacturer.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 488);
            label5.Name = "label5";
            label5.Size = new Size(114, 30);
            label5.TabIndex = 32;
            label5.Text = "Date Added";
            // 
            // dateadded
            // 
            dateadded.Location = new Point(12, 521);
            dateadded.Name = "dateadded";
            dateadded.Size = new Size(193, 23);
            dateadded.TabIndex = 33;
            // 
            // savebutton
            // 
            savebutton.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            savebutton.Location = new Point(822, 186);
            savebutton.Name = "savebutton";
            savebutton.Padding = new Padding(10);
            savebutton.Size = new Size(242, 131);
            savebutton.TabIndex = 52;
            savebutton.Text = "Save Software";
            savebutton.UseVisualStyleBackColor = true;
            // 
            // exitbutton
            // 
            exitbutton.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            exitbutton.Location = new Point(822, 407);
            exitbutton.Name = "exitbutton";
            exitbutton.Padding = new Padding(10);
            exitbutton.Size = new Size(242, 131);
            exitbutton.TabIndex = 53;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            // 
            // AddingSoftware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 618);
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
            Name = "AddingSoftware";
            Text = "AddingSoftware";
            Load += AddingSoftware_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label softwarelabel;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox softwareID;
        private Label label1;
        private TextBox OperatingSystemName;
        private Label label3;
        private TextBox OperatingSystemVersion;
        private Label label4;
        private TextBox OperatingSystemManufacturer;
        private Label label5;
        private DateTimePicker dateadded;
        private Button savebutton;
        private Button exitbutton;
    }
}