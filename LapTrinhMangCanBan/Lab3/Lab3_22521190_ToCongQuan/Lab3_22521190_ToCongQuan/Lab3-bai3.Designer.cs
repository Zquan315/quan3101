namespace Lab3_22521190_ToCongQuan
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
            this.bt_SV = new System.Windows.Forms.Button();
            this.bt_CL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_SV
            // 
            this.bt_SV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SV.Location = new System.Drawing.Point(146, 91);
            this.bt_SV.Name = "bt_SV";
            this.bt_SV.Size = new System.Drawing.Size(453, 34);
            this.bt_SV.TabIndex = 0;
            this.bt_SV.Text = "Open TCP Server";
            this.bt_SV.UseVisualStyleBackColor = false;
            this.bt_SV.Click += new System.EventHandler(this.bt_SV_Click);
            // 
            // bt_CL
            // 
            this.bt_CL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_CL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CL.Location = new System.Drawing.Point(146, 151);
            this.bt_CL.Name = "bt_CL";
            this.bt_CL.Size = new System.Drawing.Size(453, 34);
            this.bt_CL.TabIndex = 1;
            this.bt_CL.Text = "Open TCP Client";
            this.bt_CL.UseVisualStyleBackColor = false;
            this.bt_CL.Click += new System.EventHandler(this.bt_CL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "DashBoard";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Location = new System.Drawing.Point(13, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 242);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_CL);
            this.Controls.Add(this.bt_SV);
            this.Name = "flab3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_SV;
        private System.Windows.Forms.Button bt_CL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}