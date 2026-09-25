using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using static System.Net.WebRequestMethods;

namespace ManageWorks
{
    /// <summary>
    /// work_idとtag_idの紐づけ
    /// </summary>
    internal class C_LinkWorkTag
    {


        public C_LinkWorkTag()
        {

        }

        /// <summary>
        /// work_idを元にtag_idを取得
        /// </summary>
        /// <param name="workId"></param>
        /// <returns></returns>
        static public string[] GetTagId(string workId)
        {
            return TD_WORK_TAG.SelectTagId(workId);
        }

        /// <summary>
        /// tag_idを元にwork_idを取得
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        static public string[] GetWorkId(string[] tagId)
        {
            return TD_WORK_TAG.SelectWorkId(tagId);
        }



        /// <summary>
        /// tag_idを元にタグ名の文字列を取得
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        static public string GetTagNameStrByTagId(string[] tagId)
        {

            string[] nameList = TD_TAG.SelectNameList(tagId);

            // ソートを行う
            // コード：https://qiita.com/chai0917/items/fbf33eb3db3cb1c82f27
            Array.Sort(nameList, NaturalComparer.Natural);

            // 結果を文字列に変換して返却
            string nameStr = "";
            foreach(string name in nameList)
            {
                if (nameStr != "")
                {
                    nameStr += "、";
                }
                nameStr += name;
            }

            return nameStr;
        }

        /// <summary>
        /// work_idを元にタグ名の文字列を取得
        /// </summary>
        /// <param name="workId"></param>
        /// <returns></returns>
        static public string GetTagNameStrByWorkId(string workId)
        {
            string[] tagId = GetTagId(workId);
            if (tagId.Count() == 0)
            {
                return "";
            }
            string nameStr = GetTagNameStrByTagId(tagId);

            return nameStr;
        }

        /// <summary>
        /// tag_idを元にタグ名の配列を取得
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        static public string[] GetTagNameByTagId(string[] tagId)
        {
            return TD_TAG.SelectNameList(tagId);
        }

        /// <summary>
        /// work_idを元にタグ名の配列を取得
        /// </summary>
        /// <param name="workId"></param>
        /// <returns></returns>
        static public string[] GetTagNameByWorkId(string workId)
        {
            string[] tagId = GetTagId(workId);
            if (tagId.Count() == 0)
            {
                return [];
            }
            string[] nameList = GetTagNameByTagId(tagId);

            return nameList;
        }


    }
}
