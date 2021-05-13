
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
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contract Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // CombContractType
            // 
            this.CombContractType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CombContractType.FormattingEnabled = true;
            this.CombContractType.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Silver",
            "Bronze"});
            this.CombContractType.Location = new System.Drawing.Point(208, 112);
            this.CombContractType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CombContractType.Name = "CombContractType";
            this.CombContractType.Size = new System.Drawing.Size(133, 23);
            this.CombContractType.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(208, 206);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(133, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(208, 157);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(133, 23);
            this.txtDescription.TabIndex = 5;
            // 
            // bntSubmit
            // 
            this.bntSubmit.Location = new System.Drawing.Point(208, 449);
            this.bntSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntSubmit.Name = "bntSubmit";
            this.bntSubmit.Size = new System.Drawing.Size(85, 34);
            this.bntSubmit.TabIndex = 6;
            this.bntSubmit.Text = "Submit";
            this.bntSubmit.UseVisualStyleBackColor = true;
            this.bntSubmit.Click += new System.EventHandler(this.bntSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Please Enter The Infomation Below";
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(74, 449);
            this.bntCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(85, 34);
            this.bntCancel.TabIndex = 8;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.Location = new System.Drawing.Point(208, 250);
            this.txtDeviceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Size = new System.Drawing.Size(133, 23);
            this.txtDeviceID.TabIndex = 9;
            // 
            // cmbActive
            // 
            this.cmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmbActive.Location = new System.Drawing.Point(208, 388);
            this.cmbActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(133, 23);
            this.cmbActive.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "DeviceID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Active ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Model";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Manufacturer";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(208, 343);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(133, 23);
            this.txtModel.TabIndex = 17;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(208, 292);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(133, 23);
            this.txtManufacturer.TabIndex = 18;
            this.txtManufacturer.TextChanged += new System.EventHandler(this.txtManufacturer_TextChanged);
            // 
            // NewContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 500);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbActive);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewContractForm";
            this.Text = "DeviceID";
            this.Load += new System.EventHandler(this.NewContractForm_Load);
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
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtManufacturer;
    }
}