
namespace FileCheck
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckedListBox_CheckField = new System.Windows.Forms.CheckedListBox();
            this.Label_CheckListTitle = new System.Windows.Forms.Label();
            this.Label_GetSample = new System.Windows.Forms.Label();
            this.Button_Sample = new System.Windows.Forms.Button();
            this.Button_Examine = new System.Windows.Forms.Button();
            this.Label_SamplePath = new System.Windows.Forms.Label();
            this.Label_ExaminePath = new System.Windows.Forms.Label();
            this.Label_Line1 = new System.Windows.Forms.Label();
            this.Button_Action = new System.Windows.Forms.Button();
            this.DataGridView_Result = new System.Windows.Forms.DataGridView();
            this.TextBox_ColumnCount = new System.Windows.Forms.TextBox();
            this.Label_ColumnCount = new System.Windows.Forms.Label();
            this.Button_Remit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_RemitPath = new System.Windows.Forms.Label();
            this.CheckBox_AutoSize = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckedListBox_CheckField
            // 
            this.CheckedListBox_CheckField.FormattingEnabled = true;
            this.CheckedListBox_CheckField.Location = new System.Drawing.Point(21, 160);
            this.CheckedListBox_CheckField.Name = "CheckedListBox_CheckField";
            this.CheckedListBox_CheckField.Size = new System.Drawing.Size(158, 446);
            this.CheckedListBox_CheckField.TabIndex = 0;
            // 
            // Label_CheckListTitle
            // 
            this.Label_CheckListTitle.AutoSize = true;
            this.Label_CheckListTitle.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_CheckListTitle.Location = new System.Drawing.Point(12, 128);
            this.Label_CheckListTitle.Name = "Label_CheckListTitle";
            this.Label_CheckListTitle.Size = new System.Drawing.Size(198, 20);
            this.Label_CheckListTitle.TabIndex = 1;
            this.Label_CheckListTitle.Text = "選擇想要檢查的欄位";
            // 
            // Label_GetSample
            // 
            this.Label_GetSample.AutoSize = true;
            this.Label_GetSample.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold);
            this.Label_GetSample.Location = new System.Drawing.Point(17, 28);
            this.Label_GetSample.Name = "Label_GetSample";
            this.Label_GetSample.Size = new System.Drawing.Size(198, 20);
            this.Label_GetSample.TabIndex = 2;
            this.Label_GetSample.Text = "選擇想要檢查的文件";
            // 
            // Button_Sample
            // 
            this.Button_Sample.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Sample.Location = new System.Drawing.Point(221, 12);
            this.Button_Sample.Name = "Button_Sample";
            this.Button_Sample.Size = new System.Drawing.Size(75, 23);
            this.Button_Sample.TabIndex = 3;
            this.Button_Sample.Text = "標準";
            this.Button_Sample.UseVisualStyleBackColor = true;
            this.Button_Sample.Click += new System.EventHandler(this.Button_Sample_Click);
            // 
            // Button_Examine
            // 
            this.Button_Examine.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Examine.Location = new System.Drawing.Point(221, 41);
            this.Button_Examine.Name = "Button_Examine";
            this.Button_Examine.Size = new System.Drawing.Size(75, 23);
            this.Button_Examine.TabIndex = 4;
            this.Button_Examine.Text = "檢查";
            this.Button_Examine.UseVisualStyleBackColor = true;
            this.Button_Examine.Click += new System.EventHandler(this.Button_Examine_Click);
            // 
            // Label_SamplePath
            // 
            this.Label_SamplePath.AutoSize = true;
            this.Label_SamplePath.Location = new System.Drawing.Point(302, 17);
            this.Label_SamplePath.Name = "Label_SamplePath";
            this.Label_SamplePath.Size = new System.Drawing.Size(33, 12);
            this.Label_SamplePath.TabIndex = 5;
            this.Label_SamplePath.Text = "label1";
            // 
            // Label_ExaminePath
            // 
            this.Label_ExaminePath.AutoSize = true;
            this.Label_ExaminePath.Location = new System.Drawing.Point(302, 46);
            this.Label_ExaminePath.Name = "Label_ExaminePath";
            this.Label_ExaminePath.Size = new System.Drawing.Size(33, 12);
            this.Label_ExaminePath.TabIndex = 6;
            this.Label_ExaminePath.Text = "label2";
            // 
            // Label_Line1
            // 
            this.Label_Line1.BackColor = System.Drawing.Color.Blue;
            this.Label_Line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Line1.Location = new System.Drawing.Point(33, 76);
            this.Label_Line1.Name = "Label_Line1";
            this.Label_Line1.Size = new System.Drawing.Size(1167, 3);
            this.Label_Line1.TabIndex = 7;
            // 
            // Button_Action
            // 
            this.Button_Action.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Action.Location = new System.Drawing.Point(301, 92);
            this.Button_Action.Name = "Button_Action";
            this.Button_Action.Size = new System.Drawing.Size(75, 23);
            this.Button_Action.TabIndex = 8;
            this.Button_Action.Text = "開始";
            this.Button_Action.UseVisualStyleBackColor = true;
            this.Button_Action.Click += new System.EventHandler(this.Button_Action_Click);
            // 
            // DataGridView_Result
            // 
            this.DataGridView_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Result.Location = new System.Drawing.Point(221, 128);
            this.DataGridView_Result.Name = "DataGridView_Result";
            this.DataGridView_Result.RowTemplate.Height = 24;
            this.DataGridView_Result.Size = new System.Drawing.Size(1011, 456);
            this.DataGridView_Result.TabIndex = 9;
            // 
            // TextBox_ColumnCount
            // 
            this.TextBox_ColumnCount.Enabled = false;
            this.TextBox_ColumnCount.Location = new System.Drawing.Point(79, 92);
            this.TextBox_ColumnCount.Name = "TextBox_ColumnCount";
            this.TextBox_ColumnCount.Size = new System.Drawing.Size(30, 22);
            this.TextBox_ColumnCount.TabIndex = 10;
            // 
            // Label_ColumnCount
            // 
            this.Label_ColumnCount.AutoSize = true;
            this.Label_ColumnCount.Location = new System.Drawing.Point(20, 97);
            this.Label_ColumnCount.Name = "Label_ColumnCount";
            this.Label_ColumnCount.Size = new System.Drawing.Size(53, 12);
            this.Label_ColumnCount.TabIndex = 11;
            this.Label_ColumnCount.Text = "欄位數量";
            // 
            // Button_Remit
            // 
            this.Button_Remit.Location = new System.Drawing.Point(384, 92);
            this.Button_Remit.Name = "Button_Remit";
            this.Button_Remit.Size = new System.Drawing.Size(75, 23);
            this.Button_Remit.TabIndex = 12;
            this.Button_Remit.Text = "匯出(Txt)";
            this.Button_Remit.UseVisualStyleBackColor = true;
            this.Button_Remit.Click += new System.EventHandler(this.Button_Remit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(933, 596);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "藍色 => 標準有、檢查沒有 ， 黃色 => 標準沒有、檢查有";
            // 
            // Label_RemitPath
            // 
            this.Label_RemitPath.AutoSize = true;
            this.Label_RemitPath.Location = new System.Drawing.Point(465, 97);
            this.Label_RemitPath.Name = "Label_RemitPath";
            this.Label_RemitPath.Size = new System.Drawing.Size(33, 12);
            this.Label_RemitPath.TabIndex = 14;
            this.Label_RemitPath.Text = "label2";
            // 
            // CheckBox_AutoSize
            // 
            this.CheckBox_AutoSize.AutoSize = true;
            this.CheckBox_AutoSize.Checked = true;
            this.CheckBox_AutoSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_AutoSize.Font = new System.Drawing.Font("新細明體", 9F);
            this.CheckBox_AutoSize.Location = new System.Drawing.Point(124, 96);
            this.CheckBox_AutoSize.Name = "CheckBox_AutoSize";
            this.CheckBox_AutoSize.Size = new System.Drawing.Size(140, 16);
            this.CheckBox_AutoSize.TabIndex = 15;
            this.CheckBox_AutoSize.Text = "自動(可能比較費效能)";
            this.CheckBox_AutoSize.UseVisualStyleBackColor = true;
            this.CheckBox_AutoSize.CheckedChanged += new System.EventHandler(this.CheckBox_AutoSize_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 617);
            this.Controls.Add(this.CheckBox_AutoSize);
            this.Controls.Add(this.Label_RemitPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Remit);
            this.Controls.Add(this.Label_ColumnCount);
            this.Controls.Add(this.TextBox_ColumnCount);
            this.Controls.Add(this.DataGridView_Result);
            this.Controls.Add(this.Button_Action);
            this.Controls.Add(this.Label_Line1);
            this.Controls.Add(this.Label_ExaminePath);
            this.Controls.Add(this.Label_SamplePath);
            this.Controls.Add(this.Button_Examine);
            this.Controls.Add(this.Button_Sample);
            this.Controls.Add(this.Label_GetSample);
            this.Controls.Add(this.Label_CheckListTitle);
            this.Controls.Add(this.CheckedListBox_CheckField);
            this.Name = "Form1";
            this.Text = "這是一個用來比對csv檔案的小程式";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBox_CheckField;
        private System.Windows.Forms.Label Label_CheckListTitle;
        private System.Windows.Forms.Label Label_GetSample;
        private System.Windows.Forms.Button Button_Sample;
        private System.Windows.Forms.Button Button_Examine;
        private System.Windows.Forms.Label Label_SamplePath;
        private System.Windows.Forms.Label Label_ExaminePath;
        private System.Windows.Forms.Label Label_Line1;
        private System.Windows.Forms.Button Button_Action;
        private System.Windows.Forms.DataGridView DataGridView_Result;
        private System.Windows.Forms.TextBox TextBox_ColumnCount;
        private System.Windows.Forms.Label Label_ColumnCount;
        private System.Windows.Forms.Button Button_Remit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_RemitPath;
        private System.Windows.Forms.CheckBox CheckBox_AutoSize;
    }
}

