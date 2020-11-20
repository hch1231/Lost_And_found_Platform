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
    public partial class FrmModPwd : Form
    {
        private string name;
        public FrmModPwd(string name)
        {
            InitializeComponent();
            this.name = name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string newpwd2 = string.Empty;
            newpwd2 = t_newpwd2.Text;
            UserPwd user = new UserPwd();
            user.name = name;
            user.oldpwd = t_oldpwd.Text;
            user.newpwd = t_newpwd.Text;
            if (string.IsNullOrEmpty(user.oldpwd) || string.IsNullOrEmpty(user.newpwd) || string.IsNullOrEmpty(newpwd2))
            {
                MessageBox.Show("所有项目必须输入");
                return;
            }
            else if(!user.newpwd.Equals(newpwd2))
            {
                MessageBox.Show("新密码和再次确认密码不一致");
                return;
            }
            string str = JsonConvert.SerializeObject(user);　　　　//转为字符串
            string strRes =  HttpHelp.PostJson(@"/api/User/ModPwd", str);
            if (string.IsNullOrEmpty(strRes))
            {
                MessageBox.Show("网络请求有误，请重试！");
            }
            else {
                Res res = JsonConvert.DeserializeObject<Res>(strRes);
                MessageBox.Show(res.msg);
            }
        }
        
    }
}
