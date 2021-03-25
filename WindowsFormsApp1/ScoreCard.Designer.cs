
namespace WindowsFormsApp1
{
    partial class ScoreCard
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblCallSatScore = new System.Windows.Forms.Label();
            this.lblCallProf = new System.Windows.Forms.Label();
            this.lblCallResSpeedScore = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.gbxCall = new System.Windows.Forms.GroupBox();
            this.gbxTech = new System.Windows.Forms.GroupBox();
            this.lbltechSatScore = new System.Windows.Forms.Label();
            this.lblTechProf = new System.Windows.Forms.Label();
            this.lblTechResSpeedScore = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxCall.SuspendLayout();
            this.gbxTech.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(102, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(179, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Satisfaction Form";
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Location = new System.Drawing.Point(33, 34);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(294, 13);
            this.lblSubHeading.TabIndex = 1;
            this.lblSubHeading.Text = "Please take a few moments to complete the following survey ";
            this.lblSubHeading.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCallSatScore
            // 
            this.lblCallSatScore.AutoSize = true;
            this.lblCallSatScore.Location = new System.Drawing.Point(6, 24);
            this.lblCallSatScore.Name = "lblCallSatScore";
            this.lblCallSatScore.Size = new System.Drawing.Size(178, 13);
            this.lblCallSatScore.TabIndex = 4;
            this.lblCallSatScore.Text = "Overall call centre agent satisfaction";
            // 
            // lblCallProf
            // 
            this.lblCallProf.AutoSize = true;
            this.lblCallProf.Location = new System.Drawing.Point(56, 55);
            this.lblCallProf.Name = "lblCallProf";
            this.lblCallProf.Size = new System.Drawing.Size(128, 13);
            this.lblCallProf.TabIndex = 6;
            this.lblCallProf.Text = "Call agent professionalism";
            // 
            // lblCallResSpeedScore
            // 
            this.lblCallResSpeedScore.AutoSize = true;
            this.lblCallResSpeedScore.Location = new System.Drawing.Point(83, 93);
            this.lblCallResSpeedScore.Name = "lblCallResSpeedScore";
            this.lblCallResSpeedScore.Size = new System.Drawing.Size(101, 13);
            this.lblCallResSpeedScore.TabIndex = 9;
            this.lblCallResSpeedScore.Text = "Speed of resolution ";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox4.Location = new System.Drawing.Point(198, 21);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.Text = "Select a score...";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox5.Location = new System.Drawing.Point(198, 55);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 14;
            this.comboBox5.Text = "Select a score...";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox6.Location = new System.Drawing.Point(198, 93);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 15;
            this.comboBox6.Text = "Select a score...";
            // 
            // gbxCall
            // 
            this.gbxCall.Controls.Add(this.lblCallSatScore);
            this.gbxCall.Controls.Add(this.lblCallProf);
            this.gbxCall.Controls.Add(this.lblCallResSpeedScore);
            this.gbxCall.Controls.Add(this.comboBox4);
            this.gbxCall.Controls.Add(this.comboBox5);
            this.gbxCall.Controls.Add(this.comboBox6);
            this.gbxCall.Location = new System.Drawing.Point(17, 223);
            this.gbxCall.Name = "gbxCall";
            this.gbxCall.Size = new System.Drawing.Size(330, 127);
            this.gbxCall.TabIndex = 23;
            this.gbxCall.TabStop = false;
            this.gbxCall.Text = "Call Center Agent Satisfaction";
            // 
            // gbxTech
            // 
            this.gbxTech.Controls.Add(this.lbltechSatScore);
            this.gbxTech.Controls.Add(this.lblTechProf);
            this.gbxTech.Controls.Add(this.lblTechResSpeedScore);
            this.gbxTech.Controls.Add(this.comboBox1);
            this.gbxTech.Controls.Add(this.comboBox2);
            this.gbxTech.Controls.Add(this.comboBox3);
            this.gbxTech.Location = new System.Drawing.Point(17, 71);
            this.gbxTech.Name = "gbxTech";
            this.gbxTech.Size = new System.Drawing.Size(330, 127);
            this.gbxTech.TabIndex = 24;
            this.gbxTech.TabStop = false;
            this.gbxTech.Text = "Technician Satisfaction";
            // 
            // lbltechSatScore
            // 
            this.lbltechSatScore.AutoSize = true;
            this.lbltechSatScore.Location = new System.Drawing.Point(32, 21);
            this.lbltechSatScore.Name = "lbltechSatScore";
            this.lbltechSatScore.Size = new System.Drawing.Size(152, 13);
            this.lbltechSatScore.TabIndex = 4;
            this.lbltechSatScore.Text = "Overall Technician satisfaction";
            this.lbltechSatScore.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTechProf
            // 
            this.lblTechProf.AutoSize = true;
            this.lblTechProf.Location = new System.Drawing.Point(56, 55);
            this.lblTechProf.Name = "lblTechProf";
            this.lblTechProf.Size = new System.Drawing.Size(134, 13);
            this.lblTechProf.TabIndex = 6;
            this.lblTechProf.Text = "Technician professionalism";
            // 
            // lblTechResSpeedScore
            // 
            this.lblTechResSpeedScore.AutoSize = true;
            this.lblTechResSpeedScore.Location = new System.Drawing.Point(83, 93);
            this.lblTechResSpeedScore.Name = "lblTechResSpeedScore";
            this.lblTechResSpeedScore.Size = new System.Drawing.Size(101, 13);
            this.lblTechResSpeedScore.TabIndex = 9;
            this.lblTechResSpeedScore.Text = "Speed of resolution ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(198, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Select a score...";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(198, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "Select a score...";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(198, 93);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.Text = "Select a score...";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(151, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ScoreCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 420);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxTech);
            this.Controls.Add(this.gbxCall);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblHeading);
            this.MaximumSize = new System.Drawing.Size(384, 459);
            this.MinimumSize = new System.Drawing.Size(384, 459);
            this.Name = "ScoreCard";
            this.Text = "Satisfaction Form ";
            this.gbxCall.ResumeLayout(false);
            this.gbxCall.PerformLayout();
            this.gbxTech.ResumeLayout(false);
            this.gbxTech.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label lblCallSatScore;
        private System.Windows.Forms.Label lblCallProf;
        private System.Windows.Forms.Label lblCallResSpeedScore;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.GroupBox gbxCall;
        private System.Windows.Forms.GroupBox gbxTech;
        private System.Windows.Forms.Label lbltechSatScore;
        private System.Windows.Forms.Label lblTechProf;
        private System.Windows.Forms.Label lblTechResSpeedScore;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnSubmit;
    }
}

