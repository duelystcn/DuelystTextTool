using DuelystText.Common.Util;
using DuelystText.CoreData;
using DuelystText.CoreData.Export;
using DuelystText.CoreData.Node;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelystText
{
    public partial class TranslateForm : Form
    {
        private DataTable transFileDataTable;

        private DataTable translateDataTable;

        private TranslateSaveItem currentEditTSItem;

        private TranslateItem currentTransItem;

        private List<TranslateState> searchStateList;

        private string searchCode = "";

        public TranslateForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = GlobalVariable.formSizeBig;
            searchStateList = new List<TranslateState>();
            InitializeComponent();
        }

        private void TranslateForm_Load(object sender, EventArgs e)
        {
            CheckStateBoxList(false);
            CreateTransFileGridView();
            CreateTranslateGridView();
        }

        private void TranslateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ToolDataManger.Instance.currentNodeItem = ToolDataManger.Instance.currentNodeItem.parent;
        }

        private void CreateTransFileGridView()
        {
            TransFileGridView.AutoGenerateColumns = false;
            transFileDataTable = new DataTable();
            transFileDataTable.Columns.Add("orderStart", typeof(int));
            transFileDataTable.Columns.Add("orderEnd", typeof(int));
            transFileDataTable.Columns.Add("needTransNum", typeof(int));
            transFileDataTable.Columns.Add("diffNum", typeof(int));
            transFileDataTable.Columns.Add("processedNum", typeof(int));
            transFileDataTable.Columns.Add("markNum", typeof(int));
            transFileDataTable.Columns.Add("opreate", typeof(string));

            TransFileGridView.Columns[0].DataPropertyName = "orderStart";
            TransFileGridView.Columns[1].DataPropertyName = "orderEnd";
            TransFileGridView.Columns[2].DataPropertyName = "needTransNum";
            TransFileGridView.Columns[3].DataPropertyName = "diffNum";
            TransFileGridView.Columns[4].DataPropertyName = "processedNum";
            TransFileGridView.Columns[5].DataPropertyName = "markNum";
            TransFileGridView.Columns[6].DataPropertyName = "opreate";

            TransFileGridView.DataSource = transFileDataTable;

            LoadTransFileDataFromCurrentNodeItem();
        }

        private void CreateTranslateGridView()
        {
            TranslateGridView.AutoGenerateColumns = false;
            TranslateGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //设置自动调整高度
            TranslateGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            translateDataTable = new DataTable();
            translateDataTable.Columns.Add("code", typeof(string));
            translateDataTable.Columns.Add("translateState", typeof(string));
            translateDataTable.Columns.Add("confirm", typeof(string));
            translateDataTable.Columns.Add("eng", typeof(string));
            translateDataTable.Columns.Add("chi", typeof(string));

            TranslateGridView.Columns[0].DataPropertyName = "code";
            TranslateGridView.Columns[1].DataPropertyName = "translateState";
            TranslateGridView.Columns[2].DataPropertyName = "confirm";
            TranslateGridView.Columns[3].DataPropertyName = "eng";
            TranslateGridView.Columns[4].DataPropertyName = "chi";

            TranslateGridView.DataSource = translateDataTable;
        }


        private void LoadTransFileDataFromCurrentNodeItem()
        {
            transFileDataTable.Clear();
            foreach (TranslateSaveItem translateSaveItem in ToolDataManger.Instance.currentNodeItem.translateSaveItemList)
            {
                transFileDataTable.Rows.Add(
                    translateSaveItem.orderStart,
                    translateSaveItem.orderEnd,
                    translateSaveItem.GeSumByState(TranslateState.UnStart),
                    translateSaveItem.GeSumByState(TranslateState.Difference),
                    translateSaveItem.GeSumByState(TranslateState.Processed),
                    translateSaveItem.GeSumByState(TranslateState.Mark),
                    "查看"
                );

            }
            //提交修改
            transFileDataTable.AcceptChanges();
        }

        private void TransFileGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TransFileGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
            {
                TranslateSaveItem translateSaveItem = ToolDataManger.Instance.currentNodeItem.GetTranslateSaveItemByStartAndEnd((int)transFileDataTable.Rows[e.RowIndex][0], (int)transFileDataTable.Rows[e.RowIndex][1]);
                DataGridViewButtonCell btnCell = TransFileGridView.CurrentCell as DataGridViewButtonCell;
                if (btnCell != null)
                {
                    if (btnCell.ColumnIndex == 6)
                    {
                        ShowTranslateSaveInfo(translateSaveItem);
                    }
                    else 
                    {
                        FileReadUtil.OpenFolder(ToolDataManger.Instance.GetTargetNodePath(ToolDataManger.Instance.currentNodeItem));
                    }

                }
            }
        }
        
        private void ShowTranslateSaveInfo(TranslateSaveItem translateSaveItem) 
        {
            this.currentEditTSItem = translateSaveItem;
            translateDataTable.Clear();
            foreach (TranslateItem translateItem in this.currentEditTSItem.translateItemList)
            {
                if (this.searchStateList.Contains(translateItem.translateState)) 
                {
                    if (searchCode != "")
                    {
                        if(translateItem.code.IndexOf(searchCode) == -1) 
                        {
                            continue;
                        }
                    }
                    translateDataTable.Rows.Add(
                       translateItem.code,
                       translateItem.GetStateStr(),
                       "确认",
                       translateItem.eng,
                       translateItem.chi
                   );
                }
            }
            //提交修改
            translateDataTable.AcceptChanges();
        }

        private void TranslateGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TranslateGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)
            {
                TranslateItem translateItem = currentEditTSItem.GetTranslateItemByCode((string)translateDataTable.Rows[e.RowIndex][0]);
                DataGridViewButtonCell btnCell = TranslateGridView.CurrentCell as DataGridViewButtonCell;
                if (btnCell != null)
                {
                    if (btnCell.ColumnIndex == 0)
                    {
                        ShowTranslateItemInfo(translateItem);
                    }
                    else if (btnCell.ColumnIndex == 2) 
                    {
                        if (CheckCanConfirmTranslate())
                        {
                            translateItem.translateState = TranslateState.Confirm;
                            ToolDataManger.Instance.currentNodeItem.WriteTargetTranslateSaveItem(this.currentEditTSItem, ToolDataManger.Instance.GetTargetNodePath(ToolDataManger.Instance.currentNodeItem));
                            RefreshOneTranslateItemInfo(translateItem);
                        }
                    }
                }
            }
        }

        private void ShowTranslateItemInfo(TranslateItem translateItem) 
        {
            this.currentTransItem = translateItem;
            EngLabel.Text = translateItem.eng;
            ChiRichTextBox.Text = translateItem.chi;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveOneTransItemNeedState(TranslateState.Processed);
        }

        private bool CheckCanConfirmTranslate() 
        {
            if (ToolDataManger.Instance.IsAdmin()) 
            {
                return true;
            }
            else 
            {
                MessageBox.Show("非管理员无法进行确认操作", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void ConfrimButton_Click(object sender, EventArgs e)
        {
            if (CheckCanConfirmTranslate())
            {
                SaveOneTransItemNeedState(TranslateState.Confirm);
            }

        }

        private void RefreshOneTranslateItemInfo(TranslateItem translateItem) 
        {
            DataRow targetDataRow = null;
            foreach (DataRow dataRow in translateDataTable.Rows)
            {
                if ((string)dataRow[0] == translateItem.code)
                {
                    targetDataRow = dataRow;
                    break;
                }
            }
            targetDataRow[1] = translateItem.GetStateStr();
            targetDataRow[4] = translateItem.chi;
        }

        private void UnStartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckStateBoxList(true);
        }

        private void DifferenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckStateBoxList(true);
        }

        private void ProcessedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckStateBoxList(true);
        }

        private void MarkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckStateBoxList(true);
        }

        private void ConfirmCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckStateBoxList(true);
        }

        private void CheckStateBoxList(bool doSearch) 
        {
            searchStateList.Clear();
            if (UnStartCheckBox.Checked) 
            {
                searchStateList.Add(TranslateState.UnStart);
            }
            if (DifferenceCheckBox.Checked)
            {
                searchStateList.Add(TranslateState.Difference);
            }
            if (ProcessedCheckBox.Checked)
            {
                searchStateList.Add(TranslateState.Processed);
            }
            if (MarkCheckBox.Checked)
            {
                searchStateList.Add(TranslateState.Mark);
            }
            if (ConfirmCheckBox.Checked)
            {
                searchStateList.Add(TranslateState.Confirm);
            }
            if (doSearch) 
            {
                ShowTranslateSaveInfo(currentEditTSItem);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchCode = SearchCodeBox.Text;
            if(searchCode != "") 
            {
                ShowTranslateSaveInfo(currentEditTSItem);
            }
        }

        private void MarkButton_Click(object sender, EventArgs e)
        {
            SaveOneTransItemNeedState(TranslateState.Mark);
        }

        private void SaveOneTransItemNeedState(TranslateState translateState) 
        {
            if (this.currentTransItem == null)
            {
                MessageBox.Show("请先选择目标修改文本", "Tip", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.currentTransItem.chi = ChiRichTextBox.Text;
                this.currentTransItem.translateState = translateState;
                ToolDataManger.Instance.currentNodeItem.WriteTargetTranslateSaveItem(this.currentEditTSItem, ToolDataManger.Instance.GetTargetNodePath(ToolDataManger.Instance.currentNodeItem));
                RefreshOneTranslateItemInfo(this.currentTransItem);
            }
        }
    }
}
