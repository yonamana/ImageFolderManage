using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ManageWorks
{
    /// <summary>
    /// フォームオブジェクトの管理
    /// </summary>
    internal class C_ManageForm
    {
        static FormViewImage m_formViewImage = null;
        static FormInsert m_formInsert = null;
        static FormUpdate m_formUpdate = null; 
        static FormTagInsert m_formTagInsert = null;
        static FormTagUpdate m_formTagUpdate = null;
        static FormTagDelete m_formTagDelete = null;
        static FormConditions m_formConditions = null;

        public C_ManageForm()
        {

        }

        /// <summary>
        /// ViewImageフォームを開く
        /// </summary>
        static public void StartViewImage(string filePath)
        {
            // フォーム表示
            if (m_formViewImage == null || m_formViewImage.IsDisposed == true)
            {
                m_formViewImage = new FormViewImage(filePath);
                m_formViewImage.ShowDialog();
            }
            else
            {
                m_formViewImage.WindowState = FormWindowState.Normal;
                m_formViewImage.Activate();
            }
            return;
        }

        /// <summary>
        /// Insertフォームを開く
        /// </summary>
        static public void StartInsert()
        {
            // フォーム表示
            if (m_formInsert == null || m_formInsert.IsDisposed == true)
            {
                m_formInsert = new FormInsert();
                m_formInsert.ShowDialog();
            }
            else
            {
                m_formInsert.WindowState = FormWindowState.Normal;
                m_formInsert.Activate();
            }
            return;
        }

        /// <summary>
        /// Updateフォームを開く
        /// </summary>
        static public void StartUpdate(string id)
        {
            // フォーム表示
            if (m_formUpdate == null || m_formUpdate.IsDisposed == true)
            {
                m_formUpdate = new FormUpdate(id);
                m_formUpdate.ShowDialog();
            }
            else
            {
                m_formUpdate.WindowState = FormWindowState.Normal;
                m_formUpdate.Activate();
            }
            return;
        }

        /// <summary>
        /// TagInsertフォームを開く
        /// </summary>
        static public void StartTagInsert()
        {
            // フォーム表示
            if (m_formTagInsert == null || m_formTagInsert.IsDisposed == true)
            {
                m_formTagInsert = new FormTagInsert();
                m_formTagInsert.ShowDialog();
            }
            else
            {
                m_formTagInsert.WindowState = FormWindowState.Normal;
                m_formTagInsert.Activate();
            }
            return;
        }

        /// <summary>
        /// TagUpdateフォームを開く
        /// </summary>
        static public void StartTagUpdate()
        {
            // フォーム表示
            if (m_formTagUpdate == null || m_formTagUpdate.IsDisposed == true)
            {
                m_formTagUpdate = new FormTagUpdate();
                m_formTagUpdate.ShowDialog();
            }
            else
            {
                m_formTagUpdate.WindowState = FormWindowState.Normal;
                m_formTagUpdate.Activate();
            }
            return;
        }

        /// <summary>
        /// TagDeleteフォームを開く
        /// </summary>
        static public void StartTagDelete()
        {
            // フォーム表示
            if (m_formTagDelete == null || m_formTagDelete.IsDisposed == true)
            {
                m_formTagDelete = new FormTagDelete();
                m_formTagDelete.ShowDialog();
            }
            else
            {
                m_formTagDelete.WindowState = FormWindowState.Normal;
                m_formTagDelete.Activate();
            }
            return;
        }

        /// <summary>
        /// Conditionsフォームを開く
        /// </summary>
        static public void StartConditions()
        {
            // フォーム表示
            if (m_formConditions == null || m_formConditions.IsDisposed == true)
            {
                m_formConditions = new FormConditions();
                m_formConditions.ShowDialog();
            }
            else
            {
                m_formConditions.WindowState = FormWindowState.Normal;
                m_formConditions.Activate();
            }
            return;
        }




    }
}
