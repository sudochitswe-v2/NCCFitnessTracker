namespace FitnessTracker.Desktop.Presentation.Forms
{
    partial class FrmAdminDashBoard
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
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.tabMainPage = new System.Windows.Forms.TabControl();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.tabActivity = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.tabActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.SuspendLayout();
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.TabIndex = 1;
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
            this.tabMainPage.Controls.Add(this.tabAccounts);
            this.tabMainPage.Controls.Add(this.tabActivity);
            this.tabMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainPage.Location = new System.Drawing.Point(0, 0);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.SelectedIndex = 0;
            this.tabMainPage.Size = new System.Drawing.Size(800, 389);
            this.tabMainPage.TabIndex = 0;
            // 
            // tabAccounts
            // 
            this.tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccounts.Size = new System.Drawing.Size(792, 363);
            this.tabAccounts.TabIndex = 1;
            this.tabAccounts.Text = "Accounts";
            this.tabAccounts.UseVisualStyleBackColor = true;
            // 
            // tabActivity
            // 
            this.tabActivity.Controls.Add(this.splitContainer2);
            this.tabActivity.Location = new System.Drawing.Point(4, 22);
            this.tabActivity.Name = "tabActivity";
            this.tabActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabActivity.Size = new System.Drawing.Size(792, 363);
            this.tabActivity.TabIndex = 2;
            this.tabActivity.Text = "Activities";
            this.tabActivity.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnSave);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvActivity);
            this.splitContainer2.Size = new System.Drawing.Size(786, 357);
            this.splitContainer2.SplitterDistance = 262;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(60, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Metric3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Metric2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Metric1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Activity Name";
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivity.Location = new System.Drawing.Point(0, 0);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.Size = new System.Drawing.Size(520, 357);
            this.dgvActivity.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.btnSave.Image = global::FitnessTracker.Desktop.Properties.Resources.login_x32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(127, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 38);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // FrmAdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAdminDashBoard";
            this.Text = "FrmAdminDashBoard";
            this.Load += new System.EventHandler(this.FrmAdminDashBoard_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tabActivity.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label txtWelcome;
        private System.Windows.Forms.TabControl tabMainPage;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.TabPage tabActivity;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Button btnSave;
    }
}