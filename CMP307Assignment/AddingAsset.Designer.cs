namespace CMP307Assignment
{
    partial class AddingAsset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingAsset));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            assetID = new TextBox();
            label1 = new Label();
            systemname = new TextBox();
            systemIP = new TextBox();
            label9 = new Label();
            systemtype = new TextBox();
            label8 = new Label();
            systemmanufacturer = new TextBox();
            label7 = new Label();
            systemmodel = new TextBox();
            label3 = new Label();
            extranotes = new TextBox();
            purchaseDate = new TextBox();
            employeeID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            savebutton = new Button();
            homebtn = new Button();
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
            panel1.Size = new Size(1130, 130);
            panel1.TabIndex = 2;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(880, 42);
            ats.Name = "ats";
            ats.Size = new Size(227, 42);
            ats.TabIndex = 4;
            ats.Text = "Adding Asset";
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
            label2.Location = new Point(12, 150);
            label2.Name = "label2";
            label2.Size = new Size(258, 30);
            label2.TabIndex = 23;
            label2.Text = "Asset Identifcation Number";
            // 
            // assetID
            // 
            assetID.Location = new Point(12, 183);
            assetID.Name = "assetID";
            assetID.ReadOnly = true;
            assetID.Size = new Size(77, 23);
            assetID.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 225);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 25;
            label1.Text = "System Name";
            // 
            // systemname
            // 
            systemname.Location = new Point(12, 267);
            systemname.Name = "systemname";
            systemname.Size = new Size(258, 23);
            systemname.TabIndex = 26;
            // 
            // systemIP
            // 
            systemIP.Location = new Point(12, 565);
            systemIP.Name = "systemIP";
            systemIP.ReadOnly = true;
            systemIP.Size = new Size(258, 23);
            systemIP.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 532);
            label9.Name = "label9";
            label9.Size = new Size(107, 30);
            label9.TabIndex = 43;
            label9.Text = "IP Address";
            // 
            // systemtype
            // 
            systemtype.Location = new Point(12, 492);
            systemtype.Name = "systemtype";
            systemtype.ReadOnly = true;
            systemtype.Size = new Size(258, 23);
            systemtype.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 459);
            label8.Name = "label8";
            label8.Size = new Size(125, 30);
            label8.TabIndex = 41;
            label8.Text = "System Type";
            // 
            // systemmanufacturer
            // 
            systemmanufacturer.Location = new Point(12, 422);
            systemmanufacturer.Name = "systemmanufacturer";
            systemmanufacturer.ReadOnly = true;
            systemmanufacturer.Size = new Size(258, 23);
            systemmanufacturer.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 382);
            label7.Name = "label7";
            label7.Size = new Size(206, 30);
            label7.TabIndex = 39;
            label7.Text = "System Manufacturer";
            // 
            // systemmodel
            // 
            systemmodel.Location = new Point(12, 344);
            systemmodel.Name = "systemmodel";
            systemmodel.ReadOnly = true;
            systemmodel.Size = new Size(258, 23);
            systemmodel.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 311);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 37;
            label3.Text = "System Model";
            // 
            // extranotes
            // 
            extranotes.Location = new Point(519, 479);
            extranotes.Name = "extranotes";
            extranotes.Size = new Size(258, 23);
            extranotes.TabIndex = 50;
            // 
            // purchaseDate
            // 
            purchaseDate.Location = new Point(519, 382);
            purchaseDate.Name = "purchaseDate";
            purchaseDate.Size = new Size(258, 23);
            purchaseDate.TabIndex = 49;
            // 
            // employeeID
            // 
            employeeID.Location = new Point(519, 285);
            employeeID.Name = "employeeID";
            employeeID.Size = new Size(75, 23);
            employeeID.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(336, 472);
            label6.Name = "label6";
            label6.Size = new Size(161, 30);
            label6.TabIndex = 47;
            label6.Text = "Additional Notes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(336, 375);
            label5.Name = "label5";
            label5.Size = new Size(141, 30);
            label5.TabIndex = 46;
            label5.Text = "Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(336, 278);
            label4.Name = "label4";
            label4.Size = new Size(126, 30);
            label4.TabIndex = 45;
            label4.Text = "Employee ID";
            // 
            // savebutton
            // 
            savebutton.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            savebutton.Location = new Point(851, 236);
            savebutton.Name = "savebutton";
            savebutton.Padding = new Padding(10);
            savebutton.Size = new Size(242, 131);
            savebutton.TabIndex = 51;
            savebutton.Text = "Save Asset";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // homebtn
            // 
            homebtn.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            homebtn.Location = new Point(851, 422);
            homebtn.Name = "homebtn";
            homebtn.Padding = new Padding(10);
            homebtn.Size = new Size(242, 131);
            homebtn.TabIndex = 52;
            homebtn.Text = "Exit";
            homebtn.UseVisualStyleBackColor = true;
            homebtn.Click += homebtn_Click;
            // 
            // AddingAsset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 649);
            Controls.Add(homebtn);
            Controls.Add(savebutton);
            Controls.Add(extranotes);
            Controls.Add(purchaseDate);
            Controls.Add(employeeID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(systemIP);
            Controls.Add(label9);
            Controls.Add(systemtype);
            Controls.Add(label8);
            Controls.Add(systemmanufacturer);
            Controls.Add(label7);
            Controls.Add(systemmodel);
            Controls.Add(label3);
            Controls.Add(systemname);
            Controls.Add(label1);
            Controls.Add(assetID);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "AddingAsset";
            Text = "AddingAsset";
            Load += AddingAsset_Load;
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
        private Label label2;
        private TextBox assetID;
        private Label label1;
        private TextBox systemname;
        private TextBox systemIP;
        private Label label9;
        private TextBox systemtype;
        private Label label8;
        private TextBox systemmanufacturer;
        private Label label7;
        private TextBox systemmodel;
        private Label label3;
        private TextBox extranotes;
        private TextBox purchaseDate;
        private TextBox employeeID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button savebutton;
        private Button homebtn;
    }
}