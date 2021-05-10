
namespace ContractMaintance
{
    partial class DeactivateContract
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntDeactivate = new System.Windows.Forms.Button();
            this.bntCancel = new System.Windows.Forms.Button();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contract ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(243, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 27);
            this.txtID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Please Enter The ID of The Contract New Want To Devactive ";
            // 
            // bntDeactivate
            // 
            this.bntDeactivate.Location = new System.Drawing.Point(243, 218);
            this.bntDeactivate.Name = "bntDeactivate";
            this.bntDeactivate.Size = new System.Drawing.Size(129, 29);
            this.bntDeactivate.TabIndex = 4;
            this.bntDeactivate.Text = "Change Status ";
            this.bntDeactivate.UseVisualStyleBackColor = true;
            this.bntDeactivate.Click += new System.EventHandler(this.bntDeactivate_Click);
            // 
            // bntCancel
            // 
            this.bntCancel.Location = new System.Drawing.Point(50, 218);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(95, 29);
            this.bntCancel.TabIndex = 5;
            this.bntCancel.Text = "Cancel";
            this.bntCancel.UseVisualStyleBackColor = true;
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cmbState.Location = new System.Drawing.Point(240, 147);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(151, 28);
            this.cmbState.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Active State";
            // 
            // DeactivateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.bntDeactivate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeactivateContract";
            this.Text = "DeactivateContract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntDeactivate;
        private System.Windows.Forms.Button bntCancel;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label4;
    }
}