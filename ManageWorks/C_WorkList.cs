using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace ManageWorks
{

    internal class CD_ListRowData
    {
        private string m_id;
        private string m_name;
        private string m_creator;
        private bool m_favorite;
        private string m_thumbnail;
        private string m_tag;

        public CD_ListRowData(string id, string name, string creator, bool favorite, string thumbnail, string tag)
        {
            m_id = id;
            m_name = name;
            m_creator = creator;
            m_favorite = favorite;
            m_thumbnail = thumbnail;
            m_tag = tag;
            return;
        }

        public CD_ListRowData(DataGridViewRow rowData)
        {
            m_id = rowData.Cells["id"].Value?.ToString() ?? "";
            m_name = rowData.Cells["name"].Value?.ToString() ?? "";
            m_creator = rowData.Cells["creator"].Value?.ToString() ?? "";
            string favorite = rowData.Cells["favorite"].Value?.ToString() ?? "";
            m_favorite = (favorite == "★" || favorite == "1") ? true : false;
            m_thumbnail = rowData.Cells["thumbnail"].Value?.ToString() ?? "";
            m_tag = rowData.Cells["Tag"].Value?.ToString() ?? "";
            return;
        }

        public CD_ListRowData(Dictionary<string, string> rowData)
        {
            m_id = (rowData.ContainsKey("id") == true) ? rowData["id"] : "";
            m_name = (rowData.ContainsKey("name") == true) ? rowData["name"] : "";
            m_creator = (rowData.ContainsKey("creator") == true) ? rowData["creator"] : "";
            m_favorite = (rowData.ContainsKey("favorite") == true && rowData["favorite"] == "★" || rowData["favorite"] == "1")
                ? true : false;
            m_thumbnail = (rowData.ContainsKey("thumbnail") == true) ? rowData["thumbnail"] : "";
            m_tag = (rowData.ContainsKey("tag") == true) ? rowData["tag"] : "";
            return;
        }

        static public CD_ListRowData GetEmptyData()
        {
            return new CD_ListRowData("", "", "", false, "", "");
        }

        static public CD_ListRowData[] CreateDictionaryListRowData(Dictionary<int, Dictionary<string, string>> dictionary)
        {
            CD_ListRowData[] returnData = new CD_ListRowData[dictionary.Count];
            for (int count = 0; count < dictionary.Count; count++)
            {
                Dictionary<string, string> data = dictionary[count];
                returnData[count] = new CD_ListRowData(data);

            }
            return returnData;
        }

        public string GetId() { return m_id; }
        public string GetName() { return m_name; }
        public string GetCreator() { return m_creator; }
        public bool GetFavorite() { return m_favorite; }
        public string GetThumbnail() { return m_thumbnail; }
        public string GetTag() { return m_tag; }



    }


    internal class CD_ListSort
    {
        private DataGridViewColumn m_column;
        private SortOrder m_order;

        public const string NOT_SORT_COLUMN = "NotSortColumn";

        public CD_ListSort(DataGridViewColumn column, SortOrder order)
        {
            if (column == null)
            {
                m_column = new DataGridViewColumn();
                m_column.Name = NOT_SORT_COLUMN;
            }
            else
            {
                m_column = column;
            }
            
            m_order = order;
            return;
        }

        public DataGridViewColumn GetColumn() { return m_column; }
        public System.ComponentModel.ListSortDirection GetOrder()
        { 
            if (m_order == SortOrder.Descending)
            {
                return System.ComponentModel.ListSortDirection.Descending;
            }
            return System.ComponentModel.ListSortDirection.Ascending;
        }

    }


    /// <summary>
    /// 作品のリストUIの管理
    /// </summary>
    static internal class C_WorkList
    {
        static DataGridView uiList = new DataGridView();

        static private string searchCreator = "";
        static private bool searchFavorite = false;
        static private string[] searchTag = Array.Empty<string>();

        /// <summary>
        /// UI情報をセット
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="pictureBox"></param>
        /// <param name="textBox"></param>
        static public void SetUiList(DataGridView dataGridView)
        {
            uiList = dataGridView;
            return;
        }

        /// <summary>
        /// 行を選択しているか
        /// </summary>
        /// <returns></returns>
        static public bool IsCurrentRow()
        {
            if (uiList.CurrentRow == null)
            {
                return false;
            }
            return true;
        }

        static public CD_ListRowData GetRowData()
        {
            if (uiList?.CurrentRow == null)
            {
                return CD_ListRowData.GetEmptyData();
            }
            return new CD_ListRowData(uiList.CurrentRow);
        }

       

        static public void ResetSort()
        {
            if (uiList.Columns["id"] == null)
            {
                return;
            }

            DataGridViewColumn column = uiList.Columns["id"];
            uiList.Sort(column, System.ComponentModel.ListSortDirection.Descending);

            if (uiList.RowCount > 0)
            {
                uiList.CurrentCell = uiList[0, 0];
            }
            
            return;
        }


        /// <summary>
        /// リスト内の表示処理
        /// </summary>
        static public void Display(string focusId = "")
        {
            // リストのソート条件を取得
            CD_ListSort listSort = new CD_ListSort(uiList.SortedColumn, uiList.SortOrder);

            string currentFocusId = focusId;
            // フォーカスするIDがない場合
            if (currentFocusId == "")
            {
                currentFocusId = GetRowData().GetId();
            }

            // リストのクリア
            uiList.Rows.Clear();
            // データの取得
            CD_ListRowData[] result = GetDatabaseData();
            if (result == null)
            {
                return;
            }
            // リストにデータを出力
            for (int count = 0; count < result.Length; count++)
            {
                CD_ListRowData data = result[count];
                string favoriteStr = "";
                if (data.GetFavorite() == true)
                {
                    favoriteStr = "★";
                }
                else
                {
                    favoriteStr = "";
                }

                // タグ名の取得
                string nameStr = C_LinkWorkTag.GetTagNameStrByWorkId(data.GetId());

                uiList.Rows.Add(Convert.ToInt32(data.GetId()), data.GetName(), data.GetCreator(), favoriteStr, data.GetThumbnail(), nameStr);
            }

            // ソートを元に戻す
            if (listSort.GetColumn().Name != CD_ListSort.NOT_SORT_COLUMN)
            {
                uiList.Sort(listSort.GetColumn(), listSort.GetOrder());
            }

            // 行がない場合
            if (uiList.RowCount <= 0)
            {
                return;
            }

            // フォーカス
            for (int count = 0; count < uiList.RowCount; count++)
            {
                if (uiList?.Rows[count]?.Cells["id"]?.Value?.ToString() == currentFocusId)
                {
                    uiList.CurrentCell = uiList[0, count];
                    break;
                }
            }

            return;
        }

        /// <summary>
        /// 所持しているリストデータの更新
        /// </summary>
        /// <returns></returns>
        static private CD_ListRowData[] GetDatabaseData()
        {
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "id", "name", "creator", "favorite", "thumbnail" };
            string where = "";

            if (searchCreator != "")
            {
                where += "creator = N'" + searchCreator + "'";
            }
            if (searchFavorite == true)
            {
                if (where != "")
                {
                    where += " AND ";
                }
                where += "favorite = 1";
            }
            if (searchTag.Length > 0)
            {
                if (where != "")
                {
                    where += " AND ";
                }

                // SQL: SELECT（タグのid検索）
                string tagSelectWhere = "";
                foreach (string item in searchTag)
                {
                    if (tagSelectWhere != "")
                    {
                        tagSelectWhere += " OR ";
                    }
                    tagSelectWhere += "name = N'" + item + "'";
                }
                string[] tagSelectColumns = { "id" };
                Dictionary<int, Dictionary<string, string>> tagIdResult = sql.Select("TAG", tagSelectColumns, tagSelectWhere);

                string[] tagIdList = new string[tagIdResult.Count];
                for (int count = 0; count < tagIdResult.Count; count++)
                {
                    Dictionary<string, string> tagIdData = tagIdResult[count];
                    tagIdList[count] = tagIdData["id"];
                }

                // tag_idを元にwork_idを取得
                string[] workIdList = C_LinkWorkTag.GetWorkId(tagIdList);
                string addWhere = "";
                foreach (string item in workIdList)
                {
                    if (addWhere != "")
                    {
                        addWhere += " OR ";
                    }
                    addWhere += "id = " + item;
                }
                where += addWhere;
            }

            if (searchTag.Count() > 0 && where == "")
            {
                return Array.Empty<CD_ListRowData>();
            }

            // SELECT
            return CD_ListRowData.CreateDictionaryListRowData(sql.Select("WORK", columns, where));
        }

        /// <summary>
        /// 検索条件を指定
        /// </summary>
        /// <param name="creator"></param>
        /// <param name="favorite"></param>
        /// <param name="tag"></param>
        static public void SetSearchData(string creator, bool favorite, string[] tag)
        {
            searchCreator = creator;
            searchFavorite = favorite;
            searchTag = tag;
            return;
        }


        ////////////////////////////////////////////////////////////////////

        /// <summary>
        /// 表示を行う画像群のフォルダパスの作成
        /// </summary>
        /// <returns></returns>
        static public string CreateViewFolderPath()
        {
            if (IsCurrentRow() == false)
            {
                return "";
            }

            // SQL
            string where = "id = " + C_WorkList.GetRowData().GetId();
            C_OperateSql sql = new C_OperateSql();
            string[] columns = { "creator", "name" };
            Dictionary<int, Dictionary<string, string>> result = sql.Select("WORK", columns, where);

            // フォルダパス作成
            Dictionary<string, string> data = result[0];
            string filePath = C_CreatePath.WorkFolderPath(data["creator"], data["name"]);            
            
            return filePath;
        }





    }
}
