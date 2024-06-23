namespace FitnessTracker.Desktop.Presentation.Forms
{
    partial class FrmUserProfile
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
            this.gbProfile = new System.Windows.Forms.GroupBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAlertNewProfile = new System.Windows.Forms.Label();
            this.gbProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProfile
            // 
            this.gbProfile.Controls.Add(this.txtHeight);
            this.gbProfile.Controls.Add(this.txtWeight);
            this.gbProfile.Controls.Add(this.label3);
            this.gbProfile.Controls.Add(this.dtpDateOfBirth);
            this.gbProfile.Controls.Add(this.groupBox1);
            this.gbProfile.Controls.Add(this.label2);
            this.gbProfile.Controls.Add(this.label1);
            this.gbProfile.Location = new System.Drawing.Point(12, 38);
            this.gbProfile.Name = "gbProfile";
            this.gbProfile.Size = new System.Drawing.Size(237, 234);
            this.gbProfile.TabIndex = 2;
            this.gbProfile.TabStop = false;
            this.gbProfile.Text = "Profile";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(125, 61);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(65, 20);
            this.txtHeight.TabIndex = 9;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(44, 61);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(65, 20);
            this.txtWeight.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date of Birth";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(44, 103);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(139, 20);
            this.dtpDateOfBirth.TabIndex = 3;
            this.dtpDateOfBirth.Value = new System.DateTime(2024, 6, 12, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOther);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(44, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(6, 46);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(51, 17);
            this.rdoOther.TabIndex = 8;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(60, 23);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 7;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 23);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height ( cm )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weight ( kg )";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSave.Image = global::FitnessTracker.Desktop.Properties.Resources.login_x32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(137, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblAlertNewProfile
            // 
            this.lblAlertNewProfile.AutoSize = true;
            this.lblAlertNewProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertNewProfile.ForeColor = System.Drawing.Color.Green;
            this.lblAlertNewProfile.Location = new System.Drawing.Point(21, 11);
            this.lblAlertNewProfile.Name = "lblAlertNewProfile";
            this.lblAlertNewProfile.Size = new System.Drawing.Size(228, 13);
            this.lblAlertNewProfile.TabIndex = 11;
            this.lblAlertNewProfile.Text = "Please finish your profile and continue.";
            // 
            // FrmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 341);
            this.Controls.Add(this.lblAlertNewProfile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbProfile);
            this.MinimumSize = new System.Drawing.Size(281, 380);
            this.Name = "FrmUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.FrmUserProfile_Load);
            this.gbProfile.ResumeLayout(false);
            this.gbProfile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbProfile;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAlertNewProfile;
    }
}