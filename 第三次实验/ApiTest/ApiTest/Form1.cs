using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ApiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Post
        /// </summary>
        /// <param name="data">提交的数据</param>
        /// <param name="url">提交的地址</param>
        /// <returns></returns>
        public string Post(string data, string url)
        {
            string responseStr = "";

            //注意提交的编码 这边是需要改变的 这边默认的是Default：系统当前编码
            byte[] postData = Encoding.UTF8.GetBytes(data);

            // 设置提交的相关参数 
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            Encoding myEncoding = Encoding.UTF8;
            request.Method = "POST";
            request.KeepAlive = false;
            request.AllowAutoRedirect = true;
            request.ContentType = "application/json";


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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //点击测试事件
        private void bt_releaseGoods_Click(object sender, EventArgs e)
        {
            txt_res.Text = Post(txt_releaseGoods.Text.Trim(), txt_api.Text);
        }
    }
}
