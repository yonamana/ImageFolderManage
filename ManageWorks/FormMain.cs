using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManageWorks
{
    public partial class FormMain : Form
    {


        public FormMain()
        {
            InitializeComponent();

            C_WorkList.SetUiList(dataGridView1);

            C_WorkList.Display();

            C_WorkList.ResetSort();

            SelectRow();

            return;
        }


        ////////////////////////////////////////////////////////////
        // UI操作
        ////////////////////////////////////////////////////////////


        /// <summary>
        /// クリック：表示ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (C_WorkList.IsCurrentRow() == false)
            {
                C_MessageBox.Error("表示するデータを選択してください。");
                return;
            }

            string filePath = C_WorkList.CreateViewFolderPath();

            // window表示
            C_ManageForm.StartViewImage(filePath);

            return;
        }

        /// <summary>
        /// クリック：登録ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            // window表示
            C_ManageForm.StartInsert();
            return;
        }



        /// <summary>
        /// クリック：リスト
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            SelectRow();
            return;
        }



        /// <summary>
        /// クリック：タグ登録ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tagInsertBtn_Click(object sender, EventArgs e)
        {
            // window表示
            C_ManageForm.StartTagInsert();
            return;
        }

        /// <summary>
        /// クリック：タグ更新ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tagUpdateBtn_Click(object sender, EventArgs e)
        {
            // window表示
            C_ManageForm.StartTagUpdate();
            return;
        }

        /// <summary>
        /// クリック：検索ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConditionsBtn_Click(object sender, EventArgs e)
        {
            // window表示
            C_ManageForm.StartConditions();
            return;
        }

        /// <summary>
        /// クリック：更新ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (C_WorkList.IsCurrentRow() == false)
            {
                C_MessageBox.Error("更新するデータを選択してください。");
                return;
            }

            // window表示
            C_ManageForm.StartUpdate(C_WorkList.GetRowData().GetId());
            return;
        }

        /// <summary>
        /// キーアップ：リスト移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            SelectRow();
            return;
        }

        /// <summary>
        /// クリック：フォルダボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FoluderBtn_Click(object sender, EventArgs e)
        {
            if (C_WorkList.IsCurrentRow() == false)
            {
                C_MessageBox.Error("フォルダを開くデータを選択してください。");
                return;
            }

            string filePath = C_WorkList.CreateViewFolderPath();

            C_Dialog.OpenExplorer(filePath);
            return;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// クリック：タグ削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tagDeleteBtn_Click(object sender, EventArgs e)
        {
            C_ManageForm.StartTagDelete();
        }

        /// <summary>
        /// クリック：削除ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (C_WorkList.IsCurrentRow() == false)
            {
                C_MessageBox.Error("削除するデータを選択してください。");
                return;
            }

            // 確認メッセージ
            string message = "「" + C_WorkList.GetRowData().GetCreator() + "」の「";
            message += C_WorkList.GetRowData().GetName() + "」を削除してよろしいですか？";
            if (C_MessageBox.Check(message) == false)
            {
                return;
            }


            CD_ListRowData rowData = C_WorkList.GetRowData();
            // WORKテーブル
            TD_WORK.DeleteData(rowData.GetId());

            // WORK_TAGテーブル
            TD_WORK_TAG.DeleteDataByWorkId(rowData.GetId());

            // フォルダ
            string workFolderPath = C_CreatePath.WorkFolderPath(rowData.GetCreator(), rowData.GetName());
            C_OperateFolder opeFolder = new C_OperateFolder();
            if (Directory.Exists(workFolderPath) == true)
            {
                // 削除の代わりに移動
                string deleteFolderPath = C_CreatePath.DeleteFilePath(rowData.GetId());
                opeFolder.Move(workFolderPath, deleteFolderPath);
            }

            C_WorkList.Display();
            return;
        }

        private void SelectChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// フォームにフォーカスが当たった時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFocusActive(object sender, EventArgs e)
        {
            SelectRow();
            return;
        }

        private void SelectRow()
        {
            CD_ListRowData rowData = C_WorkList.GetRowData();
            // サムネイルとタグボックスを更新
            pictureBox1.ImageLocation = rowData.GetThumbnail();
            TagBox.Text = rowData.GetTag();
            // フォーカスを当てる
            dataGridView1.Focus();
            return;
        }

        private void FocusMoveList(object sender, EventArgs e)
        {
            dataGridView1.Focus();
            return;
        }

        private void VersionText_Click(object sender, EventArgs e)
        {

        }
    }
}
