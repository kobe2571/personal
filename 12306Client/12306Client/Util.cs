using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _12306Client
{
    class Util
    {
        public static string unicode2string(string unicodeString)
        {
            string outStr = "";
            Regex reg = new Regex(@"(?i)\\u([0-9a-f]{4})");
            outStr = reg.Replace(unicodeString, delegate(Match m1)
            {
                return ((char)Convert.ToInt32(m1.Groups[1].Value, 16)).ToString();
            });
            return outStr;
        }

        public static string getCustomLoginName(string result)
        {
            result = result.Substring(result.IndexOf("login_user"), result.IndexOf("regist_out") - result.IndexOf("login_user"));
            result = result.Substring(result.IndexOf("span"), result.IndexOf("span>") - result.IndexOf("span"));
            result = result.Substring(result.IndexOf(">") + 1, result.IndexOf("<") - result.IndexOf(">") - 1);

            return result;
        }
    }
}
