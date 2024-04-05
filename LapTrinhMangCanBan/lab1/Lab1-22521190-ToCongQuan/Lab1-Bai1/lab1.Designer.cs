namespace Lab1_Bai1
{
    partial class flab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flab));
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            SuspendLayout();
            // 
            // b1
            // 
            b1.AutoSize = true;
            b1.BackColor = SystemColors.AppWorkspace;
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b1.Location = new Point(114, 89);
            b1.Name = "b1";
            b1.Size = new Size(225, 69);
            b1.TabIndex = 0;
            b1.Text = "Bài 1: Tính tổng hai số";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.BackColor = SystemColors.AppWorkspace;
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b2.Location = new Point(532, 89);
            b2.Name = "b2";
            b2.Size = new Size(217, 69);
            b2.TabIndex = 1;
            b2.Text = "Bài 2: Tìm Max, Min trong 3 số";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.BackColor = SystemColors.AppWorkspace;
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b3.Location = new Point(114, 221);
            b3.Name = "b3";
            b3.Size = new Size(225, 65);
            b3.TabIndex = 2;
            b3.Text = "Bài 3: Đọc số nguyên dương";
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.BackColor = SystemColors.AppWorkspace;
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b4.Location = new Point(532, 221);
            b4.Name = "b4";
            b4.Size = new Size(217, 65);
            b4.TabIndex = 3;
            b4.Text = "Bài 4: Đổi cơ số";
            b4.UseVisualStyleBackColor = false;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.BackColor = SystemColors.AppWorkspace;
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            b5.Location = new Point(114, 335);
            b5.Name = "b5";
            b5.Size = new Size(225, 67);
            b5.TabIndex = 4;
            b5.Text = "Bài 5: Quản lí điểm sinh viên";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // flab
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(900, 450);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "flab";
            Text = "Lab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
    }
}
