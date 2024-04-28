namespace Lab3_22521190_ToCongQuan
{
    partial class Bai4_server
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
            this.btListen = new System.Windows.Forms.Button();
            this.lvMess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btListen
            // 
            this.btListen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListen.Location = new System.Drawing.Point(701, 56);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(87, 37);
            this.btListen.TabIndex = 0;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = false;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // lvMess
            // 
            this.lvMess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvMess.HideSelection = false;
            this.lvMess.Location = new System.Drawing.Point(12, 99);
            this.lvMess.Name = "lvMess";
            this.lvMess.Size = new System.Drawing.Size(776, 325);
            this.lvMess.TabIndex = 1;
            this.lvMess.UseCompatibleStateImageBehavior = false;
            this.lvMess.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Message receive";
            this.columnHeader1.Width = 730;
            // 
            // Bai4_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvMess);
            this.Controls.Add(this.btListen);
            this.Name = "Bai4_server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.ListView lvMess;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}