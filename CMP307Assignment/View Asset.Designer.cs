namespace CMP307Assignment
{
    partial class View_Asset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Asset));
            panel1 = new Panel();
            ats = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            AssetInfo = new ListBox();
            editasset = new Button();
            DeleteAsset = new Button();
            Exit = new Button();
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
            panel1.Size = new Size(1148, 130);
            panel1.TabIndex = 1;
            // 
            // ats
            // 
            ats.AutoSize = true;
            ats.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ats.ForeColor = SystemColors.ButtonFace;
            ats.Location = new Point(851, 44);
            ats.Name = "ats";
            ats.Size = new Size(216, 42);
            ats.TabIndex = 4;
            ats.Text = "Search Asset";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 144);
            label1.Name = "label1";
            label1.Size = new Size(285, 30);
            label1.TabIndex = 2;
            label1.Text = "Please Enter Asset ID Number ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            button1.Location = new Point(303, 147);
            button1.Name = "button1";
            button1.Padding = new Padding(10);
            button1.Size = new Size(131, 62);
            button1.TabIndex = 4;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // AssetInfo
            // 
            AssetInfo.FormattingEnabled = true;
            AssetInfo.ItemHeight = 15;
            AssetInfo.Location = new Point(12, 244);
            AssetInfo.Name = "AssetInfo";
            AssetInfo.Size = new Size(422, 274);
            AssetInfo.TabIndex = 5;
            // 
            // editasset
            // 
            editasset.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            editasset.Location = new Point(486, 419);
            editasset.Name = "editasset";
            editasset.Padding = new Padding(10);
            editasset.Size = new Size(162, 99);
            editasset.TabIndex = 20;
            editasset.Text = "Edit";
            editasset.UseVisualStyleBackColor = true;
            // 
            // DeleteAsset
            // 
            DeleteAsset.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            DeleteAsset.Location = new Point(825, 158);
            DeleteAsset.Name = "DeleteAsset";
            DeleteAsset.Padding = new Padding(10);
            DeleteAsset.Size = new Size(242, 131);
            DeleteAsset.TabIndex = 21;
            DeleteAsset.Text = "Delete Asset";
            DeleteAsset.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold);
            Exit.Location = new Point(825, 387);
            Exit.Name = "Exit";
            Exit.Padding = new Padding(10);
            Exit.Size = new Size(242, 131);
            Exit.TabIndex = 22;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // View_Asset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 550);
            Controls.Add(Exit);
            Controls.Add(DeleteAsset);
            Controls.Add(editasset);
            Controls.Add(AssetInfo);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "View_Asset";
            Text = "View_Asset";
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
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private ListBox AssetInfo;
        private Button editasset;
        private Button DeleteAsset;
        private Button Exit;
    }
}