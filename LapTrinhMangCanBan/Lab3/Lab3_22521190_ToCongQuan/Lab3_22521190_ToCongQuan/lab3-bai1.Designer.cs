namespace Lab3_22521190_ToCongQuan
{
    partial class flab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btClient = new System.Windows.Forms.Button();
            this.btServer = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // btClient
            // 
            this.btClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClient.Location = new System.Drawing.Point(112, 116);
            this.btClient.Name = "btClient";
            this.btClient.Size = new System.Drawing.Size(170, 55);
            this.btClient.TabIndex = 1;
            this.btClient.Text = "UDP Client";
            this.btClient.UseVisualStyleBackColor = false;
            this.btClient.Click += new System.EventHandler(this.btClient_Click);
            // 
            // btServer
            // 
            this.btServer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServer.Location = new System.Drawing.Point(495, 116);
            this.btServer.Name = "btServer";
            this.btServer.Size = new System.Drawing.Size(170, 55);
            this.btServer.TabIndex = 2;
            this.btServer.Text = "UDP Server";
            this.btServer.UseVisualStyleBackColor = false;
            this.btServer.Click += new System.EventHandler(this.btServer_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(12, 12);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(86, 31);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Exit";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // flab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 254);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btServer);
            this.Controls.Add(this.btClient);
            this.Controls.Add(this.label1);
            this.Name = "flab1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClient;
        private System.Windows.Forms.Button btServer;
        private System.Windows.Forms.Button btThoat;
    }
}