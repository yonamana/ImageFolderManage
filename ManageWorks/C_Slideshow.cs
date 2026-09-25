using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace ManageWorks
{
    /// <summary>
    /// ネットからコピーしてきたコード
    /// コード：https://qiita.com/chai0917/items/fbf33eb3db3cb1c82f27
    /// </summary>
    public class NaturalComparer : IComparer<string>
    {
        // WIN32API
        private static class NativeMethods
        {
            [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
            public static extern int StrCmpLogicalW(string psz1, string psz2);
        }
        private NaturalComparer()
        {
        }
        public int Compare(string x, string y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (x is null) return -1;
            if (y is null) return 1;
            // 文字列比較：自然順 - ここを変更することで任意の照合規則とすることが可能   
            return NativeMethods.StrCmpLogicalW(x, y);
        }
        public static NaturalComparer Natural
        {
            get
            {
                if (_Natural == null)
                    _Natural = new NaturalComparer();
                return _Natural;
            }
        }
        static NaturalComparer _Natural = null;
    }
    ////////////////////////////////////////////////////////////

    /// <summary>
    /// スライドショー機能
    /// </summary>
    internal class C_Slideshow
    {
        string[] files;
        int maxFiles;
        int nowNam;


        public C_Slideshow()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// 画像群の読み込み（現状確認して表示してるだけ？）
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="filePath"></param>
        public void LoadImageList(PictureBox pictureBox, string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                C_MessageBox.Error("フォルダが存在しません。");
                return;
            }

            files = System.IO.Directory.GetFiles(
                filePath, "*", System.IO.SearchOption.AllDirectories);

            // ソートを行う
            // コード：https://qiita.com/chai0917/items/fbf33eb3db3cb1c82f27
            Array.Sort(files, NaturalComparer.Natural);

            maxFiles = files.Length;

            if (maxFiles == 0)
            {
                C_MessageBox.Error("フォルダ内にファイルが存在しません。");
                return;
            }

            nowNam = 0;

            DrawImage(pictureBox);
            return;
        }

        /// <summary>
        /// 前の画像に移動
        /// </summary>
        /// <param name="pictureBox"></param>
        public void BackImage(PictureBox pictureBox)
        {
            if (nowNam == 0)
            {
                return;
            }
            else if (nowNam < 0)
            {
                nowNam = 0;
            }
            else
            {
                nowNam--;
            }

            DrawImage(pictureBox);
            return;
        }

        /// <summary>
        /// 次の画像に移動
        /// </summary>
        /// <param name="pictureBox"></param>
        public void NextImage(PictureBox pictureBox)
        {
            if (nowNam == maxFiles - 1)
            {
                return;
            }
            else if (nowNam > maxFiles - 1)
            {
                nowNam = maxFiles - 1;
            }
            else
            {
                nowNam++;
            }

            DrawImage(pictureBox);
            return;
        }

        /// <summary>
        /// 画像の表示
        /// </summary>
        /// <param name="pictureBox"></param>
        private void DrawImage(PictureBox pictureBox)
        {
            pictureBox.ImageLocation = files[nowNam];
            return;
        }


    }
}
