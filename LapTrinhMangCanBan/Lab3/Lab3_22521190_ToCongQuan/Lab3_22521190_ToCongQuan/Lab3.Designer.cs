namespace Lab3_22521190_ToCongQuan
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
            this.bai1 = new System.Windows.Forms.Button();
            this.bai2 = new System.Windows.Forms.Button();
            this.bai3 = new System.Windows.Forms.Button();
            this.bai4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bai1
            // 
            this.bai1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bai1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai1.Location = new System.Drawing.Point(118, 78);
            this.bai1.Name = "bai1";
            this.bai1.Size = new System.Drawing.Size(186, 87);
            this.bai1.TabIndex = 0;
            this.bai1.Text = "Bài 1: Chat UDP";
            this.bai1.UseVisualStyleBackColor = false;
            this.bai1.Click += new System.EventHandler(this.bai1_Click);
            // 
            // bai2
            // 
            this.bai2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bai2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai2.Location = new System.Drawing.Point(453, 78);
            this.bai2.Name = "bai2";
            this.bai2.Size = new System.Drawing.Size(186, 87);
            this.bai2.TabIndex = 1;
            this.bai2.Text = "Bài 2: Telnet CMD";
            this.bai2.UseVisualStyleBackColor = false;
            this.bai2.Click += new System.EventHandler(this.bai2_Click);
            // 
            // bai3
            // 
            this.bai3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bai3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai3.Location = new System.Drawing.Point(118, 282);
            this.bai3.Name = "bai3";
            this.bai3.Size = new System.Drawing.Size(186, 87);
            this.bai3.TabIndex = 2;
            this.bai3.Text = "Bài 3: Chat TCP";
            this.bai3.UseVisualStyleBackColor = false;
            this.bai3.Click += new System.EventHandler(this.bai3_Click);
            // 
            // bai4
            // 
            this.bai4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bai4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bai4.Location = new System.Drawing.Point(453, 282);
            this.bai4.Name = "bai4";
            this.bai4.Size = new System.Drawing.Size(186, 87);
            this.bai4.TabIndex = 3;
            this.bai4.Text = "Bài 4: Multi chat";
            this.bai4.UseVisualStyleBackColor = false;
            this.bai4.Click += new System.EventHandler(this.bai4_Click);
            // 
            // flab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.bai4);
            this.Controls.Add(this.bai3);
            this.Controls.Add(this.bai2);
            this.Controls.Add(this.bai1);
            this.Name = "flab";
            this.Text = "Lab3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bai1;
        private System.Windows.Forms.Button bai2;
        private System.Windows.Forms.Button bai3;
        private System.Windows.Forms.Button bai4;
    }
}

