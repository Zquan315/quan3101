namespace Lab3_22521190_ToCongQuan
{
    partial class TCP_Server
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
            this.SuspendLayout();
            // 
            // lvReceive
            // 
            this.lvReceive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvReceive.HideSelection = false;
            this.lvReceive.Location = new System.Drawing.Point(39, 124);
            this.lvReceive.Name = "lvReceive";
            this.lvReceive.Size = new System.Drawing.Size(724, 292);
            this.lvReceive.TabIndex = 0;
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
            this.btListen.Location = new System.Drawing.Point(673, 59);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(90, 35);
            this.btListen.TabIndex = 1;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = false;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // TCP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btListen);
            this.Controls.Add(this.lvReceive);
            this.Name = "TCP_Server";
            this.Text = "TCP_Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvReceive;
        private System.Windows.Forms.Button btListen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}