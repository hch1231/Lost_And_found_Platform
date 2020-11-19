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
    public partial class FrmGood : Form
    {
        private FrmMain main;
        public string title;
        public GoodsId _goods;
        public FrmGood(FrmMain main)
        {
            InitializeComponent();

            this.main = main;
            
        }
        public FrmGood(FrmMain main, GoodsId goods)
        {
            InitializeComponent();

            this.main = main;

            this._goods = goods;
            t_goods.Text = this._goods.goods;
            t_describe.Text = this._goods.describe ;
            t_collect_addr.Text = this._goods.collect_addr;
            dateTimePicker1.Value = this._goods.collect_date ;
            t_contact_man.Text = this._goods.contact_man ;
            t_contact_phone.Text = this._goods.contact_phone ;
            t_contact_email.Text = this._goods.contact_email  ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add() {
            Goods goods = new Goods();
            goods.goods = t_goods.Text;
            goods.describe = t_describe.Text;
            goods.collect_addr = t_collect_addr.Text;
            goods.collect_date = dateTimePicker1.Value.Date;
            goods.contact_man = t_contact_man.Text;
            goods.contact_phone = t_contact_phone.Text;
            goods.contact_email = t_contact_email.Text;
            string str = JsonConvert.SerializeObject(goods);　　　　//转为字符串
            string strRes = HttpHelp.PostJson(@"/api/Goods/Release", str);
            if (string.IsNullOrEmpty(strRes))
            {
                MessageBox.Show("网络请求有误，请重试！");
            }
            else
            {
                Res res = JsonConvert.DeserializeObject<Res>(strRes);
                MessageBox.Show(res.msg);
                if (res.code == 1) {
                    this.Close();
                }
            }
        }
        private void mod()
        {
            GoodsId goods = new GoodsId();
            goods.id = _goods.id;
            goods.goods = t_goods.Text;
            goods.describe = t_describe.Text;
            goods.collect_addr = t_collect_addr.Text;
            goods.collect_date = dateTimePicker1.Value.Date;
            goods.contact_man = t_contact_man.Text;
            goods.contact_phone = t_contact_phone.Text;
            goods.contact_email = t_contact_email.Text;
            string str = JsonConvert.SerializeObject(goods);　　　　//转为字符串
            string strRes = HttpHelp.PostJson(@"/api/Goods/Mod", str);
            if (string.IsNullOrEmpty(strRes))
            {
                MessageBox.Show("网络请求有误，请重试！");
            }
            else
            {
                Res res = JsonConvert.DeserializeObject<Res>(strRes);
                MessageBox.Show(res.msg);
                if (res.code == 1)
                {
                    this.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (_goods == null)
            {
                add();
            }
            else {
                mod();
            }
        }

        private void FrmGood_Load(object sender, EventArgs e)
        {
            this.Text = title;
        }
    }
}
