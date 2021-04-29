
namespace CallCenter
{
    partial class ClientChoiceForm
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
            this.bntUpdate = new System.Windows.Forms.Button();
            this.bntComplant = new System.Windows.Forms.Button();
            this.lbClientEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would the client like to do";
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(183, 169);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(112, 56);
            this.bntUpdate.TabIndex = 1;
            this.bntUpdate.Text = "Update Contract";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntComplant
            // 
            this.bntComplant.Location = new System.Drawing.Point(442, 169);
            this.bntComplant.Name = "bntComplant";
            this.bntComplant.Size = new System.Drawing.Size(112, 56);
            this.bntComplant.TabIndex = 2;
            this.bntComplant.Text = "Log Complant";
            this.bntComplant.UseVisualStyleBackColor = true;
            this.bntComplant.Click += new System.EventHandler(this.bntComplant_Click);
            // 
            // lbClientEmail
            // 
            this.lbClientEmail.AutoSize = true;
            this.lbClientEmail.Location = new System.Drawing.Point(180, 62);
            this.lbClientEmail.Name = "lbClientEmail";
            this.lbClientEmail.Size = new System.Drawing.Size(88, 17);
            this.lbClientEmail.TabIndex = 3;
            this.lbClientEmail.Text = "lbClientEmail";
            // 
            // ClientChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 316);
            this.Controls.Add(this.lbClientEmail);
            this.Controls.Add(this.bntComplant);
            this.Controls.Add(this.bntUpdate);
            this.Controls.Add(this.label1);
            this.Name = "ClientChoiceForm";
            this.Text = "ClientChoiceForm";
            this.Load += new System.EventHandler(this.ClientChoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button bntComplant;
        private System.Windows.Forms.Label lbClientEmail;
    }
}