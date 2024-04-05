namespace Lab1_Bai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flab3));
            lbInput = new Label();
            input = new TextBox();
            lbOutput = new Label();
            label1 = new Label();
            btDoc = new Button();
            btXoa = new Button();
            btThoat = new Button();
            SuspendLayout();
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbInput.Location = new Point(105, 88);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(228, 20);
            lbInput.TabIndex = 0;
            lbInput.Text = "Nhập vào số nguyên(0-10000):";
            // 
            // input
            // 
            input.AcceptsTab = true;
            input.Location = new Point(354, 81);
            input.Name = "input";
            input.Size = new Size(204, 27);
            input.TabIndex = 1;
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbOutput.Location = new Point(105, 236);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(67, 20);
            lbOutput.TabIndex = 2;
            lbOutput.Text = "Kết quả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 281);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // btDoc
            // 
            btDoc.BackColor = SystemColors.ButtonShadow;
            btDoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btDoc.Location = new Point(584, 79);
            btDoc.Name = "btDoc";
            btDoc.Size = new Size(94, 29);
            btDoc.TabIndex = 4;
            btDoc.Text = "Đọc";
            btDoc.UseVisualStyleBackColor = false;
            btDoc.Click += btDoc_Click;
            // 
            // btXoa
            // 
            btXoa.BackColor = SystemColors.ControlDark;
            btXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btXoa.Location = new Point(584, 155);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(94, 29);
            btXoa.TabIndex = 5;
            btXoa.Text = "Xóa";
            btXoa.UseVisualStyleBackColor = false;
            btXoa.Click += btXoa_Click;
            // 
            // btThoat
            // 
            btThoat.BackColor = SystemColors.ControlDark;
            btThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btThoat.Location = new Point(584, 227);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 6;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // flab3
            // 
            AcceptButton = btDoc;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btThoat);
            Controls.Add(btXoa);
            Controls.Add(btDoc);
            Controls.Add(label1);
            Controls.Add(lbOutput);
            Controls.Add(input);
            Controls.Add(lbInput);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "flab3";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbInput;
        private TextBox input;
        private Label lbOutput;
        private Label label1;
        private Button btDoc;
        private Button btXoa;
        private Button btThoat;
    }
}