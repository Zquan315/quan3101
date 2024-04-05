namespace WindowsFormsApp1
{
    partial class flab2
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
            this.tbTenFile = new System.Windows.Forms.TextBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.TbSokyTu = new System.Windows.Forms.TextBox();
            this.tbSoTu = new System.Windows.Forms.TextBox();
            this.tbSoDong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDocFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFile.Location = new System.Drawing.Point(54, 45);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(158, 74);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // tbTenFile
            // 
            this.tbTenFile.Enabled = false;
            this.tbTenFile.Location = new System.Drawing.Point(129, 156);
            this.tbTenFile.Name = "tbTenFile";
            this.tbTenFile.Size = new System.Drawing.Size(249, 22);
            this.tbTenFile.TabIndex = 1;
            // 
            // rtbData
            // 
            this.rtbData.Enabled = false;
            this.rtbData.Location = new System.Drawing.Point(403, 45);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(385, 393);
            this.rtbData.TabIndex = 2;
            this.rtbData.Text = "";
            // 
            // tbUrl
            // 
            this.tbUrl.Enabled = false;
            this.tbUrl.Location = new System.Drawing.Point(129, 210);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(249, 22);
            this.tbUrl.TabIndex = 3;
            // 
            // TbSokyTu
            // 
            this.TbSokyTu.Enabled = false;
            this.TbSokyTu.Location = new System.Drawing.Point(129, 364);
            this.TbSokyTu.Name = "TbSokyTu";
            this.TbSokyTu.Size = new System.Drawing.Size(249, 22);
            this.TbSokyTu.TabIndex = 4;
            // 
            // tbSoTu
            // 
            this.tbSoTu.Enabled = false;
            this.tbSoTu.Location = new System.Drawing.Point(129, 312);
            this.tbSoTu.Name = "tbSoTu";
            this.tbSoTu.Size = new System.Drawing.Size(249, 22);
            this.tbSoTu.TabIndex = 5;
            // 
            // tbSoDong
            // 
            this.tbSoDong.Enabled = false;
            this.tbSoDong.Location = new System.Drawing.Point(129, 262);
            this.tbSoDong.Name = "tbSoDong";
            this.tbSoDong.Size = new System.Drawing.Size(249, 22);
            this.tbSoDong.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số dòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số ký tự";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(230, 45);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 74);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // flab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSoDong);
            this.Controls.Add(this.tbSoTu);
            this.Controls.Add(this.TbSokyTu);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.tbTenFile);
            this.Controls.Add(this.btnDocFile);
            this.Name = "flab2";
            this.Text = "Bài 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.TextBox tbTenFile;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox TbSokyTu;
        private System.Windows.Forms.TextBox tbSoTu;
        private System.Windows.Forms.TextBox tbSoDong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnThoat;
    }
}