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
    public partial class FrmReg : Form
    {
        private FrmLogin frmLogin;
        public FrmReg(FrmLogin frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.name = textBox1.Text;
            user.nikename = textBox3.Text;
            user.pwd = textBox2.Text;
            string str = JsonConvert.SerializeObject(user);　　　　//转为字符串
            string strRes =  HttpHelp.PostJson( @"/api/User/Register", str);
            if (string.IsNullOrEmpty(strRes))
            {
                MessageBox.Show("网络请求有误，请重试！");
            }
            else {
                Res res = JsonConvert.DeserializeObject<Res>(strRes);
                MessageBox.Show(res.msg);
            }
        }

        private void FrmReg_Load(object sender, EventArgs e)
        {

        }

        private void FrmReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Show();
        }
    }
}
