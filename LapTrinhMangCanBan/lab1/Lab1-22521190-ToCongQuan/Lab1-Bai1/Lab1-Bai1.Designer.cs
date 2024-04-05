namespace Lab1
{
    partial class flab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flab1));
            n1 = new TextBox();
            n2 = new TextBox();
            st1 = new Label();
            st2 = new Label();
            HthiKqua = new Label();
            btsum = new Button();
            btdel = new Button();
            btexit = new Button();
            kq = new Label();
            SuspendLayout();
            // 
            // n1
            // 
            n1.Location = new Point(265, 115);
            n1.Name = "n1";
            n1.Size = new Size(294, 27);
            n1.TabIndex = 0;
            // 
            // n2
            // 
            n2.Location = new Point(265, 199);
            n2.Name = "n2";
            n2.Size = new Size(294, 27);
            n2.TabIndex = 1;
            // 
            // st1
            // 
            st1.AutoSize = true;
            st1.BackColor = SystemColors.ButtonFace;
            st1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            st1.Location = new Point(161, 122);
            st1.Name = "st1";
            st1.Size = new Size(68, 20);
            st1.TabIndex = 2;
            st1.Text = "Số thứ 1";
            // 
            // st2
            // 
            st2.AutoSize = true;
            st2.BackColor = SystemColors.ButtonFace;
            st2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            st2.Location = new Point(161, 206);
            st2.Name = "st2";
            st2.Size = new Size(68, 20);
            st2.TabIndex = 3;
            st2.Text = "Số thứ 2";
            // 
            // HthiKqua
            // 
            HthiKqua.AutoSize = true;
            HthiKqua.BackColor = SystemColors.ButtonFace;
            HthiKqua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            HthiKqua.Location = new Point(161, 288);
            HthiKqua.Name = "HthiKqua";
            HthiKqua.Size = new Size(67, 20);
            HthiKqua.TabIndex = 4;
            HthiKqua.Text = "Kết quả:";
            // 
            // btsum
            // 
            btsum.BackColor = SystemColors.ActiveCaption;
            btsum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btsum.ForeColor = SystemColors.ActiveCaptionText;
            btsum.Location = new Point(161, 363);
            btsum.Name = "btsum";
            btsum.Size = new Size(94, 29);
            btsum.TabIndex = 6;
            btsum.Text = "Tính tổng";
            btsum.UseVisualStyleBackColor = false;
            btsum.Click += btsum_Click;
            // 
            // btdel
            // 
            btdel.BackColor = SystemColors.ActiveCaption;
            btdel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btdel.Location = new Point(327, 363);
            btdel.Name = "btdel";
            btdel.Size = new Size(94, 29);
            btdel.TabIndex = 7;
            btdel.Text = "Xóa";
            btdel.UseVisualStyleBackColor = false;
            btdel.Click += btdel_Click;
            // 
            // btexit
            // 
            btexit.BackColor = SystemColors.ActiveCaption;
            btexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btexit.Location = new Point(483, 363);
            btexit.Name = "btexit";
            btexit.Size = new Size(94, 29);
            btexit.TabIndex = 8;
            btexit.Text = "Thoát";
            btexit.UseVisualStyleBackColor = false;
            btexit.Click += btexit_Click;
            // 
            // kq
            // 
            kq.AutoSize = true;
            kq.BackColor = SystemColors.ButtonFace;
            kq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            kq.Location = new Point(265, 288);
            kq.Name = "kq";
            kq.Size = new Size(0, 20);
            kq.TabIndex = 9;
            // 
            // flab1
            // 
            AcceptButton = btsum;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(kq);
            Controls.Add(btexit);
            Controls.Add(btdel);
            Controls.Add(btsum);
            Controls.Add(HthiKqua);
            Controls.Add(st2);
            Controls.Add(st1);
            Controls.Add(n2);
            Controls.Add(n1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "flab1";
            Text = "Bài 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox n1;
        private TextBox n2;
        private Label st1;
        private Label st2;
        private Label HthiKqua;
        private Button btsum;
        private Button btdel;
        private Button btexit;
        private Label kq;
    }
}
