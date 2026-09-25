using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ManageWorks
{
    public partial class FormTagUpdate : Form
    {


        public FormTagUpdate()
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


        ////////////////////////////////////////////////////////////
        // 関数
        ////////////////////////////////////////////////////////////

        private bool CheckInputData()
        {
            // コンボボックス
            if (comboBox1.Text.Length == 0)
            {
                C_MessageBox.Error("変更するタグを選択してください。");
                return false;
            }
            // 入力欄
            if (textBox1.Text.Length == 0)
            {
                C_MessageBox.Error("タグ名を入力してください。");
                return false;
            }
            if (textBox1.Text == comboBox1.Text)
            {
                C_MessageBox.Error("変更前と違うタグ名を入力してください。");
                return false;
            }
            string id = TD_TAG.selectId(textBox1.Text);
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // 入力確認
            if (CheckInputData() == false)
            {
                return;
            }

            // ドロップボックスの値のデータを、テキストボックスの値で更新
            TD_TAG.UpdateData(comboBox1.Text, textBox1.Text);

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
