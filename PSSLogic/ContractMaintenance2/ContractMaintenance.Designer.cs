
namespace ContractMaintenance2
{
    partial class ContractMaintenance
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
            this.bntNew = new System.Windows.Forms.Button();
            this.bntChangeContractState = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntNew
            // 
            this.bntNew.Location = new System.Drawing.Point(301, 147);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(118, 45);
            this.bntNew.TabIndex = 0;
            this.bntNew.Text = "Add New Contract";
            this.bntNew.UseVisualStyleBackColor = true;
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // bntChangeContractState
            // 
            this.bntChangeContractState.Location = new System.Drawing.Point(41, 147);
            this.bntChangeContractState.Name = "bntChangeContractState";
            this.bntChangeContractState.Size = new System.Drawing.Size(118, 45);
            this.bntChangeContractState.TabIndex = 1;
            this.bntChangeContractState.Text = "Change Contract Statce";
            this.bntChangeContractState.UseVisualStyleBackColor = true;
            this.bntChangeContractState.Click += new System.EventHandler(this.bntChangeContractState_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "What Would you like to do";
            // 
            // ContractMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntChangeContractState);
            this.Controls.Add(this.bntNew);
            this.Name = "ContractMaintenance";
            this.Text = "ContractMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntNew;
        private System.Windows.Forms.Button bntChangeContractState;
        private System.Windows.Forms.Label label1;
    }
}