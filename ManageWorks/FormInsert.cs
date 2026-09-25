using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Unicode;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManageWorks
{
    public partial class FormInsert : Form
    {


        public FormInsert()
        {
            InitializeComponent();

            string[] creatorList = TD_WORK.SelectDistinctCreator();
            foreach (string creatorName in creatorList)
            {
                TBcreator.Items.Add(creatorName);
            }

            updateTagBox();
            return;
        }

        ////////////////////////////////////////////////////////////
        // 関数
        ////////////////////////////////////////////////////////////

        private void updateTagBox()
        {
            checkedListBox1.Items.Clear();

            // SQL：SELECT
            Dictionary<int, Dictionary<string, string>> tagData = TD_TAG.SelectAllData();

            // コンボボックスに値を入れる
            for (int count = 0; count < tagData.Count; count++)
            {
                Dictionary<string, string> data = tagData[count];
                checkedListBox1.Items.Add(data["name"]);
            }

            return;
        }

        /// <summary>
        /// 入力確認
        /// </summary>
        /// <returns></returns>
        private bool CheckInputData()
        {
            // ファイル
            if (fileName.Text.Length == 0)
            {
                C_MessageBox.Error("登録するファイルを選択してください。");
                return false;
            }
            // サムネイルファイル名
            if (Path.GetFileName(thumbnail.ImageLocation) == null)
            {
                C_MessageBox.Error("サムネイルに使用するファイルを選択してください。");
                return false;
            }
            if (Path.GetFileName(thumbnail.ImageLocation).Length > 100)
            {
                C_MessageBox.Error("サムネイルに使用するファイル名を100文字以内にしてください。");
                return false;
            }
            // 名前
            if (TBname.Text.Length == 0)
            {
                C_MessageBox.Error("名前を入力してください。");
                return false;
            }
            if (C_FileString.CheckString(TBname.Text) == false)
            {
                C_MessageBox.Error("名前に使用できない文字が含まれています。");
                return false;
            }
            // 作成者名
            if (TBcreator.Text.Length == 0)
            {
                C_MessageBox.Error("作成者名を入力してください。");
                return false;
            }
            if (C_FileString.CheckString(TBcreator.Text) == false)
            {
                C_MessageBox.Error("作成者名に使用できない文字が含まれています。");
                return false;
            }
            // 既存データ重複
            string id = TD_WORK.SelectId(TBname.Text, TBcreator.Text);
            if (id != "" && id != null)
            {
                C_MessageBox.Error("名前と作成者名が既存のデータと被っています。");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 登録するフォルダを選択する
        /// </summary>
        private void FolderSelect()
        {
            string filePath = C_Dialog.OpenFolder("");
            if (filePath != "")
            {
                fileName.Text = filePath;
                TBname.Text = Path.GetFileName(filePath);
            }

            return;
        }

        ////////////////////////////////////////////////////////////
        // UI操作
        ////////////////////////////////////////////////////////////

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            // 入力項目の確認
            if (CheckInputData() == false)
            {
                return;
            }

            if (Directory.Exists(fileName.Text) == false)
            {
                C_MessageBox.Error("移動元のフォルダが存在しません。");
                return;
            }

            string thumbnailName = Path.GetFileName(thumbnail.ImageLocation);
            string thumbnailPath = C_CreatePath.ThumbnailPath(TBcreator.Text, TBname.Text, thumbnailName);

            TD_WORK.InsertData(TBname.Text, TBcreator.Text, thumbnailPath, checkBox1.Checked);

            // SQL: SELECT
            // INSERTしたデータのidを取得
            string insertWorkId = TD_WORK.SelectId(TBname.Text, TBcreator.Text);

            // SQL: SELECT（タグのid検索）
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                string[] tagIdList = TD_TAG.SelectIdList(checkedListBox1);

                foreach (string tagId in tagIdList)
                {
                    TD_WORK_TAG.InsertData(insertWorkId, tagId);
                }
            }


            C_OperateFolder opeFolder = new C_OperateFolder();
            // サムネイル画像のコピー
            opeFolder.Create(C_CreatePath.ThumbnailFolderPath(TBcreator.Text, TBname.Text));
            opeFolder.thumbnailCopy(thumbnail.ImageLocation, thumbnailPath);

            // フォルダの作成
            string workFolderPath = C_CreatePath.WorkFolderPath(TBcreator.Text, TBname.Text);

            // フォルダの移動
            if (opeFolder.Move(fileName.Text, workFolderPath) == false)
            {
                C_MessageBox.Error("ファイルの移動に失敗しました。\n（移動前と移動後のファイルの確認をしてください）");
            }



            // MainFormのリストの更新
            C_WorkList.Display(insertWorkId);

            this.Dispose();
            return;
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            FolderSelect();
            return;
        }



        private void thmnailBtn_Click(object sender, EventArgs e)
        {
            string GetFileName = C_Dialog.OpenFile(fileName.Text);
            if (GetFileName != "")
            {
                thumbnail.ImageLocation = GetFileName;
            }

            return;
        }

        private void Insert_Load(object sender, EventArgs e)
        {

        }

        private void TagInsertBtn_Click(object sender, EventArgs e)
        {
            // window表示
            C_ManageForm.StartTagInsert();
            return;
        }

        private void UpdateTagBoxBtn_Click(object sender, EventArgs e)
        {
            updateTagBox();

            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
