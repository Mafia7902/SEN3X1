
namespace TechnicianFORM
{
    partial class Technician
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
            this.FName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.lblTicketNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblUnitNum = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblClientType = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(12, 78);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(96, 20);
            this.FName.TabIndex = 0;
            this.FName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Technician Schedule";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(162, 78);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(95, 20);
            this.LName.TabIndex = 2;
            this.LName.Text = "Last Name";
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhone.Location = new System.Drawing.Point(663, 258);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(111, 20);
            this.lblClientPhone.TabIndex = 3;
            this.lblClientPhone.Text = "Client Phone";
            // 
            // lblTicketNum
            // 
            this.lblTicketNum.AutoSize = true;
            this.lblTicketNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNum.Location = new System.Drawing.Point(469, 78);
            this.lblTicketNum.Name = "lblTicketNum";
            this.lblTicketNum.Size = new System.Drawing.Size(124, 20);
            this.lblTicketNum.TabIndex = 4;
            this.lblTicketNum.Text = "Ticket Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Problem Details";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(608, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(473, 411);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(97, 33);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "Log Completion";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Location = new System.Drawing.Point(153, 258);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(130, 20);
            this.lblStreet.TabIndex = 9;
            this.lblStreet.Text = "Street Address";
            // 
            // lblUnitNum
            // 
            this.lblUnitNum.AutoSize = true;
            this.lblUnitNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitNum.Location = new System.Drawing.Point(12, 258);
            this.lblUnitNum.Name = "lblUnitNum";
            this.lblUnitNum.Size = new System.Drawing.Size(109, 20);
            this.lblUnitNum.TabIndex = 10;
            this.lblUnitNum.Text = "Unit Number";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.Location = new System.Drawing.Point(342, 258);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(67, 20);
            this.lblSuburb.TabIndex = 11;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(489, 258);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(104, 20);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Client Email";
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            this.lblClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientType.Location = new System.Drawing.Point(333, 78);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(98, 20);
            this.lblClientType.TabIndex = 13;
            this.lblClientType.Text = "Client Type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 124);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 281);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(758, 124);
            this.dataGridView2.TabIndex = 15;
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblClientType);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblUnitNum);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTicketNum);
            this.Controls.Add(this.lblClientPhone);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FName);
            this.Name = "Technician";
            this.Text = "Technician";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.Label lblTicketNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblUnitNum;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClientType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

