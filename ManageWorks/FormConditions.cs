using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManageWorks
{
    public partial class FormConditions : Form
    {

        public FormConditions()
        {
            InitializeComponent();

            string[] creatorList = TD_WORK.SelectDistinctCreator();

            foreach (string creatorName in creatorList)
            {
                CreatorBox.Items.Add(creatorName);
            }

            Dictionary<int, Dictionary<string, string>> result = TD_TAG.SelectAllData();
            // コンボボックスに値を入れる
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                TagBox.Items.Add(data["name"]);
            }

            return;
        }

        ////////////////////////////////////////////////////////////
        // 関数
        ////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////
        // UI操作
        ////////////////////////////////////////////////////////////

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // 作者名
            string creator = CreatorBox.Text;

            // お気に入り
            bool favorite = favoriteBox.Checked;

            // タグ
            int count = TagBox.CheckedItems.Count;
            string[] tag = new string[count];

            int cnt = 0;
            foreach (string item in TagBox.CheckedItems)
            {
                tag[cnt] = item;
                cnt++;
            }

            // データをMainFormに送る
            C_WorkList.SetSearchData(creator, favorite, tag);

            // MainFormのリストの更新
            C_WorkList.Display();

            // ウィンドウを閉じる
            this.Dispose();
            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
