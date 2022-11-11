
namespace DuelystText
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.VersionGrid = new System.Windows.Forms.DataGridView();
            this.VersionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExportFile = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reference = new System.Windows.Forms.DataGridViewButtonColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.WorkPeople = new System.Windows.Forms.LinkLabel();
            this.CommonWord = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.VersionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionGrid
            // 
            this.VersionGrid.AllowUserToAddRows = false;
            this.VersionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VersionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VersionCode,
            this.Edit,
            this.ExportFile,
            this.reference});
            this.VersionGrid.Location = new System.Drawing.Point(12, 12);
            this.VersionGrid.Name = "VersionGrid";
            this.VersionGrid.RowTemplate.Height = 23;
            this.VersionGrid.Size = new System.Drawing.Size(511, 641);
            this.VersionGrid.TabIndex = 0;
            this.VersionGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VersionGrid_CellContentClick);
            // 
            // VersionCode
            // 
            this.VersionCode.HeaderText = "VersionCode";
            this.VersionCode.Name = "VersionCode";
            this.VersionCode.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "编辑";
            this.Edit.Name = "Edit";
            // 
            // ExportFile
            // 
            this.ExportFile.HeaderText = "导出汉化";
            this.ExportFile.Name = "ExportFile";
            // 
            // reference
            // 
            this.reference.HeaderText = "参照";
            this.reference.Name = "reference";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(559, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(339, 185);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "1，请参考程序文件夹的教程。\n2，编辑前请前往腾讯文档【D2汉化文档分工认领】进行认领，避免重复工作。\n3，编辑前请前往腾讯文档【常用语对照表】查看参考，统一风格" +
    "\n4，修改完成后私聊我，有什么建议也可以找我（晨临雾逝：1456604566），把改好的文件发我。\n5，有不能确定的编辑项请使用标记中状态";
            // 
            // WorkPeople
            // 
            this.WorkPeople.AutoSize = true;
            this.WorkPeople.Location = new System.Drawing.Point(557, 219);
            this.WorkPeople.Name = "WorkPeople";
            this.WorkPeople.Size = new System.Drawing.Size(161, 12);
            this.WorkPeople.TabIndex = 2;
            this.WorkPeople.TabStop = true;
            this.WorkPeople.Text = "打开【D2汉化文档分工认领】";
            this.WorkPeople.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WorkPeople_LinkClicked);
            // 
            // CommonWord
            // 
            this.CommonWord.AutoSize = true;
            this.CommonWord.Location = new System.Drawing.Point(557, 248);
            this.CommonWord.Name = "CommonWord";
            this.CommonWord.Size = new System.Drawing.Size(125, 12);
            this.CommonWord.TabIndex = 3;
            this.CommonWord.TabStop = true;
            this.CommonWord.Text = "打开【常用语对照表】";
            this.CommonWord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommonWord_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 864);
            this.Controls.Add(this.CommonWord);
            this.Controls.Add(this.WorkPeople);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.VersionGrid);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VersionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VersionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionCode;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn ExportFile;
        private System.Windows.Forms.DataGridViewButtonColumn reference;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel WorkPeople;
        private System.Windows.Forms.LinkLabel CommonWord;
    }
}

