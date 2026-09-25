using System;
using System.Collections.Generic;
using System.Text;

namespace ManageWorks
{
    /// <summary>
    /// メッセージボックス
    /// </summary>
    static internal class C_MessageBox
    {
        /// <summary>
        /// 確認メッセージボックスの表示
        /// </summary>
        /// <param name="checkMessage"></param>
        /// <returns></returns>
        static public bool Check(string checkMessage)
        {
            DialogResult result = MessageBox.Show(
                    checkMessage,
                    "確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation
                );
            
            if (result == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// エラーメッセージの表示
        /// </summary>
        /// <param name="errorMessage"></param>
        static public void Error(string errorMessage)
        {
            MessageBox.Show(
                    errorMessage,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            return;
        }





    }
}
