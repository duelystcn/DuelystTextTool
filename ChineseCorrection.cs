﻿using DuelystText.CoreData;
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
    public partial class ChineseCorrection : Form
    {
        public ChineseCorrection()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ToolDataManger.Instance.currentNodeItem.StrBatchCorrection(ToolDataManger.Instance.currentVersionItem.versionCode, oldText.Text, newText.Text);
        }
    }
}
