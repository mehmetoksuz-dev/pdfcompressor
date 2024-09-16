namespace PdfMinifier
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            btnSourceFolder = new Button();
            btnTargetFolder = new Button();
            btnStart = new Button();
            label3 = new Label();
            txtQuality = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 48);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Pdf Source Folder :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 83);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 0;
            label2.Text = "Compressed Target Folder : ";
            // 
            // btnSourceFolder
            // 
            btnSourceFolder.Location = new Point(135, 44);
            btnSourceFolder.Name = "btnSourceFolder";
            btnSourceFolder.Size = new Size(138, 23);
            btnSourceFolder.TabIndex = 1;
            btnSourceFolder.Text = "Pdf Dosya Yolu";
            btnSourceFolder.UseVisualStyleBackColor = true;
            btnSourceFolder.Click += btnSourceFolder_Click;
            // 
            // btnTargetFolder
            // 
            btnTargetFolder.Location = new Point(182, 79);
            btnTargetFolder.Name = "btnTargetFolder";
            btnTargetFolder.Size = new Size(150, 23);
            btnTargetFolder.TabIndex = 2;
            btnTargetFolder.Text = "Kayıt Edilecek Dosya Yolu";
            btnTargetFolder.UseVisualStyleBackColor = true;
            btnTargetFolder.Click += btnTargetFolder_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(123, 182);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 134);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 0;
            label3.Text = "Compress Quality";
            // 
            // txtQuality
            // 
            txtQuality.Location = new Point(151, 131);
            txtQuality.Name = "txtQuality";
            txtQuality.Size = new Size(100, 23);
            txtQuality.TabIndex = 3;
            txtQuality.Text = "60";
            txtQuality.KeyPress += txtQuality_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 232);
            Controls.Add(txtQuality);
            Controls.Add(btnStart);
            Controls.Add(btnTargetFolder);
            Controls.Add(btnSourceFolder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnSourceFolder;
        private Button btnTargetFolder;
        private Button btnStart;
        private Label label3;
        private TextBox txtQuality;
    }
}
