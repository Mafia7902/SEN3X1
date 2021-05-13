
namespace ContractMaintenance2
{
    partial class ContractDisplay
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
            this.dgvViewContracts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bntSearch = new System.Windows.Forms.Button();
            this.cmbContractType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewContracts
            // 
            this.dgvViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewContracts.Location = new System.Drawing.Point(12, 152);
            this.dgvViewContracts.Name = "dgvViewContracts";
            this.dgvViewContracts.RowHeadersWidth = 51;
            this.dgvViewContracts.RowTemplate.Height = 24;
            this.dgvViewContracts.Size = new System.Drawing.Size(675, 294);
            this.dgvViewContracts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contract type";
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(334, 81);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(84, 24);
            this.bntSearch.TabIndex = 3;
            this.bntSearch.Text = "Search";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // cmbContractType
            // 
            this.cmbContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContractType.FormattingEnabled = true;
            this.cmbContractType.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver",
            "Bronze"});
            this.cmbContractType.Location = new System.Drawing.Point(153, 81);
            this.cmbContractType.Name = "cmbContractType";
            this.cmbContractType.Size = new System.Drawing.Size(175, 24);
            this.cmbContractType.TabIndex = 4;
            // 
            // ContractDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.cmbContractType);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewContracts);
            this.Name = "ContractDisplay";
            this.Text = "ContractDisplay";
            this.Load += new System.EventHandler(this.ContractDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewContracts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.ComboBox cmbContractType;
    }
}