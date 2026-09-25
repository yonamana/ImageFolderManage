using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ManageWorks
{
    /// <summary>
    /// ダイアログの表示
    /// </summary>
    static internal class C_Dialog
    {

        /// <summary>
        /// ファイル選択ダイアログを表示
        /// </summary>
        /// <returns></returns>
        static public string OpenFile(string relativePath)
        {
            string fileName = "";

            OpenFileDialog ofd = new OpenFileDialog();

            //[ファイルの種類]に表示される選択肢を指定する
            ofd.Filter = "PNG、JPGファイル(*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";
            //タイトルを設定する
            ofd.Title = "サムネイル画像の選択";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            if (relativePath != "")
            {
                string rootFolderPath = System.IO.Path.GetFullPath(relativePath);
                ofd.InitialDirectory = rootFolderPath;
            }
            

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName) == false)
                {
                    C_MessageBox.Error("ファイルが存在しません。");
                    ofd.Dispose();
                    return "";
                }

                fileName = ofd.FileName;
            }

            ofd.Dispose();
            return fileName;
        }

        /// <summary>
        /// フォルダ選択ダイアログを表示
        /// </summary>
        /// <returns></returns>
        static public string OpenFolder(string relativePath)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();

            // ダイアログの説明文を指定する
            fbDialog.Description = "登録する画像群のフォルダを選択";

            // 開く位置の指定
            if (relativePath != "")
            {
                string rootFolderPath = System.IO.Path.GetFullPath(relativePath);
                fbDialog.SelectedPath = rootFolderPath;
            }
            

            // 「新しいフォルダーの作成する」ボタンを表示する
            fbDialog.ShowNewFolderButton = true;

            //フォルダを選択するダイアログを表示する
            string filePath = "";
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fbDialog.SelectedPath;
            }

            // オブジェクトを破棄する
            fbDialog.Dispose();

            return filePath;
        }

        /// <summary>
        /// 指定したフォルダをエクスプローラーで開く
        /// </summary>
        /// <param name="filePath"></param>
        static public void OpenExplorer(string filePath)
        {
            System.Diagnostics.Process.Start("EXPLORER.EXE", filePath);
            return;
        }


    }
}
