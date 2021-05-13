
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
            this.btnViewAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntNew
            // 
            this.bntNew.Location = new System.Drawing.Point(226, 119);
            this.bntNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(88, 37);
            this.bntNew.TabIndex = 0;
            this.bntNew.Text = "Add New Contract";
            this.bntNew.UseVisualStyleBackColor = true;
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // bntChangeContractState
            // 
            this.bntChangeContractState.Location = new System.Drawing.Point(31, 119);
            this.bntChangeContractState.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntChangeContractState.Name = "bntChangeContractState";
            this.bntChangeContractState.Size = new System.Drawing.Size(88, 37);
            this.bntChangeContractState.TabIndex = 1;
            this.bntChangeContractState.Text = "Change Contract Statce";
            this.bntChangeContractState.UseVisualStyleBackColor = true;
            this.bntChangeContractState.Click += new System.EventHandler(this.bntChangeContractState_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "What Would you like to do";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(125, 119);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(96, 37);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View All Contracts";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // ContractMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 214);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntChangeContractState);
            this.Controls.Add(this.bntNew);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContractMaintenance";
            this.Text = "ContractMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntNew;
        private System.Windows.Forms.Button bntChangeContractState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAll;
    }
}