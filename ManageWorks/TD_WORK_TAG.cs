using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManageWorks
{
    /// <summary>
    /// WORK_TAGテーブルのデータ管理
    /// </summary>
    static internal class TD_WORK_TAG
    {
        const string TABLE_NAME = "WORK_TAG";

        /// <summary>
        /// データの登録
        /// </summary>
        /// <param name="workId"></param>
        /// <param name="tagId"></param>
        static public void InsertData(string workId, string tagId)
        {
            C_OperateSql sql = new C_OperateSql();

            string columns = "work_id, tag_id";

            string value = workId + ", " + tagId;
            sql.Insert(TABLE_NAME, columns, value);
            return;
        }

        /// <summary>
        /// 指定したwork_idのデータを削除
        /// </summary>
        /// <param name="workId"></param>
        static public void DeleteDataByWorkId(string workId)
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "work_id = " + workId;
            sql.Delete(TABLE_NAME, where);
            return;
        }

        /// <summary>
        /// 指定したtag_idのデータを削除
        /// </summary>
        /// <param name="tagId"></param>
        static public void DeleteDataByTagId(string tagId)
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "tag_id = " + tagId;
            sql.Delete(TABLE_NAME, where);
            return;
        }

        /// <summary>
        /// 指定したwork_idのデータのtag_idを取得
        /// </summary>
        /// <param name="workId"></param>
        /// <returns></returns>
        static public string[] SelectTagId(string workId)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "tag_id" };
            string where = "work_id = " + workId;
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);

            // 結果を配列に格納して返却
            string[] tagIdList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                tagIdList[count] = data["tag_id"];
            }

            return tagIdList;
        }

        /// <summary>
        /// 指定したtag_id群と一致するデータのwork_idを取得
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        static public string[] SelectWorkId(string[] tagId)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "work_id" };
            string where = "";
            foreach (string item in tagId)
            {
                if (where != "")
                {
                    where += " OR ";
                }
                where += "tag_id = " + item;
            }
            Dictionary<int, Dictionary<string, string>> result = sql.Select("WORK_TAG", columns, where);

            // 結果を配列にして返却
            string[] workIdList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                workIdList[count] = data["work_id"];
            }

            return workIdList;
        }


        static public string[] SelectWorkIdWhereTagId(string[] tagId)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "WORK.id" };
            string other = "";
            int tableCnt = 1;
            foreach (string item in tagId)
            {
                other += " INNER JOIN WORK_TAG AS WT" + tableCnt + " ON WORK.id = WT" + tableCnt + ".work_id AND WT" + tableCnt + ".tag_id = " + item;
                tableCnt++;
            }
            Dictionary<int, Dictionary<string, string>> result = sql.Select("WORK", columns, "", other);

            // 結果を配列にして返却
            string[] workIdList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                workIdList[count] = data["id"];
            }

            return workIdList;
        }



    }
}
