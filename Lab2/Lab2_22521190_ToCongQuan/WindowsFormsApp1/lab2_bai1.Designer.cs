namespace WindowsFormsApp1
{
    partial class flab1
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnGhiFile = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDocFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.Location = new System.Drawing.Point(92, 87);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(164, 71);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnGhiFile
            // 
            this.btnGhiFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGhiFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiFile.Location = new System.Drawing.Point(92, 218);
            this.btnGhiFile.Name = "btnGhiFile";
            this.btnGhiFile.Size = new System.Drawing.Size(164, 71);
            this.btnGhiFile.TabIndex = 1;
            this.btnGhiFile.Text = "Ghi File";
            this.btnGhiFile.UseVisualStyleBackColor = false;
            this.btnGhiFile.Click += new System.EventHandler(this.btnGhiFile_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(92, 334);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 71);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rtbData
            // 
            this.rtbData.Enabled = false;
            this.rtbData.Location = new System.Drawing.Point(346, 87);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(424, 318);
            this.rtbData.TabIndex = 3;
            this.rtbData.Text = "";
            // 
            // flab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGhiFile);
            this.Controls.Add(this.btnDocFile);
            this.Name = "flab1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnGhiFile;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RichTextBox rtbData;
    }
}