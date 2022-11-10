using DuelystText.CoreData;
using DuelystText.CoreData.Node;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelystText
{
    public partial class NodeForm : Form
    {
        [DllImport("user32")]
        public static extern int SetParent(int children, int parent);



        private DataTable versionDataTable;


        public NodeForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = GlobalVariable.formSizeBig;
            InitializeComponent();
        }

        private void NodeForm_Load(object sender, EventArgs e)
        {
            CreateNodeGridView();
        }


        private void CreateNodeGridView() 
        {
            NodeGridView.AutoGenerateColumns = false;
            versionDataTable = new DataTable();
            versionDataTable.Columns.Add("nodeCode", typeof(string));
            versionDataTable.Columns.Add("textNum", typeof(string));
            versionDataTable.Columns.Add("operate", typeof(string));

            NodeGridView.Columns[0].DataPropertyName = "nodeCode";
            NodeGridView.Columns[1].DataPropertyName = "textNum";
            NodeGridView.Columns[2].DataPropertyName = "operate";

            NodeGridView.DataSource = versionDataTable;
            LoadDataFromCurrentNodeItem();
        }


        private void LoadDataFromCurrentNodeItem() 
        {
            versionDataTable.Clear();
            foreach (NodeItem nodeItem in ToolDataManger.Instance.currentNodeItem.childNodeList)
            {
                versionDataTable.Rows.Add(
                    nodeItem.nodeCode,
                    nodeItem.translateItemList.Count,
                    (nodeItem.translateItemList.Count == 0 ? "展开" : "翻译")
                ); ;

            }
            //提交修改
            versionDataTable.AcceptChanges();
        }


        private void ReturnToParent_Click(object sender, EventArgs e)
        {
            if(ToolDataManger.Instance.currentNodeItem.parent == null) 
            {
                this.Close();
            }
            else 
            {
                ToolDataManger.Instance.currentNodeItem = ToolDataManger.Instance.currentNodeItem.parent;
                LoadDataFromCurrentNodeItem();
            }
        }

        private void NodeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NodeGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
            {
                NodeItem currentNodeItem = ToolDataManger.Instance.currentNodeItem;
                NodeItem nodeItem = ToolDataManger.Instance.currentNodeItem.GetChildNodeByCode((string)versionDataTable.Rows[e.RowIndex][0]);
                DataGridViewButtonCell btnCell = NodeGridView.CurrentCell as DataGridViewButtonCell;
                if (btnCell != null)
                {
                    if (btnCell.ColumnIndex == 2)
                    {
                        if(nodeItem.translateItemList.Count > 0) 
                        {
                            ShowTranslateButtonClick(nodeItem);
                        }
                    }

                }
            }
        }

        private void ShowTranslateButtonClick(NodeItem nodeItem)
        {
            ToolDataManger.Instance.currentNodeItem = nodeItem;
            TranslateForm translateForm = new TranslateForm();
            translateForm.Show();
        }

        private void NodeForm_Leave(object sender, EventArgs e)
        {

        }
    }
}
