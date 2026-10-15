using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ManageWorks
{
    /// <summary>
    /// SQL管理
    /// </summary>
    internal class C_OperateSql
    {
        string dbKey = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\database\\Database.mdf;Integrated Security=True;Connect Timeout=30";

        public C_OperateSql()
        {

        }

        /// <summary>
        /// SQL: INSERT
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columns"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public bool Insert(string tableName, string columns, string values)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = dbKey;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            SqlDataReader rd;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            string str = "INSERT INTO " + tableName + " (" + columns + ") VALUES(" + values + ")";

            cmd.CommandText = str;
            rd = cmd.ExecuteReader();
            rd.Close();
            cn.Close();

            return true;
        }

        /// <summary>
        /// SQL: UPDATE
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="setStr"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public bool Update(string tableName, string setStr, string where)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = dbKey;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            SqlDataReader rd;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            string str = "UPDATE " + tableName + " SET " + setStr + " WHERE " + where;

            cmd.CommandText = str;
            rd = cmd.ExecuteReader();
            rd.Close();
            cn.Close();

            return true;
        }

        /// <summary>
        /// SQL: DELETE
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public bool Delete(string tableName, string where)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = dbKey;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            SqlDataReader rd;
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            string str = "DELETE FROM " + tableName + " WHERE " + where;

            cmd.CommandText = str;
            rd = cmd.ExecuteReader();
            rd.Close();
            cn.Close();

            return true;
        }

        /// <summary>
        /// SQL: SELECT
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columns"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public Dictionary<int, Dictionary<string, string>> Select(string tableName, string[] columns, string where = "", string other = "")
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = dbKey;
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;

            // SELECT
            string str = "SELECT ";

            bool isFirst = true;
            foreach (string column in columns)
            {
                if (isFirst == true)
                {
                    isFirst = false;
                }
                else
                {
                    str += ",";
                }
                str += column;
            }

            // FROM
            str += " FROM " + tableName;

            // WHERE
            if (where != "")
            {
                str += " WHERE " + where;
            }

            if (other != "")
            {
                str += " " + other;
            }


            // 実行
            cmd.CommandText = str;

            SqlDataReader rd;
            rd = cmd.ExecuteReader();

            Dictionary<int, Dictionary<string, string>> resultList = new Dictionary<int, Dictionary<string, string>>();

            int rdCount = 0;
            while (rd.Read())
            {
                Dictionary<string, string> columnDataList = new Dictionary<string, string>();
                foreach (string column in columns)
                {
                    string checkColumn = "";
                    if (column.IndexOf("DISTINCT") >= 0)
                    {
                        checkColumn = column.Remove(0, 9);
                    }
                    else if (column.IndexOf(".") > 0)
                    {
                        checkColumn = column.Remove(0, (column.IndexOf(".") + 1));
                    }
                    else
                    {
                        checkColumn = column;
                    }

                    columnDataList.Add(checkColumn, String.Format("{0}", rd[checkColumn]));
                }
                resultList.Add(rdCount, columnDataList);
                rdCount++;
            }

            cn.Close();

            return resultList;
        }

    }
}
