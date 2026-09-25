using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManageWorks
{
    public partial class FormTagDelete : Form
    {
        public FormTagDelete()
        {
            InitializeComponent();

            // SQL：SELECT
            Dictionary<int, Dictionary<string, string>> tagData = TD_TAG.SelectAllData();

            // コンボボックスに値を入れる
            for (int count = 0; count < tagData.Count; count++)
            {
                Dictionary<string, string> data = tagData[count];
                comboBox1.Items.Add(data["name"]);
            }

            return;
        }

        private bool CheckInputData()
        {
            // コンボボックス
            if (comboBox1.Text.Length == 0)
            {
                C_MessageBox.Error("変更するタグを選択してください。");
                return false;
            }

            return true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // 入力確認
            if (CheckInputData() == false)
            {
                return;
            }
            // 確認メッセージ
            if (C_MessageBox.Check("「" + comboBox1.Text + "」を削除してよろしいですか？") == false)
            {
                return;
            }

            // TAGテーブル
            string tagId = TD_TAG.selectId(comboBox1.Text);
            TD_TAG.DeleteData(tagId);

            // WORK_TAGテーブル
            TD_WORK_TAG.DeleteDataByTagId(tagId);

            // MainFormのリストの更新
            C_WorkList.Display();
            this.Dispose();
            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
