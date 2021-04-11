﻿
namespace ClinicSupport.View
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.employeeTabPage = new System.Windows.Forms.TabPage();
            this.privilegeTabPage = new System.Windows.Forms.TabPage();
            this.employeePrivilegesUserControl1 = new ClinicSupport.UserControls.EmployeePrivilegesUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.adminTabControl.SuspendLayout();
            this.privilegeTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 582F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.logoutLinkLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.adminTabControl, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(796, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(585, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 24);
            this.nameLabel.TabIndex = 0;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(698, 20);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(95, 23);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "Logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // adminTabControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.adminTabControl, 3);
            this.adminTabControl.Controls.Add(this.employeeTabPage);
            this.adminTabControl.Controls.Add(this.privilegeTabPage);
            this.adminTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTabControl.Location = new System.Drawing.Point(3, 49);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(790, 393);
            this.adminTabControl.TabIndex = 2;
            // 
            // employeeTabPage
            // 
            this.employeeTabPage.Location = new System.Drawing.Point(4, 29);
            this.employeeTabPage.Name = "employeeTabPage";
            this.employeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTabPage.Size = new System.Drawing.Size(782, 360);
            this.employeeTabPage.TabIndex = 0;
            this.employeeTabPage.Text = "Employee Information";
            this.employeeTabPage.UseVisualStyleBackColor = true;
            // 
            // privilegeTabPage
            // 
            this.privilegeTabPage.Controls.Add(this.employeePrivilegesUserControl1);
            this.privilegeTabPage.Location = new System.Drawing.Point(4, 29);
            this.privilegeTabPage.Name = "privilegeTabPage";
            this.privilegeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.privilegeTabPage.Size = new System.Drawing.Size(782, 360);
            this.privilegeTabPage.TabIndex = 1;
            this.privilegeTabPage.Text = "Employee Privileges";
            this.privilegeTabPage.UseVisualStyleBackColor = true;
            // 
            // employeePrivilegesUserControl1
            // 
            this.employeePrivilegesUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePrivilegesUserControl1.Location = new System.Drawing.Point(115, 19);
            this.employeePrivilegesUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeePrivilegesUserControl1.Name = "employeePrivilegesUserControl1";
            this.employeePrivilegesUserControl1.Size = new System.Drawing.Size(570, 333);
            this.employeePrivilegesUserControl1.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.adminTabControl.ResumeLayout(false);
            this.privilegeTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage employeeTabPage;
        private System.Windows.Forms.TabPage privilegeTabPage;
        private UserControls.EmployeePrivilegesUserControl employeePrivilegesUserControl1;
    }
}