﻿namespace FinancielCrm
{
    partial class FrmChangePassword
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_newPassword = new System.Windows.Forms.TextBox();
            this.txt_oldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "degistir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "new password:";
            // 
            // txt_newPassword
            // 
            this.txt_newPassword.Location = new System.Drawing.Point(129, 86);
            this.txt_newPassword.Name = "txt_newPassword";
            this.txt_newPassword.Size = new System.Drawing.Size(131, 22);
            this.txt_newPassword.TabIndex = 3;
            // 
            // txt_oldPassword
            // 
            this.txt_oldPassword.Location = new System.Drawing.Point(129, 40);
            this.txt_oldPassword.Name = "txt_oldPassword";
            this.txt_oldPassword.Size = new System.Drawing.Size(131, 22);
            this.txt_oldPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "old password:";
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_oldPassword);
            this.Controls.Add(this.txt_newPassword);
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_newPassword;
        private System.Windows.Forms.TextBox txt_oldPassword;
        private System.Windows.Forms.Label label2;
    }
}