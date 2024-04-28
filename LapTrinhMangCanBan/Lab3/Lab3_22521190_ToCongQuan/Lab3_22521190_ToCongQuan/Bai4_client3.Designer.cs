namespace Lab3_22521190_ToCongQuan
{
    partial class Client3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.rtbMess = new System.Windows.Forms.RichTextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lvMess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btDisconnect = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Your name";
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Location = new System.Drawing.Point(713, 104);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 52);
            this.btSend.TabIndex = 15;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // rtbMess
            // 
            this.rtbMess.Location = new System.Drawing.Point(12, 104);
            this.rtbMess.Name = "rtbMess";
            this.rtbMess.Size = new System.Drawing.Size(694, 52);
            this.rtbMess.TabIndex = 14;
            this.rtbMess.Text = "";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(178, 22);
            this.tbName.TabIndex = 13;
            // 
            // lvMess
            // 
            this.lvMess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvMess.HideSelection = false;
            this.lvMess.Location = new System.Drawing.Point(12, 184);
            this.lvMess.Name = "lvMess";
            this.lvMess.Size = new System.Drawing.Size(776, 254);
            this.lvMess.TabIndex = 12;
            this.lvMess.UseCompatibleStateImageBehavior = false;
            this.lvMess.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Message receive";
            this.columnHeader1.Width = 720;
            // 
            // btDisconnect
            // 
            this.btDisconnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDisconnect.Location = new System.Drawing.Point(692, 53);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(96, 34);
            this.btDisconnect.TabIndex = 19;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = false;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConnect.Location = new System.Drawing.Point(692, 12);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(96, 34);
            this.btConnect.TabIndex = 18;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // Client3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.rtbMess);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lvMess);
            this.Name = "Client3";
            this.Text = "Client 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.cl3_close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.RichTextBox rtbMess;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListView lvMess;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}