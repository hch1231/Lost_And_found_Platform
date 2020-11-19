using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace ApiTest
{
    public static class HttpHelp
    {
        private static string url = @"https://localhost:44307";
        /// <summary>
        /// Post
        /// </summary>
        /// <param name="data">提交的数据</param>
        /// <param name="url">提交的地址</param>
        /// <returns></returns>
        public static string Post(string api, string data)
        {
            string responseStr = "";

            //注意提交的编码 这边是需要改变的 这边默认的是Default：系统当前编码
            byte[] postData = Encoding.UTF8.GetBytes(data);

            // 设置提交的相关参数 
            HttpWebRequest request = WebRequest.Create(url+api) as HttpWebRequest;
            Encoding myEncoding = Encoding.UTF8;
            request.Method = "POST";
            request.KeepAlive = false;
            //request.AllowAutoRedirect = true;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postData.Length;
            request.Timeout = 3000;

            // 提交请求数据 
            System.IO.Stream outputStream = request.GetRequestStream();
            outputStream.Write(postData, 0, postData.Length);
            outputStream.Close();

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }

            Stream responseStream;
            StreamReader reader;
            responseStream = response.GetResponseStream();
            reader = new System.IO.StreamReader(responseStream, Encoding.GetEncoding("UTF-8"));
            responseStr = reader.ReadToEnd();
            reader.Close();

            return responseStr;

        }

        /// <summary>
        /// Http
        /// </summary>
        /// <param name="method">方法</param>
        /// <param name="api">提交的地址</param>
        /// <param name="data">提交的数据</param>
        /// <returns></returns>
        public static string Http(string method,string api, string data)
        {
            string responseStr = "";
            // 设置提交的相关参数 
            HttpWebRequest request = WebRequest.Create(url + api+"?"+ data) as HttpWebRequest;
            Encoding myEncoding = Encoding.UTF8;
            request.Method = method;//"POST/GET";
            request.KeepAlive = false;
            ///request.AllowAutoRedirect = true;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Timeout = 3000;

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }

            Stream responseStream;
            StreamReader reader;
            responseStream = response.GetResponseStream();
            reader = new System.IO.StreamReader(responseStream, Encoding.GetEncoding("UTF-8"));
            responseStr = reader.ReadToEnd();
            reader.Close();
            
            return responseStr;

        }
        /// <summary>
        /// Post
        /// </summary>
        /// <param name="api">提交的地址</param>
        /// <param name="data">提交的数据</param>
        /// <returns></returns>
        public static string PostJson(string api, string data)
        {
            string responseStr = "";

            //注意提交的编码 这边是需要改变的 这边默认的是Default：系统当前编码
            byte[] postData = Encoding.UTF8.GetBytes(data);

            // 设置提交的相关参数 
            HttpWebRequest request = WebRequest.Create(url + api) as HttpWebRequest;
            Encoding myEncoding = Encoding.UTF8;
            request.Method = "POST";
            request.KeepAlive = false;
            //request.AllowAutoRedirect = true;
            request.ContentType = "application/json";
            request.Timeout = 3000;


            // 提交请求数据 
            System.IO.Stream outputStream = request.GetRequestStream();
            outputStream.Write(postData, 0, postData.Length);
            outputStream.Close();

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }

            Stream responseStream;
            StreamReader reader;
            responseStream = response.GetResponseStream();
            reader = new System.IO.StreamReader(responseStream, Encoding.GetEncoding("UTF-8"));
            responseStr = reader.ReadToEnd();
            reader.Close();

            return responseStr;

        }
    }
}
