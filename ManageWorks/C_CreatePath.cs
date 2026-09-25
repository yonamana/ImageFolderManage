using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using static Azure.Core.HttpHeader;

namespace ManageWorks
{
    /// <summary>
    /// パス文字列の作成
    /// </summary>
    static internal class C_CreatePath
    {
        /// <summary>
        /// workフォルダの作品までの相対パスを作成
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string WorkFolderPath(string creator, string name)
        {
            string filePath = "work\\" + creator + "\\" + name;
            return filePath;
        }
        
        /// <summary>
        /// thumbnailフォルダのサムネイルまでの相対パスを作成
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string ThumbnailFolderPath(string creator, string name)
        {
            string folderPath = "thumbnail/" + creator + "/" + name;
            return folderPath;
        }

        /// <summary>
        /// thumbnailフォルダのサムネイル画像の相対パスを作成
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="name"></param>
        /// <param name="thumbnailName"></param>
        /// <returns></returns>
        static public string ThumbnailPath(string creator, string name, string thumbnailName)
        {
            string filePath = ThumbnailFolderPath(creator, name) + "/" + thumbnailName;
            return filePath;
        }

        /// <summary>
        /// deleteFileフォルダの削除ファイルの相対パスを作成
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public string DeleteFilePath(string id)
        {
            string folderPath = "deleteFile/"  + id;
            return folderPath;
        }



    }
}
