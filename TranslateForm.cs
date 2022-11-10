using DuelystText.CoreData;
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
        public TranslateForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = GlobalVariable.formSizeBig;
            InitializeComponent();
        }

        private void TranslateForm_Load(object sender, EventArgs e)
        {

        }

        private void TranslateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ToolDataManger.Instance.currentNodeItem = ToolDataManger.Instance.currentNodeItem.parent;
        }
    }
}
