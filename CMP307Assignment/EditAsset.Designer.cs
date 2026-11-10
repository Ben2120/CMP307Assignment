namespace CMP307Assignment
{
    partial class EditAsset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAsset));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            homebtn = new Button();
            editassetbutton = new Button();
            extranotes = new TextBox();
            purchasedate = new TextBox();
            employeeID = new TextBox();
            systemIP = new TextBox();
            label9 = new Label();
            SystemType = new TextBox();
            label8 = new Label();
            SystemManufacturer = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            SystemModel = new TextBox();
            label3 = new Label();
            systemname = new TextBox();
            label2 = new Label();
            assetID = new TextBox();
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
            panel1.Size = new Size(1135, 130);
            panel1.TabIndex = 1;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(880, 42);
            ats.Name = "ats";
            ats.Size = new Size(226, 42);
            ats.TabIndex = 4;
            ats.Text = "Editing Asset";
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
            // homebtn
            // 
            homebtn.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            homebtn.Location = new Point(864, 396);
            homebtn.Name = "homebtn";
            homebtn.Padding = new Padding(10);
            homebtn.Size = new Size(242, 131);
            homebtn.TabIndex = 41;
            homebtn.Text = "Exit";
            homebtn.UseVisualStyleBackColor = true;
            homebtn.Click += homebtn_Click;
            // 
            // editassetbutton
            // 
            editassetbutton.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            editassetbutton.Location = new Point(864, 213);
            editassetbutton.Name = "editassetbutton";
            editassetbutton.Padding = new Padding(10);
            editassetbutton.Size = new Size(242, 131);
            editassetbutton.TabIndex = 40;
            editassetbutton.Text = "Update Asset";
            editassetbutton.UseVisualStyleBackColor = true;
            editassetbutton.Click += editassetbutton_Click;
            // 
            // extranotes
            // 
            extranotes.Location = new Point(530, 451);
            extranotes.Name = "extranotes";
            extranotes.Size = new Size(258, 23);
            extranotes.TabIndex = 39;
            // 
            // purchasedate
            // 
            purchasedate.Location = new Point(530, 354);
            purchasedate.Name = "purchasedate";
            purchasedate.Size = new Size(258, 23);
            purchasedate.TabIndex = 38;
            // 
            // employeeID
            // 
            employeeID.Location = new Point(530, 257);
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(75, 23);
            employeeID.TabIndex = 37;
            // 
            // systemIP
            // 
            systemIP.Location = new Point(12, 568);
            systemIP.Name = "systemIP";
            systemIP.Size = new Size(258, 23);
            systemIP.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 535);
            label9.Name = "label9";
            label9.Size = new Size(107, 30);
            label9.TabIndex = 35;
            label9.Text = "IP Address";
            // 
            // SystemType
            // 
            SystemType.Location = new Point(12, 495);
            SystemType.Name = "SystemType";
            SystemType.Size = new Size(258, 23);
            SystemType.TabIndex = 34;
            SystemType.TextChanged += SystemType_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 462);
            label8.Name = "label8";
            label8.Size = new Size(125, 30);
            label8.TabIndex = 33;
            label8.Text = "System Type";
            // 
            // SystemManufacturer
            // 
            SystemManufacturer.Location = new Point(12, 425);
            SystemManufacturer.Name = "SystemManufacturer";
            SystemManufacturer.Size = new Size(258, 23);
            SystemManufacturer.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 385);
            label7.Name = "label7";
            label7.Size = new Size(206, 30);
            label7.TabIndex = 31;
            label7.Text = "System Manufacturer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(347, 444);
            label6.Name = "label6";
            label6.Size = new Size(161, 30);
            label6.TabIndex = 30;
            label6.Text = "Additional Notes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(347, 347);
            label5.Name = "label5";
            label5.Size = new Size(141, 30);
            label5.TabIndex = 29;
            label5.Text = "Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(347, 250);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 28;
            label4.Text = "Employee ID";
            // 
            // SystemModel
            // 
            SystemModel.Location = new Point(12, 347);
            SystemModel.Name = "SystemModel";
            SystemModel.Size = new Size(258, 23);
            SystemModel.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 314);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 26;
            label3.Text = "System Model";
            // 
            // systemname
            // 
            systemname.Location = new Point(12, 273);
            systemname.Name = "systemname";
            systemname.Size = new Size(258, 23);
            systemname.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 240);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 24;
            label2.Text = "System Name";
            // 
            // assetID
            // 
            assetID.Location = new Point(12, 199);
            assetID.Name = "assetID";
            assetID.ReadOnly = true;
            assetID.Size = new Size(77, 23);
            assetID.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 166);
            label1.Name = "label1";
            label1.Size = new Size(258, 30);
            label1.TabIndex = 22;
            label1.Text = "Asset Identifcation Number";
            // 
            // EditAsset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 632);
            Controls.Add(homebtn);
            Controls.Add(editassetbutton);
            Controls.Add(extranotes);
            Controls.Add(purchasedate);
            Controls.Add(employeeID);
            Controls.Add(systemIP);
            Controls.Add(label9);
            Controls.Add(SystemType);
            Controls.Add(label8);
            Controls.Add(SystemManufacturer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(SystemModel);
            Controls.Add(label3);
            Controls.Add(systemname);
            Controls.Add(label2);
            Controls.Add(assetID);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "EditAsset";
            Text = "EditAsset";
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
        private Button homebtn;
        private Button editassetbutton;
        private TextBox extranotes;
        private TextBox purchasedate;
        private TextBox employeeID;
        private TextBox systemIP;
        private Label label9;
        private TextBox SystemType;
        private Label label8;
        private TextBox SystemManufacturer;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox SystemModel;
        private Label label3;
        private TextBox systemname;
        private Label label2;
        private TextBox assetID;
        private Label label1;
    }
}