using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManageWorks
{
    public partial class FormTagInsert : Form
    {
        public FormTagInsert()
        {
            InitializeComponent();
            return;
        }

        ////////////////////////////////////////////////////////////
        // 関数
        ////////////////////////////////////////////////////////////

        private bool CheckInputData()
        {
            // 入力欄
            if (tagBox.Text.Length == 0)
            {
                C_MessageBox.Error("タグ名を入力してください。");
                return false;
            }
            string id = TD_TAG.selectId(tagBox.Text);
            if (id != "" && id != null)
            {
                C_MessageBox.Error("タグ名が既存のデータと被っています。");
                return false;
            }

            return true;
        }

        ////////////////////////////////////////////////////////////
        // UI操作
        ////////////////////////////////////////////////////////////



        private void InsertBtn_Click(object sender, EventArgs e)
        {
            // 入力確認
            if (CheckInputData() == false)
            {
                return;
            }

            // TAGデータの登録
            TD_TAG.InsertData(tagBox.Text);

            this.Dispose();
            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
