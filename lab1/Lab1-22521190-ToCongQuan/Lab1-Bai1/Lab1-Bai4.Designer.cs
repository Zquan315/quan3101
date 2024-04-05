namespace Lab1_Bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flab4));
            lbIn = new Label();
            tbIn = new TextBox();
            cbb1 = new ComboBox();
            lbChon = new Label();
            lbSang = new Label();
            cbb2 = new ComboBox();
            btThucHien = new Button();
            btXoa = new Button();
            btThoat = new Button();
            lbkq = new Label();
            kq = new Label();
            SuspendLayout();
            // 
            // lbIn
            // 
            lbIn.AutoSize = true;
            lbIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbIn.Location = new Point(115, 139);
            lbIn.Name = "lbIn";
            lbIn.Size = new Size(104, 20);
            lbIn.TabIndex = 0;
            lbIn.Text = "Nhập một số:";
            // 
            // tbIn
            // 
            tbIn.Location = new Point(262, 132);
            tbIn.Name = "tbIn";
            tbIn.ScrollBars = ScrollBars.Vertical;
            tbIn.Size = new Size(444, 27);
            tbIn.TabIndex = 1;
            // 
            // cbb1
            // 
            cbb1.DisplayMember = "Binary";
            cbb1.FormattingEnabled = true;
            cbb1.Items.AddRange(new object[] { "Binary", "Decimal", "HexaDecimal" });
            cbb1.Location = new Point(262, 192);
            cbb1.Name = "cbb1";
            cbb1.Size = new Size(151, 28);
            cbb1.TabIndex = 2;
            // 
            // lbChon
            // 
            lbChon.AutoSize = true;
            lbChon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbChon.Location = new Point(115, 200);
            lbChon.Name = "lbChon";
            lbChon.Size = new Size(49, 20);
            lbChon.TabIndex = 3;
            lbChon.Text = "Chọn:";
            // 
            // lbSang
            // 
            lbSang.AutoSize = true;
            lbSang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSang.Location = new Point(456, 200);
            lbSang.Name = "lbSang";
            lbSang.Size = new Size(47, 20);
            lbSang.TabIndex = 4;
            lbSang.Text = "Sang:";
            // 
            // cbb2
            // 
            cbb2.FormattingEnabled = true;
            cbb2.Items.AddRange(new object[] { "Binary", "Decimal", "HexaDecimal" });
            cbb2.Location = new Point(555, 192);
            cbb2.Name = "cbb2";
            cbb2.Size = new Size(151, 28);
            cbb2.TabIndex = 5;
            // 
            // btThucHien
            // 
            btThucHien.BackColor = SystemColors.ControlDark;
            btThucHien.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 255);
            btThucHien.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btThucHien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btThucHien.Location = new Point(262, 241);
            btThucHien.Name = "btThucHien";
            btThucHien.Size = new Size(444, 39);
            btThucHien.TabIndex = 6;
            btThucHien.Text = "Thực hiện";
            btThucHien.UseVisualStyleBackColor = false;
            btThucHien.Click += btThucHien_Click;
            // 
            // btXoa
            // 
            btXoa.BackColor = SystemColors.ControlDark;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXoa.Location = new Point(262, 385);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 7;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btThoat
            // 
            btThoat.BackColor = SystemColors.ControlDark;
            btThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btThoat.Location = new Point(612, 385);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // lbkq
            // 
            lbkq.AutoSize = true;
            lbkq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbkq.Location = new Point(115, 319);
            lbkq.Name = "lbkq";
            lbkq.Size = new Size(67, 20);
            lbkq.TabIndex = 10;
            lbkq.Text = "Kết quả:";
            // 
            // kq
            // 
            kq.AutoSize = true;
            kq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            kq.Location = new Point(262, 319);
            kq.Name = "kq";
            kq.Size = new Size(0, 20);
            kq.TabIndex = 11;
            // 
            // flab4
            // 
            AcceptButton = btThucHien;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(kq);
            Controls.Add(lbkq);
            Controls.Add(btThoat);
            Controls.Add(btXoa);
            Controls.Add(btThucHien);
            Controls.Add(cbb2);
            Controls.Add(lbSang);
            Controls.Add(lbChon);
            Controls.Add(cbb1);
            Controls.Add(tbIn);
            Controls.Add(lbIn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "flab4";
            Text = "Bài 4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIn;
        private TextBox tbIn;
        private ComboBox cbb1;
        private Label lbChon;
        private Label lbSang;
        private ComboBox cbb2;
        private Button btThucHien;
        private Button btXoa;
        private Button btThoat;
        private Label lbkq;
        private Label kq;
    }
}