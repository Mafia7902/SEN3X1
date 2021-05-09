
namespace ContractMaintance
{
    partial class NewContractForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CombContractType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.bntSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bntCancel = new System.Windows.Forms.Button();
            this.txtDeviceID = new System.Windows.Forms.TextBox();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contract Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // CombContractType
            // 
            this.CombContractType.FormattingEnabled = true;
            this.CombContractType.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver",
            "Bronze"});
            this.CombContractType.Location = new System.Drawing.Point(242, 189);
            this.CombContractType.Name = "CombContractType";
            this.CombContractType.Size = new System.Drawing.Size(151, 28);
            this.CombContractType.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(242, 311);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 27);
            this.txtPrice.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(242, 250);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(151, 27);
            this.txtDescription.TabIndex = 5;
            // 
            // bntSubmit
            // 
            this.bntSubmit.Location = new System.Drawing.Point(242, 490);
            this.bntSubmit.Name = "bntSubmit";
            this.bntSubmit.Size = new System.Drawing.Size(97, 45);
            this.bntSubmit.TabIndex = 6;
            this.bntSubmit.Text = "Submit";
            this.bntSubmit.UseVisualStyleBackColor = true;
            this.bntSubmit.Click += new System.EventHandler(this.bntSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please Enter The Infomation Below";
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(85, 490);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(97, 45);
            this.bntCancel.TabIndex = 8;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(242, 370);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(151, 27);
            this.txtDeviceID.TabIndex = 9;
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(242, 125);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(151, 27);
            this.txtContractID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contract ID";
            // 
            // cmbActive
            // 
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmbActive.Location = new System.Drawing.Point(242, 424);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(151, 28);
            this.cmbActive.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "DeviceID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Active ";
            // 
            // NewContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 547);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.txtDeviceID);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bntSubmit);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.CombContractType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewContractForm";
            this.Text = "DeviceID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CombContractType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button bntSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.TextBox txtDeviceID;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}