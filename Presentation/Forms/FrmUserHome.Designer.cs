namespace FitnessTracker.Desktop.Presentation.Forms
{
    partial class FrmUserHome
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gpTargetCalories = new System.Windows.Forms.GroupBox();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.txtTargetCalories = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGoals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gpTargetCalories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).BeginInit();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.txtWelcome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtWelcome
            // 
            this.txtWelcome.BackColor = System.Drawing.Color.Transparent;
            this.txtWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.txtWelcome.Location = new System.Drawing.Point(22, 34);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(757, 25);
            this.txtWelcome.TabIndex = 3;
            this.txtWelcome.Text = "Welcome Text";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer2.Size = new System.Drawing.Size(800, 354);
            this.splitContainer2.SplitterDistance = 266;
            this.splitContainer2.TabIndex = 0;
            // 
            // gpTargetCalories
            // 
            this.gpTargetCalories.Controls.Add(this.txtGoalName);
            this.gpTargetCalories.Controls.Add(this.txtTargetCalories);
            this.gpTargetCalories.Controls.Add(this.btnSave);
            this.gpTargetCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTargetCalories.Location = new System.Drawing.Point(23, 103);
            this.gpTargetCalories.Name = "gpTargetCalories";
            this.gpTargetCalories.Size = new System.Drawing.Size(224, 181);
            this.gpTargetCalories.TabIndex = 23;
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
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 22;
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
            this.dgvGoals.Size = new System.Drawing.Size(530, 354);
            this.dgvGoals.TabIndex = 2;
            this.dgvGoals.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoals_CellDoubleClick);
            // 
            // FrmUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmUserHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmUserHome_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gpTargetCalories.ResumeLayout(false);
            this.gpTargetCalories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gpTargetCalories;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.TextBox txtTargetCalories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGoals;
    }
}