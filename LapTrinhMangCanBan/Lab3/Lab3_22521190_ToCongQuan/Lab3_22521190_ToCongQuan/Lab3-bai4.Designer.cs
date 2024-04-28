namespace Lab3_22521190_ToCongQuan
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
            this.btServer = new System.Windows.Forms.Button();
            this.btCl1 = new System.Windows.Forms.Button();
            this.btCl2 = new System.Windows.Forms.Button();
            this.btCl3 = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btServer
            // 
            this.btServer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btServer.Location = new System.Drawing.Point(175, 86);
            this.btServer.Name = "btServer";
            this.btServer.Size = new System.Drawing.Size(458, 39);
            this.btServer.TabIndex = 0;
            this.btServer.Text = "Open Server";
            this.btServer.UseVisualStyleBackColor = false;
            this.btServer.Click += new System.EventHandler(this.btServer_Click);
            // 
            // btCl1
            // 
            this.btCl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCl1.Location = new System.Drawing.Point(175, 160);
            this.btCl1.Name = "btCl1";
            this.btCl1.Size = new System.Drawing.Size(458, 39);
            this.btCl1.TabIndex = 1;
            this.btCl1.Text = "Open Client 1";
            this.btCl1.UseVisualStyleBackColor = false;
            this.btCl1.Click += new System.EventHandler(this.btCl1_Click);
            // 
            // btCl2
            // 
            this.btCl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCl2.Location = new System.Drawing.Point(175, 242);
            this.btCl2.Name = "btCl2";
            this.btCl2.Size = new System.Drawing.Size(458, 39);
            this.btCl2.TabIndex = 2;
            this.btCl2.Text = "Open Client 2";
            this.btCl2.UseVisualStyleBackColor = false;
            this.btCl2.Click += new System.EventHandler(this.btCl2_Click);
            // 
            // btCl3
            // 
            this.btCl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCl3.Location = new System.Drawing.Point(175, 324);
            this.btCl3.Name = "btCl3";
            this.btCl3.Size = new System.Drawing.Size(458, 39);
            this.btCl3.TabIndex = 3;
            this.btCl3.Text = "Open Client 3";
            this.btCl3.UseVisualStyleBackColor = false;
            this.btCl3.Click += new System.EventHandler(this.btCl3_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btExit.Location = new System.Drawing.Point(13, 13);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // flab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCl3);
            this.Controls.Add(this.btCl2);
            this.Controls.Add(this.btCl1);
            this.Controls.Add(this.btServer);
            this.Name = "flab4";
            this.Text = "Bài 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btServer;
        private System.Windows.Forms.Button btCl1;
        private System.Windows.Forms.Button btCl2;
        private System.Windows.Forms.Button btCl3;
        private System.Windows.Forms.Button btExit;
    }
}