namespace WindowsFormsApp1
{
    partial class flab4
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
            this.btnGhiFileIn = new System.Windows.Forms.Button();
            this.btnDocFileIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btGhiFileOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(53, 66);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(535, 318);
            this.rtbData.TabIndex = 11;
            this.rtbData.Text = "";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(53, 508);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 71);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhiFileIn
            // 
            this.btnGhiFileIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGhiFileIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiFileIn.Location = new System.Drawing.Point(424, 508);
            this.btnGhiFileIn.Name = "btnGhiFileIn";
            this.btnGhiFileIn.Size = new System.Drawing.Size(164, 71);
            this.btnGhiFileIn.TabIndex = 9;
            this.btnGhiFileIn.Text = "Ghi File Input.txt";
            this.btnGhiFileIn.UseVisualStyleBackColor = false;
            this.btnGhiFileIn.Click += new System.EventHandler(this.btnGhiFileIn_Click);
            // 
            // btnDocFileIn
            // 
            this.btnDocFileIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDocFileIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocFileIn.Location = new System.Drawing.Point(723, 508);
            this.btnDocFileIn.Name = "btnDocFileIn";
            this.btnDocFileIn.Size = new System.Drawing.Size(164, 71);
            this.btnDocFileIn.TabIndex = 8;
            this.btnDocFileIn.Text = "Đọc File Input.txt";
            this.btnDocFileIn.UseVisualStyleBackColor = false;
            this.btnDocFileIn.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Input";
            // 
            // btGhiFileOut
            // 
            this.btGhiFileOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btGhiFileOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGhiFileOut.Location = new System.Drawing.Point(1094, 508);
            this.btGhiFileOut.Name = "btGhiFileOut";
            this.btGhiFileOut.Size = new System.Drawing.Size(164, 71);
            this.btGhiFileOut.TabIndex = 15;
            this.btGhiFileOut.Text = "Ghi File Output.txt";
            this.btGhiFileOut.UseVisualStyleBackColor = false;
            this.btGhiFileOut.Click += new System.EventHandler(this.btGhiFileOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(952, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Output";
            // 
            // rtb_output
            // 
            this.rtb_output.Enabled = false;
            this.rtb_output.Location = new System.Drawing.Point(723, 66);
            this.rtb_output.Name = "rtb_output";
            this.rtb_output.Size = new System.Drawing.Size(535, 318);
            this.rtb_output.TabIndex = 12;
            this.rtb_output.Text = "";
            // 
            // flab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 635);
            this.Controls.Add(this.btGhiFileOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_output);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGhiFileIn);
            this.Controls.Add(this.btnDocFileIn);
            this.Name = "flab4";
            this.Text = "Bài 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnGhiFileIn;
        private System.Windows.Forms.Button btnDocFileIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGhiFileOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_output;
    }
}