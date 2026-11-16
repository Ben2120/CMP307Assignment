namespace CMP307Assignment
{
    partial class ViewSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSoftware));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            Exit = new Button();
            DeleteSoftware = new Button();
            editsoftware = new Button();
            SoftwareInfo = new ListBox();
            searchsoftware = new Button();
            assetName = new TextBox();
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
            panel1.Size = new Size(1134, 130);
            panel1.TabIndex = 2;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(803, 44);
            ats.Name = "ats";
            ats.Size = new Size(275, 42);
            ats.TabIndex = 4;
            ats.Text = "Search Software";
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
            // Exit
            // 
            Exit.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            Exit.Location = new Point(836, 402);
            Exit.Name = "Exit";
            Exit.Padding = new Padding(10);
            Exit.Size = new Size(242, 131);
            Exit.TabIndex = 29;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // DeleteSoftware
            // 
            DeleteSoftware.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            DeleteSoftware.Location = new Point(836, 173);
            DeleteSoftware.Name = "DeleteSoftware";
            DeleteSoftware.Padding = new Padding(10);
            DeleteSoftware.Size = new Size(242, 131);
            DeleteSoftware.TabIndex = 28;
            DeleteSoftware.Text = "Delete Software";
            DeleteSoftware.UseVisualStyleBackColor = true;
            // 
            // editsoftware
            // 
            editsoftware.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            editsoftware.Location = new Point(486, 465);
            editsoftware.Name = "editsoftware";
            editsoftware.Padding = new Padding(10);
            editsoftware.Size = new Size(162, 99);
            editsoftware.TabIndex = 27;
            editsoftware.Text = "Edit";
            editsoftware.UseVisualStyleBackColor = true;
            // 
            // SoftwareInfo
            // 
            SoftwareInfo.FormattingEnabled = true;
            SoftwareInfo.ItemHeight = 15;
            SoftwareInfo.Location = new Point(12, 290);
            SoftwareInfo.Name = "SoftwareInfo";
            SoftwareInfo.Size = new Size(422, 274);
            SoftwareInfo.TabIndex = 26;
            // 
            // searchsoftware
            // 
            searchsoftware.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            searchsoftware.Location = new Point(377, 156);
            searchsoftware.Name = "searchsoftware";
            searchsoftware.Padding = new Padding(10);
            searchsoftware.Size = new Size(131, 62);
            searchsoftware.TabIndex = 25;
            searchsoftware.Text = "Search";
            searchsoftware.UseVisualStyleBackColor = true;
            // 
            // assetName
            // 
            assetName.Location = new Point(12, 195);
            assetName.Name = "assetName";
            assetName.Size = new Size(310, 23);
            assetName.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 153);
            label1.Name = "label1";
            label1.Size = new Size(349, 30);
            label1.TabIndex = 23;
            label1.Text = "Please Enter Operating System Name ";
            // 
            // ViewSoftware
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 610);
            Controls.Add(Exit);
            Controls.Add(DeleteSoftware);
            Controls.Add(editsoftware);
            Controls.Add(SoftwareInfo);
            Controls.Add(searchsoftware);
            Controls.Add(assetName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ViewSoftware";
            Text = "ViewSoftware";
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
        private Button Exit;
        private Button DeleteSoftware;
        private Button editsoftware;
        private ListBox SoftwareInfo;
        private Button searchsoftware;
        private TextBox assetName;
        private Label label1;
    }
}