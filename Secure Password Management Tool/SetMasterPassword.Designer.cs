namespace Secure_Password_Management_Tool
{
    partial class SetMasterPassword
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
            this.txtMasterPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmMasterPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveMasterPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Master Password:";
            // 
            // txtMasterPassword
            // 
            this.txtMasterPassword.Location = new System.Drawing.Point(339, 100);
            this.txtMasterPassword.Name = "txtMasterPassword";
            this.txtMasterPassword.Size = new System.Drawing.Size(219, 22);
            this.txtMasterPassword.TabIndex = 1;
            // 
            // txtConfirmMasterPassword
            // 
            this.txtConfirmMasterPassword.Location = new System.Drawing.Point(339, 139);
            this.txtConfirmMasterPassword.Name = "txtConfirmMasterPassword";
            this.txtConfirmMasterPassword.Size = new System.Drawing.Size(219, 22);
            this.txtConfirmMasterPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repeat Master Password:";
            // 
            // btnSaveMasterPassword
            // 
            this.btnSaveMasterPassword.Location = new System.Drawing.Point(339, 184);
            this.btnSaveMasterPassword.Name = "btnSaveMasterPassword";
            this.btnSaveMasterPassword.Size = new System.Drawing.Size(75, 27);
            this.btnSaveMasterPassword.TabIndex = 4;
            this.btnSaveMasterPassword.Text = "Save";
            this.btnSaveMasterPassword.UseVisualStyleBackColor = true;
            this.btnSaveMasterPassword.Click += new System.EventHandler(this.BtnSaveMasterPassword_Click);
            // 
            // SetMasterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaveMasterPassword);
            this.Controls.Add(this.txtConfirmMasterPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasterPassword);
            this.Controls.Add(this.label1);
            this.Name = "SetMasterPassword";
            this.Text = "Set Master Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasterPassword;
        private System.Windows.Forms.TextBox txtConfirmMasterPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveMasterPassword;
    }
}