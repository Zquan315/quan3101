namespace Lab3_22521190_ToCongQuan
{
    partial class UDP_Server_bai1
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
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btListen = new System.Windows.Forms.Button();
            this.lvReceive = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbPort
            // 
            this.tbPort.Enabled = false;
            this.tbPort.Location = new System.Drawing.Point(94, 100);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(153, 22);
            this.tbPort.TabIndex = 0;
            this.tbPort.Text = "8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // btListen
            // 
            this.btListen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btListen.Location = new System.Drawing.Point(638, 91);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(88, 32);
            this.btListen.TabIndex = 3;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = false;
            // 
            // lvReceive
            // 
            this.lvReceive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvReceive.HideSelection = false;
            this.lvReceive.Location = new System.Drawing.Point(94, 163);
            this.lvReceive.Name = "lvReceive";
            this.lvReceive.Size = new System.Drawing.Size(639, 263);
            this.lvReceive.TabIndex = 4;
            this.lvReceive.UseCompatibleStateImageBehavior = false;
            this.lvReceive.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Receive message";
            this.columnHeader1.Width = 600;
            // 
            // UDP_Server_bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvReceive);
            this.Controls.Add(this.btListen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPort);
            this.Name = "UDP_Server_bai1";
            this.Text = "UDP_Server";
            this.Load += new System.EventHandler(this.UDP_Server_bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.ListView lvReceive;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}