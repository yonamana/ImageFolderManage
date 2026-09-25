using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManageWorks
{
    /// <summary>
    /// TAGテーブルのデータ管理
    /// </summary>
    static internal class TD_TAG
    {
        const string TABLE_NAME = "TAG";

        /// <summary>
        /// テーブル内のすべてのデータを取得
        /// </summary>
        /// <returns></returns>
        static public Dictionary<int, Dictionary<string, string>> SelectAllData()
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name" };
            return sql.Select(TABLE_NAME, columns);
        }

        /// <summary>
        /// 複数データのidを取得
        /// </summary>
        /// <param name="checkList"></param>
        /// <returns></returns>
        static public string[] SelectIdList(CheckedListBox checkList)
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "";
            foreach (string item in checkList.CheckedItems)
            {
                if (where != "")
                {
                    where += " OR ";
                }
                where += "name = N'" + item + "'";
            }
            string[] columns = { "id" };
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);

            string[] idList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                idList[count] = data["id"];
            }
            return idList;
        }

        /// <summary>
        /// 複数データのnameを取得
        /// </summary>
        /// <param name="idList"></param>
        /// <returns></returns>
        static public string[] SelectNameList(string[] idList)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "name" };
            string where = "";
            foreach (string item in idList)
            {
                if (where != "")
                {
                    where += " OR ";
                }
                where += "id = " + item;
            }
            Dictionary<int, Dictionary<string, string>> result = sql.Select("TAG", columns, where);

            string[] nameList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                nameList[count] = data["name"];
            }
            return nameList;
        }

        /// <summary>
        /// 指定したidのデータを取得
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string selectId(string name)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name" };
            string where = "name = N'" + name + "'";
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            if (result.Count == 0)
            {
                return "";
            }
            return result[0]["id"];
        }

        /// <summary>
        /// データの登録
        /// </summary>
        /// <param name="name"></param>
        static public void InsertData(string name)
        {
            C_OperateSql sql = new C_OperateSql();
            string columns = "name";
            string values = "N'" + name + "'";
            sql.Insert(TABLE_NAME, columns, values);
            return;
        }

        /// <summary>
        /// データの更新
        /// </summary>
        /// <param name="beforeName"></param>
        /// <param name="afterName"></param>
        static public void UpdateData(string beforeName, string afterName)
        {
            string id = selectId(beforeName);

            C_OperateSql sql = new C_OperateSql();
            string setStr = "name = N'" + afterName + "'";
            string where = "id = " + id;
            sql.Update(TABLE_NAME, setStr, where);
            return;
        }

        /// <summary>
        /// データの削除
        /// </summary>
        /// <param name="id"></param>
        static public void DeleteData(string id)
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "id = " + id;
            sql.Delete(TABLE_NAME, where);

            return;
        }



    }
}
