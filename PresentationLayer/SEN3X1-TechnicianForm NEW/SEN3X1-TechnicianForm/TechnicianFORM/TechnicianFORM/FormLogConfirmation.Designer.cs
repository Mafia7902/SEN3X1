
namespace TechnicianFORM
{
    partial class FormLogConfirmation
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.lblAreYouSure = new System.Windows.Forms.Label();
            this.lblAreAoutTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(414, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(235, 165);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(97, 33);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // lblAreYouSure
            // 
            this.lblAreYouSure.AutoSize = true;
            this.lblAreYouSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreYouSure.Location = new System.Drawing.Point(291, 22);
            this.lblAreYouSure.Name = "lblAreYouSure";
            this.lblAreYouSure.Size = new System.Drawing.Size(159, 25);
            this.lblAreYouSure.TabIndex = 10;
            this.lblAreYouSure.Text = "Are you sure?";
            // 
            // lblAreAoutTo
            // 
            this.lblAreAoutTo.AutoSize = true;
            this.lblAreAoutTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreAoutTo.Location = new System.Drawing.Point(90, 69);
            this.lblAreAoutTo.Name = "lblAreAoutTo";
            this.lblAreAoutTo.Size = new System.Drawing.Size(602, 16);
            this.lblAreAoutTo.TabIndex = 11;
            this.lblAreAoutTo.Text = "You are about to log an assignment as complete. Make sure all necessary actions h" +
    "ave been taken. ";
            // 
            // LogConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 229);
            this.Controls.Add(this.lblAreAoutTo);
            this.Controls.Add(this.lblAreYouSure);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCancel);
            this.Name = "LogConfirmation";
            this.Text = "LogConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Label lblAreYouSure;
        private System.Windows.Forms.Label lblAreAoutTo;
    }
}