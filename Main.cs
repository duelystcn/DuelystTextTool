using DuelystText.Common.Log;
using DuelystText.CoreData;
using DuelystText.CoreData.Version;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelystText
{
    public partial class Main : Form
    {
        private SynchronizationContext synchronizationContext;


        private DataTable versionDataTable;


        [DllImport("user32")]
        public static extern int SetParent(int children, int parent);


        public Main()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Size = GlobalVariable.formSizeBig;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //核心管理创建
            ToolDataManger toolDataManger = new ToolDataManger();
            toolDataManger.Awake();
            CreateVersionGirdView();
        }


        private void CreateVersionGirdView() 
        {
            VersionGrid.AutoGenerateColumns = false;
            versionDataTable = new DataTable();
            versionDataTable.Columns.Add("versionCode", typeof(string));
            versionDataTable.Columns.Add("operate", typeof(string));
            versionDataTable.Columns.Add("exportFile", typeof(string));
            versionDataTable.Columns.Add("reference", typeof(string));
            versionDataTable.Columns.Add("duplicateText", typeof(string));
            versionDataTable.Columns.Add("batchReplace", typeof(string));
            foreach (VersionItem versionItem  in ToolDataManger.Instance.versionDic.Values)
            {
                versionDataTable.Rows.Add(
                    versionItem.versionCode,
                    "编辑",
                    "导出",
                    "选择",
                    "整理",
                    "替换"
                ); 
               
            }
            VersionGrid.Columns[0].DataPropertyName = "versionCode";
            VersionGrid.Columns[0].DefaultCellStyle.BackColor = Color.LightSteelBlue;

            VersionGrid.Columns[1].DataPropertyName = "operate";
            VersionGrid.Columns[2].DataPropertyName = "exportFile";
            VersionGrid.Columns[3].DataPropertyName = "reference";
            VersionGrid.Columns[4].DataPropertyName = "duplicateText";
            VersionGrid.Columns[5].DataPropertyName = "batchReplace";
            VersionGrid.DataSource = versionDataTable;
            //提交修改
            versionDataTable.AcceptChanges();
        }

        private void VersionGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VersionGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
            {
                VersionItem versionItem = ToolDataManger.Instance.versionDic[(string)versionDataTable.Rows[e.RowIndex][0]];
                DataGridViewButtonCell btnCell = VersionGrid.CurrentCell as DataGridViewButtonCell;
                if (btnCell != null)
                {
                    if (btnCell.ColumnIndex == 1)
                    {
                        ShowNodeItemButtonClickNoParent(versionItem);
                    }
                    if (btnCell.ColumnIndex == 2)
                    {
                        versionItem.ExportChiJson();
                    }
                    if (btnCell.ColumnIndex == 3)
                    {
                        VersionItem versionItemTarget = ToolDataManger.Instance.versionDic["20.1.25"];
                        versionItem.ReferenceByTargetVersion(versionItemTarget);
                    }
                    if (btnCell.ColumnIndex == 4)
                    {
                        versionItem.CreateDuplicateTextFileAndExport();
                    }
                    if (btnCell.ColumnIndex == 5)
                    {
                        ToolDataManger.Instance.currentVersionItem = versionItem;
                        ToolDataManger.Instance.currentNodeItem = versionItem.nodeItem;
                        //设置父窗体的IsMdiContainer属性为true
                        ChineseCorrection frm = new ChineseCorrection();
                        frm.Show();

                    }
                }
            }
        }



        private void ShowNodeItemButtonClick(VersionItem versionItem)
        {
            ToolDataManger.Instance.currentVersionItem = versionItem;
            ToolDataManger.Instance.currentNodeItem = versionItem.nodeItem;
            //设置父窗体的IsMdiContainer属性为true
            this.IsMdiContainer = true;
            NodeForm nodeForm = new NodeForm();
            //clubListForm.MdiParent = this;
            nodeForm.TopLevel = false;
            nodeForm.MdiParent = this;
            nodeForm.Show();
            nodeForm.BringToFront();//设置子窗体在最上面
            SetParent((int)nodeForm.Handle, (int)this.Handle);
        }

        private void ShowNodeItemButtonClickNoParent(VersionItem versionItem)
        {
            ToolDataManger.Instance.currentVersionItem = versionItem;
            ToolDataManger.Instance.currentNodeItem = versionItem.nodeItem;
            //设置父窗体的IsMdiContainer属性为true
            NodeForm frm = new NodeForm();           
            frm.Show();
         

        }

        private void WorkPeople_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.qq.com/sheet/DZVJUWWNZS1RrU29T?tab=BB08J2");
        }

        private void CommonWord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.qq.com/sheet/DZU5neHVOSVRodlpj?tab=BB08J2");
        }
    }
}
