﻿namespace Kuriimu2_WinForms.MainForms
{
    partial class Batch
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
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.txtBatchInputDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtBatchOutputDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBatchType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBatchMethod = new System.Windows.Forms.ComboBox();
            this.btnBatchProcess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBatchVariant = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInput.Location = new System.Drawing.Point(393, 11);
            this.btnBrowseInput.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(106, 20);
            this.btnBrowseInput.TabIndex = 20;
            this.btnBrowseInput.Text = "Browse Input...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.BtnBrowseInput_Click);
            // 
            // txtBatchInputDirectory
            // 
            this.txtBatchInputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchInputDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.txtBatchInputDirectory.Location = new System.Drawing.Point(89, 11);
            this.txtBatchInputDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatchInputDirectory.Name = "txtBatchInputDirectory";
            this.txtBatchInputDirectory.ReadOnly = true;
            this.txtBatchInputDirectory.Size = new System.Drawing.Size(296, 20);
            this.txtBatchInputDirectory.TabIndex = 18;
            this.txtBatchInputDirectory.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Batch from:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(393, 37);
            this.btnBrowseOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(106, 20);
            this.btnBrowseOutput.TabIndex = 22;
            this.btnBrowseOutput.Text = "Browse Output...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.BtnBrowseOutput_Click);
            // 
            // txtBatchOutputDirectory
            // 
            this.txtBatchOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchOutputDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.txtBatchOutputDirectory.Location = new System.Drawing.Point(89, 37);
            this.txtBatchOutputDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatchOutputDirectory.Name = "txtBatchOutputDirectory";
            this.txtBatchOutputDirectory.ReadOnly = true;
            this.txtBatchOutputDirectory.Size = new System.Drawing.Size(296, 20);
            this.txtBatchOutputDirectory.TabIndex = 21;
            this.txtBatchOutputDirectory.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Batch to:";
            // 
            // cmbBatchType
            // 
            this.cmbBatchType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBatchType.FormattingEnabled = true;
            this.cmbBatchType.Location = new System.Drawing.Point(89, 64);
            this.cmbBatchType.Name = "cmbBatchType";
            this.cmbBatchType.Size = new System.Drawing.Size(410, 21);
            this.cmbBatchType.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Batch Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Batch Method:";
            // 
            // cmbBatchMethod
            // 
            this.cmbBatchMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBatchMethod.FormattingEnabled = true;
            this.cmbBatchMethod.Location = new System.Drawing.Point(88, 118);
            this.cmbBatchMethod.Name = "cmbBatchMethod";
            this.cmbBatchMethod.Size = new System.Drawing.Size(411, 21);
            this.cmbBatchMethod.TabIndex = 27;
            // 
            // btnBatchProcess
            // 
            this.btnBatchProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchProcess.Location = new System.Drawing.Point(11, 145);
            this.btnBatchProcess.Name = "btnBatchProcess";
            this.btnBatchProcess.Size = new System.Drawing.Size(488, 23);
            this.btnBatchProcess.TabIndex = 28;
            this.btnBatchProcess.Text = "Process";
            this.btnBatchProcess.UseVisualStyleBackColor = true;
            this.btnBatchProcess.Click += new System.EventHandler(this.BtnBatchProcess_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Batch Variant:";
            // 
            // cmbBatchVariant
            // 
            this.cmbBatchVariant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBatchVariant.FormattingEnabled = true;
            this.cmbBatchVariant.Location = new System.Drawing.Point(89, 91);
            this.cmbBatchVariant.Name = "cmbBatchVariant";
            this.cmbBatchVariant.Size = new System.Drawing.Size(410, 21);
            this.cmbBatchVariant.TabIndex = 30;
            // 
            // Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.cmbBatchVariant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBatchProcess);
            this.Controls.Add(this.cmbBatchMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBatchType);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtBatchInputDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtBatchOutputDirectory);
            this.Controls.Add(this.label1);
            this.Name = "Batch";
            this.Text = "Batch Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.TextBox txtBatchInputDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtBatchOutputDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBatchType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBatchMethod;
        private System.Windows.Forms.Button btnBatchProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBatchVariant;
    }
}