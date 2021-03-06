
namespace CallCenter
{
    partial class ContractMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractMaintenanceForm));
            this.lbClient = new System.Windows.Forms.Label();
            this.cmbNewContract = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntSubmit = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(100, 89);
            this.lbClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(66, 13);
            this.lbClient.TabIndex = 0;
            this.lbClient.Text = "currentClient";
            // 
            // cmbNewContract
            // 
            this.cmbNewContract.FormattingEnabled = true;
            this.cmbNewContract.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver",
            "Bronze"});
            this.cmbNewContract.Location = new System.Drawing.Point(310, 86);
            this.cmbNewContract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNewContract.Name = "cmbNewContract";
            this.cmbNewContract.Size = new System.Drawing.Size(92, 21);
            this.cmbNewContract.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select a new contract";
            // 
            // bntSubmit
            // 
            this.bntSubmit.Location = new System.Drawing.Point(310, 142);
            this.bntSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntSubmit.Name = "bntSubmit";
            this.bntSubmit.Size = new System.Drawing.Size(91, 31);
            this.bntSubmit.TabIndex = 3;
            this.bntSubmit.Text = "Submit";
            this.bntSubmit.UseVisualStyleBackColor = true;
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(103, 142);
            this.bntCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(91, 31);
            this.bntCancel.TabIndex = 4;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // ContractMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 239);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.bntSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNewContract);
            this.Controls.Add(this.lbClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ContractMaintenanceForm";
            this.Text = "Contract Maintenance Form";
            this.Shown += new System.EventHandler(this.ContractMaintenanceForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.ComboBox cmbNewContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntSubmit;
        private System.Windows.Forms.Button bntCancel;
    }
}