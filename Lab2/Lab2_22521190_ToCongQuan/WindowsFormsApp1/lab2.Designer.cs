namespace WindowsFormsApp1
{
    partial class flab
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
            this.btnBai1 = new System.Windows.Forms.Button();
            this.btnBai2 = new System.Windows.Forms.Button();
            this.btnBai3 = new System.Windows.Forms.Button();
            this.btnBai4 = new System.Windows.Forms.Button();
            this.btnBai5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai1
            // 
            this.btnBai1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai1.Location = new System.Drawing.Point(109, 88);
            this.btnBai1.Name = "btnBai1";
            this.btnBai1.Size = new System.Drawing.Size(215, 85);
            this.btnBai1.TabIndex = 0;
            this.btnBai1.Text = "Bài 1: Ghi và đọc file";
            this.btnBai1.UseVisualStyleBackColor = false;
            this.btnBai1.Click += new System.EventHandler(this.btnBai1_Click);
            // 
            // btnBai2
            // 
            this.btnBai2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai2.Location = new System.Drawing.Point(442, 88);
            this.btnBai2.Name = "btnBai2";
            this.btnBai2.Size = new System.Drawing.Size(218, 85);
            this.btnBai2.TabIndex = 1;
            this.btnBai2.Text = "Bài 2: Đọc thông tin một file .txt";
            this.btnBai2.UseVisualStyleBackColor = false;
            this.btnBai2.Click += new System.EventHandler(this.btnBai2_Click);
            // 
            // btnBai3
            // 
            this.btnBai3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai3.Location = new System.Drawing.Point(109, 198);
            this.btnBai3.Name = "btnBai3";
            this.btnBai3.Size = new System.Drawing.Size(215, 96);
            this.btnBai3.TabIndex = 2;
            this.btnBai3.Text = "Bài 3: Đọc và ghi file (mở rộng)";
            this.btnBai3.UseVisualStyleBackColor = false;
            this.btnBai3.Click += new System.EventHandler(this.btnBai3_Click);
            // 
            // btnBai4
            // 
            this.btnBai4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai4.Location = new System.Drawing.Point(442, 198);
            this.btnBai4.Name = "btnBai4";
            this.btnBai4.Size = new System.Drawing.Size(218, 96);
            this.btnBai4.TabIndex = 3;
            this.btnBai4.Text = "Bài 4: Đọc và ghi file sử dụng BinaryFormater";
            this.btnBai4.UseVisualStyleBackColor = false;
            this.btnBai4.Click += new System.EventHandler(this.btnBai4_Click);
            // 
            // btnBai5
            // 
            this.btnBai5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBai5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai5.Location = new System.Drawing.Point(109, 318);
            this.btnBai5.Name = "btnBai5";
            this.btnBai5.Size = new System.Drawing.Size(215, 81);
            this.btnBai5.TabIndex = 4;
            this.btnBai5.Text = "Bài 5: Duyệt thư mục";
            this.btnBai5.UseVisualStyleBackColor = false;
            this.btnBai5.Click += new System.EventHandler(this.btnBai5_Click);
            // 
            // flab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBai5);
            this.Controls.Add(this.btnBai4);
            this.Controls.Add(this.btnBai3);
            this.Controls.Add(this.btnBai2);
            this.Controls.Add(this.btnBai1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "flab";
            this.Text = "Lab2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btnBai2;
        private System.Windows.Forms.Button btnBai3;
        private System.Windows.Forms.Button btnBai4;
        private System.Windows.Forms.Button btnBai5;
    }
}

