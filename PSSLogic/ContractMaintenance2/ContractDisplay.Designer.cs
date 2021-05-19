
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractDisplay));
            this.dgvViewContracts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bntSearch = new System.Windows.Forms.Button();
            this.cmbContractType = new System.Windows.Forms.ComboBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewContracts
            // 
            this.dgvViewContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewContracts.Location = new System.Drawing.Point(11, 11);
            this.dgvViewContracts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvViewContracts.Name = "dgvViewContracts";
            this.dgvViewContracts.RowHeadersWidth = 51;
            this.dgvViewContracts.RowTemplate.Height = 24;
            this.dgvViewContracts.Size = new System.Drawing.Size(299, 189);
            this.dgvViewContracts.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contract type";
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(314, 49);
            this.bntSearch.Margin = new System.Windows.Forms.Padding(2);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(63, 20);
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
            this.cmbContractType.Location = new System.Drawing.Point(314, 24);
            this.cmbContractType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbContractType.Name = "cmbContractType";
            this.cmbContractType.Size = new System.Drawing.Size(70, 21);
            this.cmbContractType.TabIndex = 4;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(314, 74);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(63, 22);
            this.btnViewAll.TabIndex = 5;
            this.btnViewAll.Text = "View all";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(314, 102);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 22);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ContractDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 220);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.cmbContractType);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewContracts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnBack;
    }
}