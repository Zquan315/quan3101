namespace Lab1_Bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flab2));
            tbn1 = new TextBox();
            tbn2 = new TextBox();
            tbn3 = new TextBox();
            lbn1 = new Label();
            lbn2 = new Label();
            lbn3 = new Label();
            btFind = new Button();
            btDel = new Button();
            btExi = new Button();
            lbMax = new Label();
            lbMin = new Label();
            min = new Label();
            max = new Label();
            maxnum = new Label();
            minNum = new Label();
            SuspendLayout();
            // 
            // tbn1
            // 
            tbn1.Location = new Point(214, 117);
            tbn1.Name = "tbn1";
            tbn1.Size = new Size(125, 27);
            tbn1.TabIndex = 0;
            // 
            // tbn2
            // 
            tbn2.Location = new Point(518, 117);
            tbn2.Name = "tbn2";
            tbn2.Size = new Size(125, 27);
            tbn2.TabIndex = 1;
            // 
            // tbn3
            // 
            tbn3.Location = new Point(855, 117);
            tbn3.Name = "tbn3";
            tbn3.Size = new Size(125, 27);
            tbn3.TabIndex = 2;
            // 
            // lbn1
            // 
            lbn1.AutoSize = true;
            lbn1.Location = new Point(122, 120);
            lbn1.Name = "lbn1";
            lbn1.Size = new Size(64, 20);
            lbn1.TabIndex = 3;
            lbn1.Text = "Số thứ 1";
            // 
            // lbn2
            // 
            lbn2.AutoSize = true;
            lbn2.Location = new Point(418, 124);
            lbn2.Name = "lbn2";
            lbn2.Size = new Size(64, 20);
            lbn2.TabIndex = 4;
            lbn2.Text = "Số thứ 2";
            // 
            // lbn3
            // 
            lbn3.AutoSize = true;
            lbn3.Location = new Point(769, 124);
            lbn3.Name = "lbn3";
            lbn3.Size = new Size(64, 20);
            lbn3.TabIndex = 5;
            lbn3.Text = "Số thứ 3";
            // 
            // btFind
            // 
            btFind.BackColor = SystemColors.ActiveCaption;
            btFind.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btFind.Location = new Point(214, 261);
            btFind.Name = "btFind";
            btFind.Size = new Size(94, 29);
            btFind.TabIndex = 6;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = false;
            btFind.Click += btFind_Click;
            // 
            // btDel
            // 
            btDel.BackColor = SystemColors.ActiveCaption;
            btDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btDel.Location = new Point(518, 261);
            btDel.Name = "btDel";
            btDel.Size = new Size(94, 29);
            btDel.TabIndex = 7;
            btDel.Text = "Xóa";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // btExi
            // 
            btExi.BackColor = SystemColors.ActiveCaption;
            btExi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btExi.Location = new Point(855, 261);
            btExi.Name = "btExi";
            btExi.Size = new Size(94, 29);
            btExi.TabIndex = 8;
            btExi.Text = "Thoát";
            btExi.UseVisualStyleBackColor = false;
            btExi.Click += btExi_Click;
            // 
            // lbMax
            // 
            lbMax.AutoSize = true;
            lbMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbMax.Location = new Point(367, 355);
            lbMax.Name = "lbMax";
            lbMax.Size = new Size(92, 20);
            lbMax.TabIndex = 9;
            lbMax.Text = "Số lớn nhất:";
            // 
            // lbMin
            // 
            lbMin.AutoSize = true;
            lbMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbMin.Location = new Point(721, 355);
            lbMin.Name = "lbMin";
            lbMin.Size = new Size(97, 20);
            lbMin.TabIndex = 10;
            lbMin.Text = "Số nhỏ nhất:";
            // 
            // min
            // 
            min.AutoSize = true;
            min.Location = new Point(845, 355);
            min.Name = "min";
            min.Size = new Size(0, 20);
            min.TabIndex = 12;
            // 
            // max
            // 
            max.AutoSize = true;
            max.Location = new Point(484, 355);
            max.Name = "max";
            max.Size = new Size(0, 20);
            max.TabIndex = 11;
            // 
            // maxnum
            // 
            maxnum.AutoSize = true;
            maxnum.Location = new Point(474, 355);
            maxnum.Name = "maxnum";
            maxnum.Size = new Size(0, 20);
            maxnum.TabIndex = 13;
            // 
            // minNum
            // 
            minNum.AutoSize = true;
            minNum.Location = new Point(835, 355);
            minNum.Name = "minNum";
            minNum.Size = new Size(0, 20);
            minNum.TabIndex = 14;
            // 
            // flab2
            // 
            AcceptButton = btFind;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1116, 450);
            Controls.Add(minNum);
            Controls.Add(maxnum);
            Controls.Add(min);
            Controls.Add(max);
            Controls.Add(lbMin);
            Controls.Add(lbMax);
            Controls.Add(btExi);
            Controls.Add(btDel);
            Controls.Add(btFind);
            Controls.Add(lbn3);
            Controls.Add(lbn2);
            Controls.Add(lbn1);
            Controls.Add(tbn3);
            Controls.Add(tbn2);
            Controls.Add(tbn1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "flab2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbn1;
        private TextBox tbn2;
        private TextBox tbn3;
        private Label lbn1;
        private Label lbn2;
        private Label lbn3;
        private Button btFind;
        private Button btDel;
        private Button btExi;
        private Label lbMax;
        private Label lbMin;
        private Label min;
        private Label max;
        private Label maxnum;
        private Label minNum;
    }
}