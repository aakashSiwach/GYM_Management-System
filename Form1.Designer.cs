
namespace GYM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addAdminUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMemberToolStripMenuItem,
            this.newStaffToolStripMenuItem,
            this.equipmentToolStripMenuItem,
            this.searchMemberToolStripMenuItem,
            this.deleteMemberToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addAdminUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newMemberToolStripMenuItem.Image = global::GYM.Properties.Resources._3592854_add_user_business_man_employee_general_human_member_office_107767;
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.newMemberToolStripMenuItem.Text = "New Member";
            this.newMemberToolStripMenuItem.Click += new System.EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // newStaffToolStripMenuItem
            // 
            this.newStaffToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newStaffToolStripMenuItem.Image = global::GYM.Properties.Resources._3592856_general_group_office_personal_relation_team_team_structure_107770;
            this.newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            this.newStaffToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.newStaffToolStripMenuItem.Text = "New Staff";
            this.newStaffToolStripMenuItem.Click += new System.EventHandler(this.newStaffToolStripMenuItem_Click);
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.equipmentToolStripMenuItem.Image = global::GYM.Properties.Resources.dumbbell_gym_icon_124413;
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.equipmentToolStripMenuItem.Text = "Equipment";
            this.equipmentToolStripMenuItem.Click += new System.EventHandler(this.equipmentToolStripMenuItem_Click);
            // 
            // searchMemberToolStripMenuItem
            // 
            this.searchMemberToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchMemberToolStripMenuItem.Image = global::GYM.Properties.Resources._3592853_align_employee_general_human_human_list_list_member_107786;
            this.searchMemberToolStripMenuItem.Name = "searchMemberToolStripMenuItem";
            this.searchMemberToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.searchMemberToolStripMenuItem.Text = "Search Member";
            this.searchMemberToolStripMenuItem.Click += new System.EventHandler(this.searchMemberToolStripMenuItem_Click);
            // 
            // deleteMemberToolStripMenuItem
            // 
            this.deleteMemberToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.deleteMemberToolStripMenuItem.Image = global::GYM.Properties.Resources._3592821_garbage_can_general_office_recycle_bin_rubbish_bin_trash_bin_trash_can_107760;
            this.deleteMemberToolStripMenuItem.Name = "deleteMemberToolStripMenuItem";
            this.deleteMemberToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.deleteMemberToolStripMenuItem.Text = "Delete Member";
            this.deleteMemberToolStripMenuItem.Click += new System.EventHandler(this.deleteMemberToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutToolStripMenuItem.Image = global::GYM.Properties.Resources._3592828_general_key_key_lock_lock_office_password_security_107759;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.exitToolStripMenuItem.Image = global::GYM.Properties.Resources.exit_icon_icons_com_48304;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // addAdminUserToolStripMenuItem
            // 
            this.addAdminUserToolStripMenuItem.Image = global::GYM.Properties.Resources.users_icon;
            this.addAdminUserToolStripMenuItem.Name = "addAdminUserToolStripMenuItem";
            this.addAdminUserToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.addAdminUserToolStripMenuItem.Text = "Admin/User";
            this.addAdminUserToolStripMenuItem.Click += new System.EventHandler(this.addAdminUserToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Image = global::GYM.Properties.Resources.dumbbell_gym_icon_124413;
            this.label4.Location = new System.Drawing.Point(689, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(467, 110);
            this.label4.TabIndex = 7;
            this.label4.Text = "GYMS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GYM.Properties.Resources.danielle_cerullo_CQfNt66ttZM_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Form1";
            this.Text = "Gym Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addAdminUserToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}

