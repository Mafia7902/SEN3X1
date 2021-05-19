
namespace LoginV2
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btnCallCentre = new System.Windows.Forms.Button();
            this.btnTechReview = new System.Windows.Forms.Button();
            this.btnContractMain = new System.Windows.Forms.Button();
            this.btnTechForm = new System.Windows.Forms.Button();
            this.btnClinetMain = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallCentre
            // 
            this.btnCallCentre.Location = new System.Drawing.Point(12, 12);
            this.btnCallCentre.Name = "btnCallCentre";
            this.btnCallCentre.Size = new System.Drawing.Size(119, 23);
            this.btnCallCentre.TabIndex = 1;
            this.btnCallCentre.Text = "Call Centre form ";
            this.btnCallCentre.UseVisualStyleBackColor = true;
            this.btnCallCentre.Click += new System.EventHandler(this.btnCallCentre_Click);
            // 
            // btnTechReview
            // 
            this.btnTechReview.Location = new System.Drawing.Point(12, 42);
            this.btnTechReview.Name = "btnTechReview";
            this.btnTechReview.Size = new System.Drawing.Size(119, 23);
            this.btnTechReview.TabIndex = 2;
            this.btnTechReview.Text = "Technician Review";
            this.btnTechReview.UseVisualStyleBackColor = true;
            this.btnTechReview.Click += new System.EventHandler(this.btnTechReview_Click);
            // 
            // btnContractMain
            // 
            this.btnContractMain.Location = new System.Drawing.Point(12, 72);
            this.btnContractMain.Name = "btnContractMain";
            this.btnContractMain.Size = new System.Drawing.Size(119, 23);
            this.btnContractMain.TabIndex = 3;
            this.btnContractMain.Text = "Conract Maintenence ";
            this.btnContractMain.UseVisualStyleBackColor = true;
            this.btnContractMain.Click += new System.EventHandler(this.btnContractMain_Click);
            // 
            // btnTechForm
            // 
            this.btnTechForm.Location = new System.Drawing.Point(12, 102);
            this.btnTechForm.Name = "btnTechForm";
            this.btnTechForm.Size = new System.Drawing.Size(119, 23);
            this.btnTechForm.TabIndex = 4;
            this.btnTechForm.Text = "Technician Form";
            this.btnTechForm.UseVisualStyleBackColor = true;
            this.btnTechForm.Click += new System.EventHandler(this.btnTechForm_Click);
            // 
            // btnClinetMain
            // 
            this.btnClinetMain.Location = new System.Drawing.Point(12, 132);
            this.btnClinetMain.Name = "btnClinetMain";
            this.btnClinetMain.Size = new System.Drawing.Size(119, 23);
            this.btnClinetMain.TabIndex = 5;
            this.btnClinetMain.Text = "Client Maintenence ";
            this.btnClinetMain.UseVisualStyleBackColor = true;
            this.btnClinetMain.Click += new System.EventHandler(this.btnClinetMain_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 162);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 199);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClinetMain);
            this.Controls.Add(this.btnTechForm);
            this.Controls.Add(this.btnContractMain);
            this.Controls.Add(this.btnTechReview);
            this.Controls.Add(this.btnCallCentre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(163, 238);
            this.MinimumSize = new System.Drawing.Size(163, 238);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCallCentre;
        private System.Windows.Forms.Button btnTechReview;
        private System.Windows.Forms.Button btnContractMain;
        private System.Windows.Forms.Button btnTechForm;
        private System.Windows.Forms.Button btnClinetMain;
        private System.Windows.Forms.Button btnBack;
    }
}