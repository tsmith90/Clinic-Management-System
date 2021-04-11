﻿
namespace ClinicSupport.UserControls
{
    partial class EmployeePrivilegesUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.findUserButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.privilegesComboBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.privilegesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.findUserButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.errorLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.privilegesComboBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.updateButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.privilegesLabel, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(56, 34);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(94, 26);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username: ";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(156, 37);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(242, 26);
            this.usernameTextBox.TabIndex = 1;
            // 
            // findUserButton
            // 
            this.findUserButton.Location = new System.Drawing.Point(404, 37);
            this.findUserButton.Name = "findUserButton";
            this.findUserButton.Size = new System.Drawing.Size(117, 26);
            this.findUserButton.TabIndex = 2;
            this.findUserButton.Text = "Find User";
            this.findUserButton.UseVisualStyleBackColor = true;
            this.findUserButton.Click += new System.EventHandler(this.FindUserButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(156, 242);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(242, 34);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // privilegesComboBox
            // 
            this.privilegesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privilegesComboBox.FormattingEnabled = true;
            this.privilegesComboBox.Location = new System.Drawing.Point(156, 114);
            this.privilegesComboBox.Name = "privilegesComboBox";
            this.privilegesComboBox.Size = new System.Drawing.Size(242, 28);
            this.privilegesComboBox.TabIndex = 4;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(404, 114);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(117, 28);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // privilegesLabel
            // 
            this.privilegesLabel.Location = new System.Drawing.Point(56, 111);
            this.privilegesLabel.Name = "privilegesLabel";
            this.privilegesLabel.Size = new System.Drawing.Size(94, 31);
            this.privilegesLabel.TabIndex = 6;
            this.privilegesLabel.Text = "Privileges:";
            this.privilegesLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // EmployeePrivilegesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeePrivilegesUserControl";
            this.Size = new System.Drawing.Size(570, 333);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button findUserButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox privilegesComboBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label privilegesLabel;
    }
}
