
namespace DuelystText
{
    partial class TranslateForm
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
            this.TransFileGridView = new System.Windows.Forms.DataGridView();
            this.orderStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unstart = new System.Windows.Forms.DataGridViewButtonColumn();
            this.diffNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opreate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TranslateGridView = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewButtonColumn();
            this.translateState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirm = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.Button();
            this.ChiRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EngLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfrimButton = new System.Windows.Forms.Button();
            this.MarkButton = new System.Windows.Forms.Button();
            this.StateCheckBoxGroup = new System.Windows.Forms.GroupBox();
            this.ConfirmCheckBox = new System.Windows.Forms.CheckBox();
            this.MarkCheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessedCheckBox = new System.Windows.Forms.CheckBox();
            this.DifferenceCheckBox = new System.Windows.Forms.CheckBox();
            this.UnStartCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchCodeBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DuplicateTextButton = new System.Windows.Forms.Button();
            this.SearchEngBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransFileGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslateGridView)).BeginInit();
            this.StateCheckBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransFileGridView
            // 
            this.TransFileGridView.AllowUserToAddRows = false;
            this.TransFileGridView.ColumnHeadersHeight = 20;
            this.TransFileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderStart,
            this.OrderEnd,
            this.Unstart,
            this.diffNum,
            this.processed,
            this.mark,
            this.opreate});
            this.TransFileGridView.Location = new System.Drawing.Point(12, 51);
            this.TransFileGridView.Name = "TransFileGridView";
            this.TransFileGridView.RowHeadersVisible = false;
            this.TransFileGridView.RowTemplate.Height = 23;
            this.TransFileGridView.Size = new System.Drawing.Size(440, 354);
            this.TransFileGridView.TabIndex = 0;
            this.TransFileGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransFileGridView_CellContentClick);
            // 
            // orderStart
            // 
            this.orderStart.HeaderText = "起始";
            this.orderStart.Name = "orderStart";
            this.orderStart.ReadOnly = true;
            this.orderStart.Width = 40;
            // 
            // OrderEnd
            // 
            this.OrderEnd.HeaderText = "结束";
            this.OrderEnd.Name = "OrderEnd";
            this.OrderEnd.ReadOnly = true;
            this.OrderEnd.Width = 40;
            // 
            // Unstart
            // 
            this.Unstart.HeaderText = "待翻译";
            this.Unstart.Name = "Unstart";
            this.Unstart.ReadOnly = true;
            this.Unstart.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Unstart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Unstart.Width = 70;
            // 
            // diffNum
            // 
            this.diffNum.HeaderText = "有变更";
            this.diffNum.Name = "diffNum";
            this.diffNum.ReadOnly = true;
            this.diffNum.Width = 70;
            // 
            // processed
            // 
            this.processed.HeaderText = "已处理";
            this.processed.Name = "processed";
            this.processed.ReadOnly = true;
            this.processed.Width = 70;
            // 
            // mark
            // 
            this.mark.HeaderText = "标记中";
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            this.mark.Width = 70;
            // 
            // opreate
            // 
            this.opreate.HeaderText = "操作";
            this.opreate.Name = "opreate";
            this.opreate.Width = 75;
            // 
            // TranslateGridView
            // 
            this.TranslateGridView.AllowUserToAddRows = false;
            this.TranslateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TranslateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.translateState,
            this.confirm,
            this.eng,
            this.chi});
            this.TranslateGridView.Location = new System.Drawing.Point(470, 51);
            this.TranslateGridView.Name = "TranslateGridView";
            this.TranslateGridView.RowHeadersVisible = false;
            this.TranslateGridView.RowTemplate.Height = 23;
            this.TranslateGridView.Size = new System.Drawing.Size(1105, 886);
            this.TranslateGridView.TabIndex = 1;
            this.TranslateGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TranslateGridView_CellContentClick);
            // 
            // code
            // 
            this.code.HeaderText = "code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.code.Width = 200;
            // 
            // translateState
            // 
            this.translateState.HeaderText = "状态";
            this.translateState.Name = "translateState";
            this.translateState.ReadOnly = true;
            this.translateState.Width = 80;
            // 
            // confirm
            // 
            this.confirm.HeaderText = "确认";
            this.confirm.Name = "confirm";
            this.confirm.Width = 70;
            // 
            // eng
            // 
            this.eng.HeaderText = "eng";
            this.eng.Name = "eng";
            this.eng.ReadOnly = true;
            this.eng.Width = 350;
            // 
            // chi
            // 
            this.chi.HeaderText = "chi";
            this.chi.Name = "chi";
            this.chi.ReadOnly = true;
            this.chi.Width = 350;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 661);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "修改";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ChiRichTextBox
            // 
            this.ChiRichTextBox.Location = new System.Drawing.Point(12, 559);
            this.ChiRichTextBox.Name = "ChiRichTextBox";
            this.ChiRichTextBox.Size = new System.Drawing.Size(440, 96);
            this.ChiRichTextBox.TabIndex = 4;
            this.ChiRichTextBox.Text = "";
            // 
            // EngLabel
            // 
            this.EngLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EngLabel.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EngLabel.Location = new System.Drawing.Point(12, 437);
            this.EngLabel.Name = "EngLabel";
            this.EngLabel.Size = new System.Drawing.Size(440, 97);
            this.EngLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "原文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "翻译";
            // 
            // ConfrimButton
            // 
            this.ConfrimButton.Location = new System.Drawing.Point(174, 661);
            this.ConfrimButton.Name = "ConfrimButton";
            this.ConfrimButton.Size = new System.Drawing.Size(75, 23);
            this.ConfrimButton.TabIndex = 8;
            this.ConfrimButton.Text = "确认";
            this.ConfrimButton.UseVisualStyleBackColor = true;
            this.ConfrimButton.Click += new System.EventHandler(this.ConfrimButton_Click);
            // 
            // MarkButton
            // 
            this.MarkButton.Location = new System.Drawing.Point(93, 661);
            this.MarkButton.Name = "MarkButton";
            this.MarkButton.Size = new System.Drawing.Size(75, 23);
            this.MarkButton.TabIndex = 9;
            this.MarkButton.Text = "标记";
            this.MarkButton.UseVisualStyleBackColor = true;
            this.MarkButton.Click += new System.EventHandler(this.MarkButton_Click);
            // 
            // StateCheckBoxGroup
            // 
            this.StateCheckBoxGroup.Controls.Add(this.ConfirmCheckBox);
            this.StateCheckBoxGroup.Controls.Add(this.MarkCheckBox);
            this.StateCheckBoxGroup.Controls.Add(this.ProcessedCheckBox);
            this.StateCheckBoxGroup.Controls.Add(this.DifferenceCheckBox);
            this.StateCheckBoxGroup.Controls.Add(this.UnStartCheckBox);
            this.StateCheckBoxGroup.Location = new System.Drawing.Point(470, 3);
            this.StateCheckBoxGroup.Name = "StateCheckBoxGroup";
            this.StateCheckBoxGroup.Size = new System.Drawing.Size(420, 42);
            this.StateCheckBoxGroup.TabIndex = 11;
            this.StateCheckBoxGroup.TabStop = false;
            this.StateCheckBoxGroup.Text = "状态选择";
            // 
            // ConfirmCheckBox
            // 
            this.ConfirmCheckBox.AutoSize = true;
            this.ConfirmCheckBox.Location = new System.Drawing.Point(345, 20);
            this.ConfirmCheckBox.Name = "ConfirmCheckBox";
            this.ConfirmCheckBox.Size = new System.Drawing.Size(60, 16);
            this.ConfirmCheckBox.TabIndex = 4;
            this.ConfirmCheckBox.Text = "已确认";
            this.ConfirmCheckBox.UseVisualStyleBackColor = true;
            this.ConfirmCheckBox.CheckedChanged += new System.EventHandler(this.ConfirmCheckBox_CheckedChanged);
            // 
            // MarkCheckBox
            // 
            this.MarkCheckBox.AutoSize = true;
            this.MarkCheckBox.Checked = true;
            this.MarkCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MarkCheckBox.Location = new System.Drawing.Point(260, 20);
            this.MarkCheckBox.Name = "MarkCheckBox";
            this.MarkCheckBox.Size = new System.Drawing.Size(60, 16);
            this.MarkCheckBox.TabIndex = 3;
            this.MarkCheckBox.Text = "标记中";
            this.MarkCheckBox.UseVisualStyleBackColor = true;
            this.MarkCheckBox.CheckedChanged += new System.EventHandler(this.MarkCheckBox_CheckedChanged);
            // 
            // ProcessedCheckBox
            // 
            this.ProcessedCheckBox.AutoSize = true;
            this.ProcessedCheckBox.Location = new System.Drawing.Point(176, 20);
            this.ProcessedCheckBox.Name = "ProcessedCheckBox";
            this.ProcessedCheckBox.Size = new System.Drawing.Size(60, 16);
            this.ProcessedCheckBox.TabIndex = 2;
            this.ProcessedCheckBox.Text = "已处理";
            this.ProcessedCheckBox.UseVisualStyleBackColor = true;
            this.ProcessedCheckBox.CheckedChanged += new System.EventHandler(this.ProcessedCheckBox_CheckedChanged);
            // 
            // DifferenceCheckBox
            // 
            this.DifferenceCheckBox.AutoSize = true;
            this.DifferenceCheckBox.Checked = true;
            this.DifferenceCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DifferenceCheckBox.Location = new System.Drawing.Point(91, 20);
            this.DifferenceCheckBox.Name = "DifferenceCheckBox";
            this.DifferenceCheckBox.Size = new System.Drawing.Size(60, 16);
            this.DifferenceCheckBox.TabIndex = 1;
            this.DifferenceCheckBox.Text = "有差异";
            this.DifferenceCheckBox.UseVisualStyleBackColor = true;
            this.DifferenceCheckBox.CheckedChanged += new System.EventHandler(this.DifferenceCheckBox_CheckedChanged);
            // 
            // UnStartCheckBox
            // 
            this.UnStartCheckBox.AutoSize = true;
            this.UnStartCheckBox.Checked = true;
            this.UnStartCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UnStartCheckBox.Location = new System.Drawing.Point(6, 20);
            this.UnStartCheckBox.Name = "UnStartCheckBox";
            this.UnStartCheckBox.Size = new System.Drawing.Size(60, 16);
            this.UnStartCheckBox.TabIndex = 0;
            this.UnStartCheckBox.Text = "未开始";
            this.UnStartCheckBox.UseVisualStyleBackColor = true;
            this.UnStartCheckBox.CheckedChanged += new System.EventHandler(this.UnStartCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(920, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Code";
            // 
            // SearchCodeBox
            // 
            this.SearchCodeBox.Location = new System.Drawing.Point(955, 21);
            this.SearchCodeBox.Name = "SearchCodeBox";
            this.SearchCodeBox.Size = new System.Drawing.Size(144, 21);
            this.SearchCodeBox.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(1314, 20);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "查询";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DuplicateTextButton
            // 
            this.DuplicateTextButton.Location = new System.Drawing.Point(12, 16);
            this.DuplicateTextButton.Name = "DuplicateTextButton";
            this.DuplicateTextButton.Size = new System.Drawing.Size(75, 23);
            this.DuplicateTextButton.TabIndex = 15;
            this.DuplicateTextButton.Text = "填充已有";
            this.DuplicateTextButton.UseVisualStyleBackColor = true;
            this.DuplicateTextButton.Click += new System.EventHandler(this.DuplicateTextButton_Click);
            // 
            // SearchEngBox
            // 
            this.SearchEngBox.Location = new System.Drawing.Point(1149, 21);
            this.SearchEngBox.Name = "SearchEngBox";
            this.SearchEngBox.Size = new System.Drawing.Size(144, 21);
            this.SearchEngBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1114, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "eng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "12";
            // 
            // TranslateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 940);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchEngBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DuplicateTextButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchCodeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StateCheckBoxGroup);
            this.Controls.Add(this.MarkButton);
            this.Controls.Add(this.ConfrimButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EngLabel);
            this.Controls.Add(this.ChiRichTextBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TranslateGridView);
            this.Controls.Add(this.TransFileGridView);
            this.Name = "TranslateForm";
            this.Text = "TranslateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TranslateForm_FormClosed);
            this.Load += new System.EventHandler(this.TranslateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransFileGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TranslateGridView)).EndInit();
            this.StateCheckBoxGroup.ResumeLayout(false);
            this.StateCheckBoxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransFileGridView;
        private System.Windows.Forms.DataGridView TranslateGridView;
        private System.Windows.Forms.DataGridViewButtonColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn translateState;
        private System.Windows.Forms.DataGridViewButtonColumn confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn eng;
        private System.Windows.Forms.DataGridViewTextBoxColumn chi;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.RichTextBox ChiRichTextBox;
        private System.Windows.Forms.Label EngLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfrimButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderEnd;
        private System.Windows.Forms.DataGridViewButtonColumn Unstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn diffNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn processed;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewButtonColumn opreate;
        private System.Windows.Forms.Button MarkButton;
        private System.Windows.Forms.GroupBox StateCheckBoxGroup;
        private System.Windows.Forms.CheckBox ConfirmCheckBox;
        private System.Windows.Forms.CheckBox MarkCheckBox;
        private System.Windows.Forms.CheckBox ProcessedCheckBox;
        private System.Windows.Forms.CheckBox DifferenceCheckBox;
        private System.Windows.Forms.CheckBox UnStartCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchCodeBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DuplicateTextButton;
        private System.Windows.Forms.TextBox SearchEngBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}