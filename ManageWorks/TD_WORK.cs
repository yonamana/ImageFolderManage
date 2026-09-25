using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ManageWorks
{
    /// <summary>
    /// WORKテーブルのデータ管理
    /// </summary>
    static internal class TD_WORK
    {
        const string TABLE_NAME = "WORK";

        /// <summary>
        /// データの登録
        /// </summary>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="thumbnailPath"></param>
        /// <param name="isCheckBox"></param>
        static public void InsertData(string name, string creator, string thumbnailPath, bool isCheckBox)
        {
            C_OperateSql sql = new C_OperateSql();
            string columns = "name,creator,thumbnail,favorite,format";
            string values = "N'" + name + "', N'" + creator + "', N'" + thumbnailPath + "',";
            if (isCheckBox == true)
            {
                values += "1";
            }
            else
            {
                values += "0";
            }
            values += ",1";

            sql.Insert(TABLE_NAME, columns, values);
            return;
        }

        /// <summary>
        /// データの更新
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <param name="thumbnailPath"></param>
        /// <param name="isCheckBox"></param>
        static public void UpdateData(string id, string name, string creator, string thumbnailPath, bool isCheckBox)
        {
            C_OperateSql sql = new C_OperateSql();
            string setStr = "";
            setStr += "name = N'" + name + "', ";
            setStr += "creator = N'" + creator + "', ";
            setStr += "thumbnail = N'" + thumbnailPath + "', ";
            if (isCheckBox == true)
            {
                setStr += "favorite = 1";
            }
            else
            {
                setStr += "favorite = 0";
            }
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

        /// <summary>
        /// 指定したidのデータを取得
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        static public Dictionary<string, string> SelectDataOne(string id)
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "creator", "favorite", "thumbnail" };

            string where = "id = " + id;
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns, where);
            return result[0];
        }

        /// <summary>
        /// 指定したデータのidを取得
        /// </summary>
        /// <param name="name"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        static public string SelectId(string name, string creator)
        {
            C_OperateSql sql = new C_OperateSql();
            string where = "name = N'" + name + "' AND creator = N'" + creator + "'";
            string[] selectColumns = { "id" };
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, selectColumns, where);
            if (result.Count == 0)
            {
                return "";
            }
            Dictionary<string, string> data = result[0];
            return data["id"];
        }

        /// <summary>
        /// すべてのデータのcreatorを被り無しで取得
        /// </summary>
        /// <returns></returns>
        static public string[] SelectDistinctCreator()
        {
            C_OperateSql sql = new C_OperateSql();

            string[] columns = { "DISTINCT creator" };
            Dictionary<int, Dictionary<string, string>> result = sql.Select(TABLE_NAME, columns);

            string[] creatorList = new string[result.Count];
            for (int count = 0; count < result.Count; count++)
            {
                Dictionary<string, string> data = result[count];
                creatorList[count] = data["creator"];
            }
            return creatorList;
        }




    }
}
