﻿namespace BeautyForestAgent
{
    partial class FormMemo
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
            this.Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMode = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLoadText = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnLoadFileSelect = new System.Windows.Forms.Button();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtSaveText = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSaveFileSelect = new System.Windows.Forms.Button();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.loadFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.Status.SuspendLayout();
            this.tabMode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.Status.Location = new System.Drawing.Point(0, 319);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(485, 22);
            this.Status.SizingGrip = false;
            this.Status.TabIndex = 0;
            this.Status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "3113 이유정 - 파일 읽고 쓰기";
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.tabPage1);
            this.tabMode.Controls.Add(this.tabPage2);
            this.tabMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMode.Location = new System.Drawing.Point(0, 0);
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(485, 319);
            this.tabMode.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLoadText);
            this.tabPage1.Controls.Add(this.btnLoadFile);
            this.tabPage1.Controls.Add(this.btnLoadFileSelect);
            this.tabPage1.Controls.Add(this.txtLoadFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "파일 읽기";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLoadText
            // 
            this.txtLoadText.Location = new System.Drawing.Point(6, 33);
            this.txtLoadText.Multiline = true;
            this.txtLoadText.Name = "txtLoadText";
            this.txtLoadText.ReadOnly = true;
            this.txtLoadText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLoadText.Size = new System.Drawing.Size(463, 254);
            this.txtLoadText.TabIndex = 3;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(389, 3);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(82, 23);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "불러오기";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // btnLoadFileSelect
            // 
            this.btnLoadFileSelect.Location = new System.Drawing.Point(281, 4);
            this.btnLoadFileSelect.Name = "btnLoadFileSelect";
            this.btnLoadFileSelect.Size = new System.Drawing.Size(102, 23);
            this.btnLoadFileSelect.TabIndex = 1;
            this.btnLoadFileSelect.Text = "파일 선택";
            this.btnLoadFileSelect.UseVisualStyleBackColor = true;
            this.btnLoadFileSelect.Click += new System.EventHandler(this.BtnLoadFileSelect_Click);
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(8, 6);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.ReadOnly = true;
            this.txtLoadFile.Size = new System.Drawing.Size(267, 21);
            this.txtLoadFile.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSaveText);
            this.tabPage2.Controls.Add(this.btnSaveFile);
            this.tabPage2.Controls.Add(this.btnSaveFileSelect);
            this.tabPage2.Controls.Add(this.txtSaveFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "파일 쓰기";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSaveText
            // 
            this.txtSaveText.Location = new System.Drawing.Point(9, 35);
            this.txtSaveText.Multiline = true;
            this.txtSaveText.Name = "txtSaveText";
            this.txtSaveText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSaveText.Size = new System.Drawing.Size(460, 252);
            this.txtSaveText.TabIndex = 3;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(386, 6);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(83, 23);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "저장하기";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
            // 
            // btnSaveFileSelect
            // 
            this.btnSaveFileSelect.Location = new System.Drawing.Point(297, 7);
            this.btnSaveFileSelect.Name = "btnSaveFileSelect";
            this.btnSaveFileSelect.Size = new System.Drawing.Size(82, 23);
            this.btnSaveFileSelect.TabIndex = 1;
            this.btnSaveFileSelect.Text = "파일 읽기";
            this.btnSaveFileSelect.UseVisualStyleBackColor = true;
            this.btnSaveFileSelect.Click += new System.EventHandler(this.BtnSaveFileSelect_Click);
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(9, 7);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.ReadOnly = true;
            this.txtSaveFile.Size = new System.Drawing.Size(282, 21);
            this.txtSaveFile.TabIndex = 0;
            // 
            // loadFileDlg
            // 
            this.loadFileDlg.FileName = "openFileDialog1";
            this.loadFileDlg.Filter = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 341);
            this.Controls.Add(this.tabMode);
            this.Controls.Add(this.Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMemo";
            this.Text = "3113 이유정";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.tabMode.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtLoadText;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnLoadFileSelect;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtSaveText;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSaveFileSelect;
        private System.Windows.Forms.TextBox txtSaveFile;
        private System.Windows.Forms.OpenFileDialog loadFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
    }
}