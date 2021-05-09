
namespace ContractMaintance
{
    partial class ContractMaintance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntNewContract = new System.Windows.Forms.Button();
            this.bntDeactivate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "What would you like to do";
            // 
            // bntNewContract
            // 
            this.bntNewContract.Location = new System.Drawing.Point(46, 109);
            this.bntNewContract.Name = "bntNewContract";
            this.bntNewContract.Size = new System.Drawing.Size(101, 52);
            this.bntNewContract.TabIndex = 2;
            this.bntNewContract.Text = "Make a new contract";
            this.bntNewContract.UseVisualStyleBackColor = true;
            this.bntNewContract.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntDeactivate
            // 
            this.bntDeactivate.Location = new System.Drawing.Point(332, 109);
            this.bntDeactivate.Name = "bntDeactivate";
            this.bntDeactivate.Size = new System.Drawing.Size(101, 52);
            this.bntDeactivate.TabIndex = 3;
            this.bntDeactivate.Text = "Deactivate old contract";
            this.bntDeactivate.UseVisualStyleBackColor = true;
            this.bntDeactivate.Click += new System.EventHandler(this.button2_Click);
            // 
            // ContractMaintance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 219);
            this.Controls.Add(this.bntDeactivate);
            this.Controls.Add(this.bntNewContract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ContractMaintance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntNewContract;
        private System.Windows.Forms.Button bntDeactivate;
    }
}

