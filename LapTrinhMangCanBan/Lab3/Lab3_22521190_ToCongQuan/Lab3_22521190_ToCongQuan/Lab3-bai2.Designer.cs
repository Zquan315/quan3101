namespace Lab3_22521190_ToCongQuan
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
            this.components = new System.ComponentModel.Container();
            this.lvReceive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btListen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvReceive
            // 
            this.lvReceive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvReceive.HideSelection = false;
            this.lvReceive.Location = new System.Drawing.Point(38, 112);
            this.lvReceive.Name = "lvReceive";
            this.lvReceive.Size = new System.Drawing.Size(724, 292);
            this.lvReceive.TabIndex = 2;
            this.lvReceive.UseCompatibleStateImageBehavior = false;
            this.lvReceive.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Receive message";
            this.columnHeader1.Width = 714;
            // 
            // btListen
            // 
            this.btListen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btListen.Location = new System.Drawing.Point(672, 47);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(90, 35);
            this.btListen.TabIndex = 3;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = false;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThoat.Location = new System.Drawing.Point(38, 12);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(71, 27);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Exit";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // flab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.lvReceive);
            this.Controls.Add(this.btListen);
            this.Name = "flab2";
            this.Text = "Bài 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.bai2_close);
            this.Load += new System.EventHandler(this.flab2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvReceive;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btListen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btThoat;
    }
}