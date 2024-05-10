namespace OOAD
{
    partial class DatabaseListForm
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
            this.listBoxDatabases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxDatabases
            // 
            this.listBoxDatabases.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxDatabases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.listBoxDatabases.FormattingEnabled = true;
            this.listBoxDatabases.ItemHeight = 29;
            this.listBoxDatabases.Location = new System.Drawing.Point(78, 46);
            this.listBoxDatabases.Name = "listBoxDatabases";
            this.listBoxDatabases.Size = new System.Drawing.Size(615, 352);
            this.listBoxDatabases.TabIndex = 0;
            // 
            // DatabaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxDatabases);
            this.Name = "DatabaseListForm";
            this.Text = "DatabaseListForm";
            this.Load += new System.EventHandler(this.DatabaseListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDatabases;
    }
}