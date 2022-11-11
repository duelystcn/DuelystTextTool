
namespace DuelystText
{
    partial class NodeForm
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
            this.ReturnToParent = new System.Windows.Forms.Button();
            this.NodeGridView = new System.Windows.Forms.DataGridView();
            this.ReadFile = new System.Windows.Forms.Button();
            this.nodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needTransNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diffNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opreate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Directory = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NodeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnToParent
            // 
            this.ReturnToParent.Location = new System.Drawing.Point(12, 12);
            this.ReturnToParent.Name = "ReturnToParent";
            this.ReturnToParent.Size = new System.Drawing.Size(75, 23);
            this.ReturnToParent.TabIndex = 0;
            this.ReturnToParent.Text = "返回";
            this.ReturnToParent.UseVisualStyleBackColor = true;
            this.ReturnToParent.Click += new System.EventHandler(this.ReturnToParent_Click);
            // 
            // NodeGridView
            // 
            this.NodeGridView.AllowUserToAddRows = false;
            this.NodeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NodeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeName,
            this.textNum,
            this.needTransNum,
            this.diffNum,
            this.processed,
            this.mark,
            this.opreate,
            this.Directory});
            this.NodeGridView.Location = new System.Drawing.Point(12, 41);
            this.NodeGridView.Name = "NodeGridView";
            this.NodeGridView.RowTemplate.Height = 23;
            this.NodeGridView.Size = new System.Drawing.Size(1013, 771);
            this.NodeGridView.TabIndex = 1;
            this.NodeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NodeGridView_CellContentClick);
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(103, 12);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(75, 23);
            this.ReadFile.TabIndex = 2;
            this.ReadFile.Text = "读取文件";
            this.ReadFile.UseVisualStyleBackColor = true;
            // 
            // nodeName
            // 
            this.nodeName.HeaderText = "nodeName";
            this.nodeName.Name = "nodeName";
            this.nodeName.ReadOnly = true;
            this.nodeName.Width = 300;
            // 
            // textNum
            // 
            this.textNum.HeaderText = "总数";
            this.textNum.Name = "textNum";
            this.textNum.ReadOnly = true;
            this.textNum.Width = 80;
            // 
            // needTransNum
            // 
            this.needTransNum.HeaderText = "待翻译";
            this.needTransNum.Name = "needTransNum";
            this.needTransNum.ReadOnly = true;
            this.needTransNum.Width = 80;
            // 
            // diffNum
            // 
            this.diffNum.HeaderText = "有变更";
            this.diffNum.Name = "diffNum";
            this.diffNum.ReadOnly = true;
            this.diffNum.Width = 80;
            // 
            // processed
            // 
            this.processed.HeaderText = "已处理";
            this.processed.Name = "processed";
            this.processed.ReadOnly = true;
            this.processed.Width = 80;
            // 
            // mark
            // 
            this.mark.HeaderText = "标记中";
            this.mark.Name = "mark";
            this.mark.ReadOnly = true;
            this.mark.Width = 80;
            // 
            // opreate
            // 
            this.opreate.HeaderText = "操作";
            this.opreate.Name = "opreate";
            // 
            // Directory
            // 
            this.Directory.HeaderText = "文件夹";
            this.Directory.Name = "Directory";
            // 
            // NodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 824);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.NodeGridView);
            this.Controls.Add(this.ReturnToParent);
            this.Name = "NodeForm";
            this.Text = "NodeForm";
            this.Load += new System.EventHandler(this.NodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NodeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnToParent;
        private System.Windows.Forms.DataGridView NodeGridView;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn textNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn needTransNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn diffNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn processed;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewButtonColumn opreate;
        private System.Windows.Forms.DataGridViewButtonColumn Directory;
    }
}