
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
            this.nodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opreate = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.NodeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NodeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nodeName,
            this.textNum,
            this.opreate});
            this.NodeGridView.Location = new System.Drawing.Point(12, 41);
            this.NodeGridView.Name = "NodeGridView";
            this.NodeGridView.RowTemplate.Height = 23;
            this.NodeGridView.Size = new System.Drawing.Size(883, 771);
            this.NodeGridView.TabIndex = 1;
            this.NodeGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NodeGridView_CellContentClick);
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
            this.textNum.HeaderText = "textNum";
            this.textNum.Name = "textNum";
            this.textNum.ReadOnly = true;
            // 
            // opreate
            // 
            this.opreate.HeaderText = "opreate";
            this.opreate.Name = "opreate";
            // 
            // NodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 824);
            this.Controls.Add(this.NodeGridView);
            this.Controls.Add(this.ReturnToParent);
            this.Name = "NodeForm";
            this.Text = "NodeForm";
            this.Load += new System.EventHandler(this.NodeForm_Load);
            this.Leave += new System.EventHandler(this.NodeForm_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.NodeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnToParent;
        private System.Windows.Forms.DataGridView NodeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn textNum;
        private System.Windows.Forms.DataGridViewButtonColumn opreate;
    }
}