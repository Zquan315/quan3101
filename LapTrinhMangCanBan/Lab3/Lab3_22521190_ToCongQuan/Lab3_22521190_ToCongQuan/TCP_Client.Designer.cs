namespace Lab3_22521190_ToCongQuan
{
    partial class TCP_Client
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
            this.label3 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.rtbMess = new System.Windows.Forms.RichTextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Message";
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btSend.Location = new System.Drawing.Point(626, 58);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(96, 34);
            this.btSend.TabIndex = 12;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // rtbMess
            // 
            this.rtbMess.Location = new System.Drawing.Point(61, 111);
            this.rtbMess.Name = "rtbMess";
            this.rtbMess.Size = new System.Drawing.Size(661, 299);
            this.rtbMess.TabIndex = 11;
            this.rtbMess.Text = "";
            // 
            // btConnect
            // 
            this.btConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btConnect.Location = new System.Drawing.Point(362, 58);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(96, 34);
            this.btConnect.TabIndex = 14;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = false;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDisconnect.Location = new System.Drawing.Point(493, 58);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(96, 34);
            this.btDisconnect.TabIndex = 15;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = false;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // TCP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.rtbMess);
            this.Name = "TCP_Client";
            this.Text = "TCP_Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.RichTextBox rtbMess;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btDisconnect;
    }
}