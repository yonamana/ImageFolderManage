using System;
using System.Collections.Generic;
using System.Text;

namespace ManageWorks
{
    static internal class C_FileString
    {
        static string[] NG_STR_LIST = { " ", "&", "*", "?", ";", ":", "`", "'", "\"", "/", "\\", "|", "~", "$", "<", ">", "(", ")", "[", "]", "{", "}" };


        static public bool CheckString(string str)
        {
            // NG文字の確認
            foreach (string ngStr in NG_STR_LIST)
            {
                // NG文字がある場合
                if (str.Contains(ngStr))
                {
                    return false;
                }
            }

            // 問題無し
            return true;
        }



    }
}
