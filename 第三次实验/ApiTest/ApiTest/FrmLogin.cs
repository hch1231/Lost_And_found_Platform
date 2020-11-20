using ApiTest.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApiTest
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmReg frmReg = new FrmReg(this);
            frmReg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = textBox1.Text;
            user.pwd = textBox2.Text;
            string str = JsonConvert.SerializeObject(user);　　　　//转为字符串
            string strRes = HttpHelp.PostJson(@"/api/User/Login", str);
            if (string.IsNullOrEmpty(strRes))
            {
                MessageBox.Show("网络请求有误，请重试！");
            }
            else
            {
                Res res = JsonConvert.DeserializeObject<Res>(strRes);
                MessageBox.Show(res.msg);
                if (res.code == 1) {
                    FrmMain frmMain = new FrmMain(this, user.name);
                    frmMain.Show();
                    this.Hide();
                }
            }
        }
    }
}
