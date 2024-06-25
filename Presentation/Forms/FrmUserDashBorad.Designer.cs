namespace FitnessTracker.Desktop.Forms
{
    partial class FrmUserDashBorad
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.tabMainPage = new System.Windows.Forms.TabControl();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.tabGoalPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gpTargetCalories = new System.Windows.Forms.GroupBox();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.txtTargetCalories = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGoals = new System.Windows.Forms.DataGridView();
            this.tabPageTracking = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgvTrackings = new System.Windows.Forms.DataGridView();
            this.cboTargetGoal = new System.Windows.Forms.ComboBox();
            this.btnSaveTracking = new System.Windows.Forms.Button();
            this.txtBurnedCalories = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRequired = new System.Windows.Forms.GroupBox();
            this.txtUserWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.txtMet = new System.Windows.Forms.TextBox();
            this.lblMet = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtMetric3 = new System.Windows.Forms.TextBox();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.tabGoalPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gpTargetCalories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).BeginInit();
            this.tabPageTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackings)).BeginInit();
            this.gbRequired.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.splitContainer1.Panel1.Controls.Add(this.txtWelcome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMainPage);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 57;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtWelcome
            // 
            this.txtWelcome.BackColor = System.Drawing.Color.Transparent;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.txtWelcome.Location = new System.Drawing.Point(12, 18);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(757, 25);
            this.txtWelcome.TabIndex = 2;
            this.txtWelcome.Text = "Welcome Text";
            // 
            // tabMainPage
            // 
            this.tabMainPage.Controls.Add(this.tabPageDashboard);
            this.tabMainPage.Controls.Add(this.tabGoalPage);
            this.tabMainPage.Controls.Add(this.tabPageTracking);
            this.tabMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainPage.Location = new System.Drawing.Point(0, 0);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.SelectedIndex = 0;
            this.tabMainPage.Size = new System.Drawing.Size(800, 389);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.SelectedIndexChanged += new System.EventHandler(this.tabMainPage_SelectedIndexChanged);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(792, 363);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashborad";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // tabGoalPage
            // 
            this.tabGoalPage.Controls.Add(this.splitContainer2);
            this.tabGoalPage.Location = new System.Drawing.Point(4, 22);
            this.tabGoalPage.Name = "tabGoalPage";
            this.tabGoalPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabGoalPage.Size = new System.Drawing.Size(792, 363);
            this.tabGoalPage.TabIndex = 1;
            this.tabGoalPage.Text = "Goals";
            this.tabGoalPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gpTargetCalories);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvGoals);
            this.splitContainer2.Size = new System.Drawing.Size(786, 357);
            this.splitContainer2.SplitterDistance = 325;
            this.splitContainer2.TabIndex = 0;
            // 
            // gpTargetCalories
            // 
            this.gpTargetCalories.Controls.Add(this.txtGoalName);
            this.gpTargetCalories.Controls.Add(this.txtTargetCalories);
            this.gpTargetCalories.Controls.Add(this.btnSave);
            this.gpTargetCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTargetCalories.Location = new System.Drawing.Point(42, 69);
            this.gpTargetCalories.Name = "gpTargetCalories";
            this.gpTargetCalories.Size = new System.Drawing.Size(224, 181);
            this.gpTargetCalories.TabIndex = 21;
            this.gpTargetCalories.TabStop = false;
            this.gpTargetCalories.Text = "Target Calories";
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(17, 89);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(184, 20);
            this.txtGoalName.TabIndex = 21;
            // 
            // txtTargetCalories
            // 
            this.txtTargetCalories.Location = new System.Drawing.Point(17, 52);
            this.txtTargetCalories.Name = "txtTargetCalories";
            this.txtTargetCalories.Size = new System.Drawing.Size(184, 20);
            this.txtTargetCalories.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSave.Image = global::FitnessTracker.Desktop.Properties.Resources.icons8_save_24;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(91, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please set your goal";
            // 
            // dgvGoals
            // 
            this.dgvGoals.AllowUserToAddRows = false;
            this.dgvGoals.AllowUserToDeleteRows = false;
            this.dgvGoals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoals.Location = new System.Drawing.Point(0, 0);
            this.dgvGoals.Name = "dgvGoals";
            this.dgvGoals.ReadOnly = true;
            this.dgvGoals.Size = new System.Drawing.Size(457, 357);
            this.dgvGoals.TabIndex = 1;
            // 
            // tabPageTracking
            // 
            this.tabPageTracking.Controls.Add(this.splitContainer3);
            this.tabPageTracking.Location = new System.Drawing.Point(4, 22);
            this.tabPageTracking.Name = "tabPageTracking";
            this.tabPageTracking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTracking.Size = new System.Drawing.Size(792, 363);
            this.tabPageTracking.TabIndex = 2;
            this.tabPageTracking.Text = "Tracking";
            this.tabPageTracking.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgvTrackings);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.cboTargetGoal);
            this.splitContainer3.Panel2.Controls.Add(this.btnSaveTracking);
            this.splitContainer3.Panel2.Controls.Add(this.txtBurnedCalories);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Panel2.Controls.Add(this.gbRequired);
            this.splitContainer3.Panel2.Controls.Add(this.label2);
            this.splitContainer3.Size = new System.Drawing.Size(786, 357);
            this.splitContainer3.SplitterDistance = 116;
            this.splitContainer3.TabIndex = 0;
            // 
            // dgvTrackings
            // 
            this.dgvTrackings.AllowUserToAddRows = false;
            this.dgvTrackings.AllowUserToDeleteRows = false;
            this.dgvTrackings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrackings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrackings.Location = new System.Drawing.Point(0, 0);
            this.dgvTrackings.Name = "dgvTrackings";
            this.dgvTrackings.ReadOnly = true;
            this.dgvTrackings.Size = new System.Drawing.Size(786, 116);
            this.dgvTrackings.TabIndex = 0;
            // 
            // cboTargetGoal
            // 
            this.cboTargetGoal.FormattingEnabled = true;
            this.cboTargetGoal.Location = new System.Drawing.Point(609, 23);
            this.cboTargetGoal.Name = "cboTargetGoal";
            this.cboTargetGoal.Size = new System.Drawing.Size(121, 21);
            this.cboTargetGoal.TabIndex = 25;
            // 
            // btnSaveTracking
            // 
            this.btnSaveTracking.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveTracking.Enabled = false;
            this.btnSaveTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSaveTracking.Image = global::FitnessTracker.Desktop.Properties.Resources.icons8_save_24;
            this.btnSaveTracking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTracking.Location = new System.Drawing.Point(619, 115);
            this.btnSaveTracking.Name = "btnSaveTracking";
            this.btnSaveTracking.Size = new System.Drawing.Size(110, 33);
            this.btnSaveTracking.TabIndex = 22;
            this.btnSaveTracking.Text = "Save";
            this.btnSaveTracking.UseVisualStyleBackColor = false;
            this.btnSaveTracking.Click += new System.EventHandler(this.btnSaveTracking_Click);
            // 
            // txtBurnedCalories
            // 
            this.txtBurnedCalories.Location = new System.Drawing.Point(609, 54);
            this.txtBurnedCalories.Name = "txtBurnedCalories";
            this.txtBurnedCalories.ReadOnly = true;
            this.txtBurnedCalories.Size = new System.Drawing.Size(120, 20);
            this.txtBurnedCalories.TabIndex = 4;
            this.txtBurnedCalories.TextChanged += new System.EventHandler(this.txtBurnedCalories_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Burned Calories";
            // 
            // gbRequired
            // 
            this.gbRequired.Controls.Add(this.txtUserWeight);
            this.gbRequired.Controls.Add(this.label5);
            this.gbRequired.Controls.Add(this.label4);
            this.gbRequired.Controls.Add(this.cboActivities);
            this.gbRequired.Controls.Add(this.txtMet);
            this.gbRequired.Controls.Add(this.lblMet);
            this.gbRequired.Controls.Add(this.btnCalculate);
            this.gbRequired.Controls.Add(this.txtMetric3);
            this.gbRequired.Controls.Add(this.lblMetric3);
            this.gbRequired.Controls.Add(this.txtMetric2);
            this.gbRequired.Controls.Add(this.lblMetric2);
            this.gbRequired.Controls.Add(this.txtMetric1);
            this.gbRequired.Controls.Add(this.lblMetric1);
            this.gbRequired.Location = new System.Drawing.Point(22, 23);
            this.gbRequired.Name = "gbRequired";
            this.gbRequired.Size = new System.Drawing.Size(396, 194);
            this.gbRequired.TabIndex = 2;
            this.gbRequired.TabStop = false;
            this.gbRequired.Text = "Required";
            // 
            // txtUserWeight
            // 
            this.txtUserWeight.Location = new System.Drawing.Point(261, 155);
            this.txtUserWeight.Name = "txtUserWeight";
            this.txtUserWeight.ReadOnly = true;
            this.txtUserWeight.Size = new System.Drawing.Size(120, 20);
            this.txtUserWeight.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Weight ( kg )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Selected Activity";
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(17, 57);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(121, 21);
            this.cboActivities.TabIndex = 24;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged);
            // 
            // txtMet
            // 
            this.txtMet.Location = new System.Drawing.Point(261, 120);
            this.txtMet.Name = "txtMet";
            this.txtMet.Size = new System.Drawing.Size(120, 20);
            this.txtMet.TabIndex = 23;
            // 
            // lblMet
            // 
            this.lblMet.AutoSize = true;
            this.lblMet.Location = new System.Drawing.Point(177, 123);
            this.lblMet.Name = "lblMet";
            this.lblMet.Size = new System.Drawing.Size(30, 13);
            this.lblMet.TabIndex = 22;
            this.lblMet.Text = "MET";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Transparent;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnCalculate.Image = global::FitnessTracker.Desktop.Properties.Resources.icons8_save_24;
            this.btnCalculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Location = new System.Drawing.Point(17, 107);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 33);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtMetric3
            // 
            this.txtMetric3.Location = new System.Drawing.Point(261, 89);
            this.txtMetric3.Name = "txtMetric3";
            this.txtMetric3.Size = new System.Drawing.Size(120, 20);
            this.txtMetric3.TabIndex = 7;
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Location = new System.Drawing.Point(177, 92);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(45, 13);
            this.lblMetric3.TabIndex = 6;
            this.lblMetric3.Text = "Metric 3";
            // 
            // txtMetric2
            // 
            this.txtMetric2.Location = new System.Drawing.Point(261, 57);
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(120, 20);
            this.txtMetric2.TabIndex = 5;
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Location = new System.Drawing.Point(177, 60);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(45, 13);
            this.lblMetric2.TabIndex = 4;
            this.lblMetric2.Text = "Metric 2";
            // 
            // txtMetric1
            // 
            this.txtMetric1.Location = new System.Drawing.Point(261, 28);
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(120, 20);
            this.txtMetric1.TabIndex = 3;
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Location = new System.Drawing.Point(177, 31);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(45, 13);
            this.lblMetric1.TabIndex = 2;
            this.lblMetric1.Text = "Metric 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Target Calories";
            // 
            // FrmUserDashBorad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmUserDashBorad";
            this.Text = "FrmDashBorad";
            this.Load += new System.EventHandler(this.FrmDashBorad_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tabGoalPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gpTargetCalories.ResumeLayout(false);
            this.gpTargetCalories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).EndInit();
            this.tabPageTracking.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackings)).EndInit();
            this.gbRequired.ResumeLayout(false);
            this.gbRequired.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.TabControl tabMainPage;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabGoalPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTargetCalories;
        private System.Windows.Forms.DataGridView dgvGoals;
        private System.Windows.Forms.GroupBox gpTargetCalories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPageTracking;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gbRequired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBurnedCalories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMetric3;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtMet;
        private System.Windows.Forms.Label lblMet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Button btnSaveTracking;
        private System.Windows.Forms.DataGridView dgvTrackings;
        private System.Windows.Forms.TextBox txtUserWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTargetGoal;
        private System.Windows.Forms.TextBox txtGoalName;
    }
}