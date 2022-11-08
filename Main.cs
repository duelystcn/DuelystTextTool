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



        public Main()
        {
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

            foreach (VersionItem versionItem  in ToolDataManger.Instance.versionDic.Values)
            {
                versionDataTable.Rows.Add(
                    versionItem.versionCode
                ); 
               
            }
            VersionGrid.Columns[0].DataPropertyName = "versionCode";
            VersionGrid.Columns[0].DefaultCellStyle.BackColor = Color.LightSteelBlue;
            VersionGrid.DataSource = versionDataTable;
            //提交修改
            versionDataTable.AcceptChanges();
        }


        

      


    }
}
