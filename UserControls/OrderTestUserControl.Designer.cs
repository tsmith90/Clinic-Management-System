﻿namespace ClinicSupport.UserControls
{
    partial class OrderTestUserControl
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
            this.orderTestTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.testOrderLabel = new System.Windows.Forms.Label();
            this.dateTakenLabel = new System.Windows.Forms.Label();
            this.dateReturnedLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.normalLabel = new System.Windows.Forms.Label();
            this.testComboBox = new System.Windows.Forms.ComboBox();
            this.dateTakenTextBox = new System.Windows.Forms.TextBox();
            this.dateReturnedTextBox = new System.Windows.Forms.TextBox();
            this.resultTextArea = new System.Windows.Forms.TextBox();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.updateTestButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderTestTitleLabel
            // 
            this.orderTestTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTestTitleLabel.AutoSize = true;
            this.orderTestTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTestTitleLabel.Location = new System.Drawing.Point(386, 16);
            this.orderTestTitleLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.orderTestTitleLabel.Name = "orderTestTitleLabel";
            this.orderTestTitleLabel.Size = new System.Drawing.Size(286, 46);
            this.orderTestTitleLabel.TabIndex = 0;
            this.orderTestTitleLabel.Text = "Order Lab Test";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.orderTestTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1059, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.04721F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.95279F));
            this.tableLayoutPanel2.Controls.Add(this.testOrderLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTakenLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateReturnedLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.normalLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.testComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dateTakenTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dateReturnedTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.resultTextArea, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.yesRadioButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.resultLabel, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1059, 529);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // testOrderLabel
            // 
            this.testOrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.testOrderLabel.AutoSize = true;
            this.testOrderLabel.Location = new System.Drawing.Point(334, 33);
            this.testOrderLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.testOrderLabel.Name = "testOrderLabel";
            this.testOrderLabel.Size = new System.Drawing.Size(188, 32);
            this.testOrderLabel.TabIndex = 0;
            this.testOrderLabel.Text = "Test to Order:";
            // 
            // dateTakenLabel
            // 
            this.dateTakenLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTakenLabel.AutoSize = true;
            this.dateTakenLabel.Location = new System.Drawing.Point(353, 129);
            this.dateTakenLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dateTakenLabel.Name = "dateTakenLabel";
            this.dateTakenLabel.Size = new System.Drawing.Size(169, 32);
            this.dateTakenLabel.TabIndex = 1;
            this.dateTakenLabel.Text = "Date Taken:";
            // 
            // dateReturnedLabel
            // 
            this.dateReturnedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateReturnedLabel.AutoSize = true;
            this.dateReturnedLabel.Location = new System.Drawing.Point(315, 216);
            this.dateReturnedLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.dateReturnedLabel.Name = "dateReturnedLabel";
            this.dateReturnedLabel.Size = new System.Drawing.Size(207, 32);
            this.dateReturnedLabel.TabIndex = 2;
            this.dateReturnedLabel.Text = "Date Returned:";
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(418, 272);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(104, 32);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Result:";
            // 
            // normalLabel
            // 
            this.normalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.normalLabel.AutoSize = true;
            this.normalLabel.Location = new System.Drawing.Point(408, 467);
            this.normalLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.normalLabel.Name = "normalLabel";
            this.normalLabel.Size = new System.Drawing.Size(114, 32);
            this.normalLabel.TabIndex = 4;
            this.normalLabel.Text = "Normal:";
            // 
            // testComboBox
            // 
            this.testComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.testComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testComboBox.FormattingEnabled = true;
            this.testComboBox.Location = new System.Drawing.Point(538, 30);
            this.testComboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.testComboBox.Name = "testComboBox";
            this.testComboBox.Size = new System.Drawing.Size(316, 39);
            this.testComboBox.TabIndex = 5;
            // 
            // dateTakenTextBox
            // 
            this.dateTakenTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTakenTextBox.Location = new System.Drawing.Point(538, 126);
            this.dateTakenTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTakenTextBox.Name = "dateTakenTextBox";
            this.dateTakenTextBox.Size = new System.Drawing.Size(316, 38);
            this.dateTakenTextBox.TabIndex = 6;
            // 
            // dateReturnedTextBox
            // 
            this.dateReturnedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateReturnedTextBox.Location = new System.Drawing.Point(538, 213);
            this.dateReturnedTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateReturnedTextBox.Name = "dateReturnedTextBox";
            this.dateReturnedTextBox.Size = new System.Drawing.Size(316, 38);
            this.dateReturnedTextBox.TabIndex = 7;
            // 
            // resultTextArea
            // 
            this.resultTextArea.Location = new System.Drawing.Point(538, 279);
            this.resultTextArea.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.resultTextArea.Multiline = true;
            this.resultTextArea.Name = "resultTextArea";
            this.resultTextArea.Size = new System.Drawing.Size(316, 126);
            this.resultTextArea.TabIndex = 8;
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(538, 465);
            this.yesRadioButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(101, 36);
            this.yesRadioButton.TabIndex = 9;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.orderTestButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.updateTestButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cancelButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 679);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1059, 114);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // orderTestButton
            // 
            this.orderTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderTestButton.Location = new System.Drawing.Point(429, 29);
            this.orderTestButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(200, 55);
            this.orderTestButton.TabIndex = 0;
            this.orderTestButton.Text = "Order";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.OrderTestButton_Click);
            // 
            // updateTestButton
            // 
            this.updateTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateTestButton.Location = new System.Drawing.Point(76, 29);
            this.updateTestButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.updateTestButton.Name = "updateTestButton";
            this.updateTestButton.Size = new System.Drawing.Size(200, 55);
            this.updateTestButton.TabIndex = 1;
            this.updateTestButton.Text = "Update";
            this.updateTestButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Location = new System.Drawing.Point(782, 29);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 55);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(128, 823);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 32);
            this.messageLabel.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 78);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(0, 32);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderTestUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "OrderTestUserControl";
            this.Size = new System.Drawing.Size(1059, 971);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderTestTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label testOrderLabel;
        private System.Windows.Forms.Label dateTakenLabel;
        private System.Windows.Forms.Label dateReturnedLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.ComboBox testComboBox;
        private System.Windows.Forms.TextBox dateTakenTextBox;
        private System.Windows.Forms.TextBox dateReturnedTextBox;
        private System.Windows.Forms.TextBox resultTextArea;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.Button updateTestButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}