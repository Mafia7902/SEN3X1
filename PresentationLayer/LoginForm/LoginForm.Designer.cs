﻿
namespace LoginForm
{
    partial class LoginForm
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
            this.HeadingLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.txtBoxEmpID = new System.Windows.Forms.TextBox();
            this.txtBoxPsw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HeadingLbl
            // 
            this.HeadingLbl.AutoSize = true;
            this.HeadingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLbl.Location = new System.Drawing.Point(74, 9);
            this.HeadingLbl.Name = "HeadingLbl";
            this.HeadingLbl.Size = new System.Drawing.Size(146, 29);
            this.HeadingLbl.TabIndex = 0;
            this.HeadingLbl.Text = "Login Form";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(76, 72);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(120, 13);
            this.UserNameLbl.TabIndex = 1;
            this.UserNameLbl.Text = "Enter your employee ID:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(76, 141);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(106, 13);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Enter your password:";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(107, 198);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // txtBoxEmpID
            // 
            this.txtBoxEmpID.Location = new System.Drawing.Point(75, 88);
            this.txtBoxEmpID.Name = "txtBoxEmpID";
            this.txtBoxEmpID.Size = new System.Drawing.Size(131, 20);
            this.txtBoxEmpID.TabIndex = 4;
            this.txtBoxEmpID.TextChanged += new System.EventHandler(this.txtBoxEmpID_TextChanged);
            // 
            // txtBoxPsw
            // 
            this.txtBoxPsw.Location = new System.Drawing.Point(74, 157);
            this.txtBoxPsw.Name = "txtBoxPsw";
            this.txtBoxPsw.Size = new System.Drawing.Size(132, 20);
            this.txtBoxPsw.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 245);
            this.Controls.Add(this.txtBoxPsw);
            this.Controls.Add(this.txtBoxEmpID);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.HeadingLbl);
            this.MaximumSize = new System.Drawing.Size(321, 284);
            this.MinimumSize = new System.Drawing.Size(321, 284);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeadingLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox txtBoxEmpID;
        private System.Windows.Forms.TextBox txtBoxPsw;
    }
}

