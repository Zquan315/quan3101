namespace WindowsFormsApp1
{
    partial class flab3
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
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbData
            // 
            this.rtbData.Enabled = false;
            this.rtbData.Location = new System.Drawing.Point(315, 66);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(424, 318);
            this.rtbData.TabIndex = 7;
            this.rtbData.Text = "";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(61, 313);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 71);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGhiFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiFile.Location = new System.Drawing.Point(61, 197);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(164, 71);
            this.btnGhiFile.TabIndex = 5;
            this.btnGhiFile.Text = "Ghi File";
            this.btnGhiFile.UseVisualStyleBackColor = false;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDocFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.Location = new System.Drawing.Point(61, 66);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(164, 71);
            this.btnDocFile.TabIndex = 4;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // flab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGhiFile);
            this.Controls.Add(this.btnDocFile);
            this.Name = "flab3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.Button btnDocFile;
    }
}