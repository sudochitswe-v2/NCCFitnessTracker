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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
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
            this.tabMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainPage.Location = new System.Drawing.Point(0, 0);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.SelectedIndex = 0;
            this.tabMainPage.Size = new System.Drawing.Size(800, 389);
            this.tabMainPage.TabIndex = 0;
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
            this.tabGoalPage.Location = new System.Drawing.Point(4, 22);
            this.tabGoalPage.Name = "tabGoalPage";
            this.tabGoalPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabGoalPage.Size = new System.Drawing.Size(792, 363);
            this.tabGoalPage.TabIndex = 1;
            this.tabGoalPage.Text = "Goals";
            this.tabGoalPage.UseVisualStyleBackColor = true;
            // 
            // FrmDashBorad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmDashBorad";
            this.Text = "FrmDashBorad";
            this.Load += new System.EventHandler(this.FrmDashBorad_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.TabControl tabMainPage;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabGoalPage;
    }
}