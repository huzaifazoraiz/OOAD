namespace OOAD
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnectLocal = new System.Windows.Forms.Button();
            this.btnConnectRemote = new System.Windows.Forms.Button();
            this.cboServerIP = new System.Windows.Forms.ComboBox();
            this.cboServerName = new System.Windows.Forms.ComboBox();
            this.cboUsername = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(109, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(109, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(109, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(109, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(292, 297);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(240, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // btnConnectLocal
            // 
            this.btnConnectLocal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConnectLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnConnectLocal.Location = new System.Drawing.Point(66, 383);
            this.btnConnectLocal.Name = "btnConnectLocal";
            this.btnConnectLocal.Size = new System.Drawing.Size(239, 34);
            this.btnConnectLocal.TabIndex = 8;
            this.btnConnectLocal.Text = "Connect Local";
            this.btnConnectLocal.UseVisualStyleBackColor = false;
            this.btnConnectLocal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConnectRemote
            // 
            this.btnConnectRemote.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnConnectRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnConnectRemote.Location = new System.Drawing.Point(372, 383);
            this.btnConnectRemote.Name = "btnConnectRemote";
            this.btnConnectRemote.Size = new System.Drawing.Size(277, 34);
            this.btnConnectRemote.TabIndex = 9;
            this.btnConnectRemote.Text = "Connect Remotely";
            this.btnConnectRemote.UseVisualStyleBackColor = false;
            this.btnConnectRemote.Click += new System.EventHandler(this.btnConnectRemote_Click_1);
            // 
            // cboServerIP
            // 
            this.cboServerIP.FormattingEnabled = true;
            this.cboServerIP.Location = new System.Drawing.Point(292, 76);
            this.cboServerIP.Name = "cboServerIP";
            this.cboServerIP.Size = new System.Drawing.Size(240, 24);
            this.cboServerIP.TabIndex = 10;
            // 
            // cboServerName
            // 
            this.cboServerName.FormattingEnabled = true;
            this.cboServerName.Location = new System.Drawing.Point(292, 142);
            this.cboServerName.Name = "cboServerName";
            this.cboServerName.Size = new System.Drawing.Size(240, 24);
            this.cboServerName.TabIndex = 11;
            // 
            // cboUsername
            // 
            this.cboUsername.FormattingEnabled = true;
            this.cboUsername.Location = new System.Drawing.Point(292, 222);
            this.cboUsername.Name = "cboUsername";
            this.cboUsername.Size = new System.Drawing.Size(240, 24);
            this.cboUsername.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 440);
            this.Controls.Add(this.cboUsername);
            this.Controls.Add(this.cboServerName);
            this.Controls.Add(this.cboServerIP);
            this.Controls.Add(this.btnConnectRemote);
            this.Controls.Add(this.btnConnectLocal);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConnectLocal;
        private System.Windows.Forms.Button btnConnectRemote;
        private System.Windows.Forms.ComboBox cboServerIP;
        private System.Windows.Forms.ComboBox cboServerName;
        private System.Windows.Forms.ComboBox cboUsername;
    }
}

