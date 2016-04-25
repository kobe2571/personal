using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;

namespace _12306Client
{
    class HttpHelper
    {
        public static CookieContainer CookieContainers = new CookieContainer();

        public static string getResponse(string url, string method, string data)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = true;
                request.Method = method.ToUpper();
                request.AllowAutoRedirect = true;
                request.CookieContainer = CookieContainers;
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.86 Safari/537.36";
                request.Accept = "*/*";
                //request.Timeout = 50000;

                if (method.ToUpper() == "POST" && data != null)
                {
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    byte[] postBytes = encoding.GetBytes(data); ;
                    request.ContentLength = postBytes.Length;
                    request.Headers.Add("Accept-Language", "zh-cn,zh;q=0.8,en-us;q=0.5,en;q=0.3");
                    request.Headers.Add("Cache-Control", "no-cache");
                    Stream st = request.GetRequestStream();
                    st.Write(postBytes, 0, postBytes.Length);
                    st.Close();
                }

                // 绕过https证书认证
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                {
                    return true;
                };

                Encoding myEncoding = Encoding.GetEncoding("UTF-8");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream resst = response.GetResponseStream();
                StreamReader sr = new StreamReader(resst, myEncoding);
                string str = sr.ReadToEnd();

                return str;
            }
            catch(Exception)
            {
                return string.Empty;
            }
        }

        public static Stream getResponseImage(string url)
        {
            Stream stream = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.KeepAlive = true;
                request.Method = "GET";
                request.AllowAutoRedirect = true;
                request.CookieContainer = CookieContainers;
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.86 Safari/537.36";
                request.Accept = "*/*";

                // 绕过https证书认证
                System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                {
                    return true;
                };

                Encoding myEncoding = Encoding.GetEncoding("UTF-8");

                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                stream = response.GetResponseStream();

                return stream;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string EncodingURI(string str)
        {
            return Uri.EscapeUriString(str);
        }
    }
}
