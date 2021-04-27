
namespace CallCenter
{
    partial class MainMenu
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
            this.btnNewCust = new System.Windows.Forms.Button();
            this.btnExistingCustomer = new System.Windows.Forms.Button();
            this.lblAreYou = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Premier Software Solution";
            // 
            // btnNewCust
            // 
            this.btnNewCust.Location = new System.Drawing.Point(118, 109);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(123, 46);
            this.btnNewCust.TabIndex = 3;
            this.btnNewCust.Text = "New Customer";
            this.btnNewCust.UseVisualStyleBackColor = true;
            this.btnNewCust.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExistingCustomer
            // 
            this.btnExistingCustomer.Location = new System.Drawing.Point(342, 109);
            this.btnExistingCustomer.Name = "btnExistingCustomer";
            this.btnExistingCustomer.Size = new System.Drawing.Size(123, 46);
            this.btnExistingCustomer.TabIndex = 4;
            this.btnExistingCustomer.Text = "Existing Customer";
            this.btnExistingCustomer.UseVisualStyleBackColor = true;
            this.btnExistingCustomer.Click += new System.EventHandler(this.btnExistingCustomer_Click);
            // 
            // lblAreYou
            // 
            this.lblAreYou.AutoSize = true;
            this.lblAreYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYou.Location = new System.Drawing.Point(257, 55);
            this.lblAreYou.Name = "lblAreYou";
            this.lblAreYou.Size = new System.Drawing.Size(70, 18);
            this.lblAreYou.TabIndex = 5;
            this.lblAreYou.Text = "Are you...";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 224);
            this.Controls.Add(this.lblAreYou);
            this.Controls.Add(this.btnExistingCustomer);
            this.Controls.Add(this.btnNewCust);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.Button btnExistingCustomer;
        private System.Windows.Forms.Label lblAreYou;
    }
}

