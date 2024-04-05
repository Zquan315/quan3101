namespace WindowsFormsApp1
{
    partial class flab5
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
            this.lvData = new System.Windows.Forms.ListView();
            this.btDuyet = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.NameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCreate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFile,
            this.Size,
            this.Extension,
            this.DateCreate});
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(12, 70);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(1196, 465);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // btDuyet
            // 
            this.btDuyet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDuyet.Location = new System.Drawing.Point(188, 555);
            this.btDuyet.Name = "btDuyet";
            this.btDuyet.Size = new System.Drawing.Size(114, 55);
            this.btDuyet.TabIndex = 1;
            this.btDuyet.Text = "Duyệt";
            this.btDuyet.UseVisualStyleBackColor = false;
            this.btDuyet.Click += new System.EventHandler(this.btDuyet_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThoat.Location = new System.Drawing.Point(769, 555);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(114, 55);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // NameFile
            // 
            this.NameFile.Text = "Tên File";
            this.NameFile.Width = 431;
            // 
            // Size
            // 
            this.Size.Text = "Kích thước";
            this.Size.Width = 119;
            // 
            // Extension
            // 
            this.Extension.Text = "Đuôi mở rộng";
            this.Extension.Width = 286;
            // 
            // DateCreate
            // 
            this.DateCreate.Text = "Ngày tạo";
            this.DateCreate.Width = 300;
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(160, 13);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(1048, 22);
            this.tbPath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đường dẫn Folder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDuyet);
            this.Controls.Add(this.lvData);
            this.Name = "flab5";
            this.Text = "Bài 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.Button btDuyet;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ColumnHeader NameFile;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Extension;
        private System.Windows.Forms.ColumnHeader DateCreate;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label1;
    }
}