using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace ManageWorks
{
    /// <summary>
    /// フォルダ管理
    /// </summary>
    internal class C_OperateFolder
    {


        public C_OperateFolder()
        {

        }

        /// <summary>
        /// UTF-16をUTF-8に変換
        /// </summary>
        /// <returns></returns>
        private string Utf16ToUtf8(string strUtf16)
        {
            // 変換処理
            byte[] byteUtf8 = Encoding.UTF8.GetBytes(strUtf16);
            string strUtf8 = Encoding.UTF8.GetString(byteUtf8);
            return strUtf8;
        }

        /// <summary>
        /// フォルダを作成
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool Create(string path)
        {
            // UTF16をUTF8に変換
            string utf8_path = Utf16ToUtf8(path);
            // フォルダ作成
            FileSystem.CreateDirectory(utf8_path);

            return true;
        }

        /// <summary>
        /// フォルダをコピー
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public bool Copy(string before, string after)
        {
            // UTF16をUTF8に変換
            string utf8_before = Utf16ToUtf8(before);
            string utf8_after = Utf16ToUtf8(after);

            // フォルダのコピー
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(
            utf8_before, utf8_after,
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
            return true;
        }

        /// <summary>
        /// ファイルを移動
        /// </summary>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public bool Move(string before, string after)
        {
            string utf8_before = Utf16ToUtf8(before);
            string utf8_after = Utf16ToUtf8(after);
            // ファイルの移動
            try
            {
                FileSystem.MoveDirectory(utf8_before, utf8_after,
                UIOption.AllDialogs, UICancelOption.DoNothing);
            }
            catch
            {
                return false;
            }
            
            return true;
        }


        /// <summary>
        /// ファイルのコピー
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="thumbnailPath"></param>
        /// <returns></returns>
        public bool thumbnailCopy(string filePath, string thumbnailPath)
        {
            string utf8_filePath = Utf16ToUtf8(filePath);
            string utf8_thumbnailPath = Utf16ToUtf8(thumbnailPath);

            // ファイルのコピー
            System.IO.File.Copy(utf8_filePath, utf8_thumbnailPath, true);

            return true;
        }

        /// <summary>
        /// ファイルの削除
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool Delete(string filePath)
        {
            string utf8_filePath = Utf16ToUtf8(filePath);

            FileSystem.DeleteDirectory(utf8_filePath,
                UIOption.AllDialogs, RecycleOption.SendToRecycleBin,
                UICancelOption.DoNothing);

            return true;
        }
        


    }
}
