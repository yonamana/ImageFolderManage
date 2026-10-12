using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManageWorks
{
    public partial class FormUpdate : Form
    {
        string getId = "";
        string beforeName = "";
        string beforeCreator = "";

        public FormUpdate(string updateId)
        {
            InitializeComponent();

            string[] creatorList = TD_WORK.SelectDistinctCreator();
            foreach (string creatorName in creatorList)
            {
                TBcreator.Items.Add(creatorName);
            }

            // 編集するデータを入力欄に入力
            getId = updateId;

            C_OperateSql sql = new C_OperateSql();
            // タグのSQL
            Dictionary<int, Dictionary<string, string>> tagResult = TD_TAG.SelectAllData();

            // コンボボックスに値を入れる
            for (int count = 0; count < tagResult.Count; count++)
            {
                Dictionary<string, string> tagData = tagResult[count];
                checkedListBox1.Items.Add(tagData["name"]);
            }

            // SQL
            Dictionary<string, string> data = TD_WORK.SelectDataOne(getId);

            beforeName = data["name"];
            beforeCreator = data["creator"];

            TBname.Text = data["name"];
            TBcreator.Text = data["creator"];
            if (data["favorite"] == "1")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            // サムネイル
            thumbnail.ImageLocation = data["thumbnail"];

            // タグのチェック
            string[] nameList = C_LinkWorkTag.GetTagNameByWorkId(getId);
            foreach (string name in nameList)
            {
                int index = checkedListBox1.Items.IndexOf(name);
                checkedListBox1.SetItemChecked(index, true);
            }

            return;
        }

        ////////////////////////////////////////////////////////////
        // 関数
        ////////////////////////////////////////////////////////////

        /// <summary>
        /// 入力確認
        /// </summary>
        /// <returns></returns>
        private bool CheckInputData()
        {
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
                C_MessageBox.Error("名前に使用できない文字が含まれています。\n使用できない文字：半角空白、&、*、?、;、:、`、'、\\、/、\\、|、~、$、<、>、(、)、[、]、{、}");
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
                C_MessageBox.Error("作成者名に使用できない文字が含まれています。\n使用できない文字：半角空白、&、*、?、;、:、`、'、\\、/、\\、|、~、$、<、>、(、)、[、]、{、}");
                return false;
            }
            // 既存データ重複
            string id = TD_WORK.SelectId(TBname.Text, TBcreator.Text);
            if (id != "" && id != null && id != getId)
            {
                C_MessageBox.Error("名前と作成者名が既存のデータと被っています。");
                return false;
            }

            return true;
        }

        ////////////////////////////////////////////////////////////
        // UI操作
        ////////////////////////////////////////////////////////////



        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            // 入力項目の確認
            if (CheckInputData() == false)
            {
                return;
            }

            string thumbnailName = Path.GetFileName(thumbnail.ImageLocation);
            string thumbnailFolderPath = C_CreatePath.ThumbnailFolderPath(TBcreator.Text, TBname.Text);
            string thumbnailPath = C_CreatePath.ThumbnailPath(TBcreator.Text, TBname.Text, thumbnailName);

            // WORKデータの更新
            TD_WORK.UpdateData(getId, TBname.Text, TBcreator.Text, thumbnailPath, checkBox1.Checked);

            // 更新したWORKデータに紐づくタグ情報を削除
            TD_WORK_TAG.DeleteDataByWorkId(getId);

            // WORKデータに紐づくタグ情報の登録
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                string[] tagIdList = TD_TAG.SelectIdList(checkedListBox1);

                foreach (string tagId in tagIdList)
                {
                    TD_WORK_TAG.InsertData(getId, tagId);
                }
            }


            C_OperateFolder opeFolder = new C_OperateFolder();

            // サムネイル画像
            string checkPath = System.IO.Path.GetDirectoryName(thumbnail.ImageLocation).Replace("\\", "/");
            if (thumbnailFolderPath != checkPath)
            {
                if (Directory.Exists(thumbnailFolderPath) == true)
                {
                    // フォルダが存在するなら削除
                    opeFolder.Delete(thumbnailFolderPath);
                }
                // サムネイル画像のコピー
                opeFolder.Create(thumbnailFolderPath);
                opeFolder.thumbnailCopy(thumbnail.ImageLocation, thumbnailPath);
            }

            // 画像フォルダの移動（名称が変わった場合）
            if (beforeName != TBname.Text || beforeCreator != TBcreator.Text)
            {
                // フォルダの作成
                string beforeFolder = C_CreatePath.WorkFolderPath(beforeCreator, beforeName);
                string createFolder = C_CreatePath.WorkFolderPath(TBcreator.Text, TBname.Text);

                // フォルダの移動
                if (opeFolder.Move(beforeFolder, createFolder) == false)
                {
                    C_MessageBox.Error("ファイルの移動に失敗しました。\n（移動前と移動後のファイルの確認をしてください）");
                }
            }

            // MainFormのリストの更新
            C_WorkList.Display(getId);

            this.Dispose();
            return;
        }

        private void thmnailBtn_Click(object sender, EventArgs e)
        {
            string path = ".\\" + C_CreatePath.WorkFolderPath(TBcreator.Text, TBname.Text);
            string fileName = C_Dialog.OpenFile(path);
            if (fileName != "")
            {
                thumbnail.ImageLocation = fileName;
            }

            return;
        }

        private void FormClose(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
