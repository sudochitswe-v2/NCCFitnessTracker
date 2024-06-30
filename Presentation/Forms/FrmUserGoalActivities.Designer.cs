namespace FitnessTracker.Desktop.Presentation.Forms
{
    partial class FrmUserGoalActivities
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
            this.txtBurnedCalories = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCalculation = new System.Windows.Forms.GroupBox();
            this.txtMet = new System.Windows.Forms.TextBox();
            this.lblMet = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtMetric3 = new System.Windows.Forms.TextBox();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.txtUserWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.btnSaveTracking = new System.Windows.Forms.Button();
            this.gpbGoal = new System.Windows.Forms.GroupBox();
            this.txtTargetCalories = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTrackings = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.gbCalculation.SuspendLayout();
            this.gpbGoal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackings)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBurnedCalories
            // 
            this.txtBurnedCalories.Location = new System.Drawing.Point(369, 25);
            this.txtBurnedCalories.Name = "txtBurnedCalories";
            this.txtBurnedCalories.ReadOnly = true;
            this.txtBurnedCalories.Size = new System.Drawing.Size(120, 20);
            this.txtBurnedCalories.TabIndex = 29;
            this.txtBurnedCalories.TextChanged += new System.EventHandler(this.txtBurnedCalories_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Burned Calories";
            // 
            // gbCalculation
            // 
            this.gbCalculation.Controls.Add(this.txtMet);
            this.gbCalculation.Controls.Add(this.lblMet);
            this.gbCalculation.Controls.Add(this.btnSaveTracking);
            this.gbCalculation.Controls.Add(this.btnCalculate);
            this.gbCalculation.Controls.Add(this.label3);
            this.gbCalculation.Controls.Add(this.txtMetric3);
            this.gbCalculation.Controls.Add(this.txtBurnedCalories);
            this.gbCalculation.Controls.Add(this.lblMetric3);
            this.gbCalculation.Controls.Add(this.txtMetric2);
            this.gbCalculation.Controls.Add(this.lblMetric2);
            this.gbCalculation.Controls.Add(this.txtMetric1);
            this.gbCalculation.Controls.Add(this.lblMetric1);
            this.gbCalculation.Controls.Add(this.txtUserWeight);
            this.gbCalculation.Controls.Add(this.label5);
            this.gbCalculation.Controls.Add(this.label4);
            this.gbCalculation.Controls.Add(this.cboActivities);
            this.gbCalculation.Location = new System.Drawing.Point(39, 260);
            this.gbCalculation.Name = "gbCalculation";
            this.gbCalculation.Size = new System.Drawing.Size(546, 194);
            this.gbCalculation.TabIndex = 27;
            this.gbCalculation.TabStop = false;
            this.gbCalculation.Text = "Calculation";
            // 
            // txtMet
            // 
            this.txtMet.Location = new System.Drawing.Point(116, 153);
            this.txtMet.Name = "txtMet";
            this.txtMet.Size = new System.Drawing.Size(120, 20);
            this.txtMet.TabIndex = 35;
            // 
            // lblMet
            // 
            this.lblMet.AutoSize = true;
            this.lblMet.Location = new System.Drawing.Point(32, 156);
            this.lblMet.Name = "lblMet";
            this.lblMet.Size = new System.Drawing.Size(30, 13);
            this.lblMet.TabIndex = 34;
            this.lblMet.Text = "MET";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnCalculate.Image = global::FitnessTracker.Desktop.Properties.Resources.icons8_save_24;
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(379, 83);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 33);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtMetric3
            // 
            this.txtMetric3.Location = new System.Drawing.Point(116, 122);
            this.txtMetric3.Name = "txtMetric3";
            this.txtMetric3.Size = new System.Drawing.Size(120, 20);
            this.txtMetric3.TabIndex = 33;
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Location = new System.Drawing.Point(32, 125);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(45, 13);
            this.lblMetric3.TabIndex = 32;
            this.lblMetric3.Text = "Metric 3";
            // 
            // txtMetric2
            // 
            this.txtMetric2.Location = new System.Drawing.Point(116, 90);
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(120, 20);
            this.txtMetric2.TabIndex = 31;
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Location = new System.Drawing.Point(32, 93);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(45, 13);
            this.lblMetric2.TabIndex = 30;
            this.lblMetric2.Text = "Metric 2";
            // 
            // txtMetric1
            // 
            this.txtMetric1.Location = new System.Drawing.Point(116, 61);
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(120, 20);
            this.txtMetric1.TabIndex = 29;
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Location = new System.Drawing.Point(32, 64);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(45, 13);
            this.lblMetric1.TabIndex = 28;
            this.lblMetric1.Text = "Metric 1";
            // 
            // txtUserWeight
            // 
            this.txtUserWeight.Location = new System.Drawing.Point(369, 57);
            this.txtUserWeight.Name = "txtUserWeight";
            this.txtUserWeight.ReadOnly = true;
            this.txtUserWeight.Size = new System.Drawing.Size(120, 20);
            this.txtUserWeight.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Weight ( kg )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Selected Activity";
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(113, 25);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(121, 21);
            this.cboActivities.TabIndex = 24;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // btnSaveTracking
            // 
            this.btnSaveTracking.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveTracking.Enabled = false;
            this.btnSaveTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSaveTracking.Image = global::FitnessTracker.Desktop.Properties.Resources.icons8_save_24;
            this.btnSaveTracking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTracking.Location = new System.Drawing.Point(379, 125);
            this.btnSaveTracking.Name = "btnSaveTracking";
            this.btnSaveTracking.Size = new System.Drawing.Size(110, 33);
            this.btnSaveTracking.TabIndex = 30;
            this.btnSaveTracking.Text = "Save";
            this.btnSaveTracking.UseVisualStyleBackColor = false;
            this.btnSaveTracking.Click += new System.EventHandler(this.btnSaveTracking_Click);
            // 
            // gpbGoal
            // 
            this.gpbGoal.Controls.Add(this.lblStatusValue);
            this.gpbGoal.Controls.Add(this.lblStatus);
            this.gpbGoal.Controls.Add(this.txtTargetCalories);
            this.gpbGoal.Controls.Add(this.label1);
            this.gpbGoal.Location = new System.Drawing.Point(39, 18);
            this.gpbGoal.Name = "gpbGoal";
            this.gpbGoal.Size = new System.Drawing.Size(459, 80);
            this.gpbGoal.TabIndex = 32;
            this.gpbGoal.TabStop = false;
            this.gpbGoal.Text = "Goal";
            // 
            // txtTargetCalories
            // 
            this.txtTargetCalories.Location = new System.Drawing.Point(96, 32);
            this.txtTargetCalories.Name = "txtTargetCalories";
            this.txtTargetCalories.ReadOnly = true;
            this.txtTargetCalories.Size = new System.Drawing.Size(120, 20);
            this.txtTargetCalories.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Target Calories";
            // 
            // dgvTrackings
            // 
            this.dgvTrackings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrackings.Location = new System.Drawing.Point(39, 104);
            this.dgvTrackings.Name = "dgvTrackings";
            this.dgvTrackings.Size = new System.Drawing.Size(649, 150);
            this.dgvTrackings.TabIndex = 33;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(244, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 13);
            this.lblStatus.TabIndex = 32;
            this.lblStatus.Text = "Target Calories";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(343, 39);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(13, 13);
            this.lblStatusValue.TabIndex = 33;
            this.lblStatusValue.Text = " -";
            this.lblStatusValue.TextChanged += new System.EventHandler(this.lblStatusValue_TextChanged);
            // 
            // FrmUserGoalActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 485);
            this.Controls.Add(this.dgvTrackings);
            this.Controls.Add(this.gpbGoal);
            this.Controls.Add(this.gbCalculation);
            this.Name = "FrmUserGoalActivities";
            this.Text = "Activities";
            this.Load += new System.EventHandler(this.FrmUserGoalActivities_Load);
            this.gbCalculation.ResumeLayout(false);
            this.gbCalculation.PerformLayout();
            this.gpbGoal.ResumeLayout(false);
            this.gpbGoal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveTracking;
        private System.Windows.Forms.TextBox txtBurnedCalories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCalculation;
        private System.Windows.Forms.TextBox txtUserWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gpbGoal;
        private System.Windows.Forms.TextBox txtTargetCalories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTrackings;
        private System.Windows.Forms.TextBox txtMet;
        private System.Windows.Forms.Label lblMet;
        private System.Windows.Forms.TextBox txtMetric3;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblStatus;
    }
}