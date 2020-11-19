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
    public partial class FrmMain : Form
    {
        private FrmLogin frmLogin;
        private string name;
        public FrmMain(FrmLogin frmLogin,string name)
        {
            InitializeComponent();
            this.name = name;
            this.frmLogin = frmLogin;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //设置为整行被选中  
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ReadOnly = true;
            this.dateTimePicker1.Value = DateTime.Now.AddDays(-30);
            this.dateTimePicker2.Value = DateTime.Now;
            query();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Close();
        }

        public void query() {
            string parm = string.Empty;
            parm = parm + "goods=" + this.textBox1.Text;
            parm = parm + "&describe=" + this.textBox2.Text;
            parm = parm + "&bdate=" + this.dateTimePicker1.Text;
            parm = parm + "&edate=" + this.dateTimePicker2.Text;
            string strRes = HttpHelp.Http("GET", @"/api/Goods/Get", parm);
            if (string.IsNullOrEmpty(strRes))
            {
                MessageBox.Show("网络请求有误，请重试！");
            }
            else
            {
                ResData<List<GoodsId>> res = JsonConvert.DeserializeObject<ResData<List<GoodsId>>>(strRes);
                if (res.code == -1)
                {
                    MessageBox.Show(res.msg);
                }
                else
                {
                    this.dataGridView1.DataSource = res.data;
                }
            }
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            query();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGood frmGood = new FrmGood(this);
            frmGood.title = "新增";
            frmGood.ShowDialog();
            query();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //如果没记录则不处理
            if (dataGridView1.RowCount <= 0) { return; }
            if ((dataGridView1.SelectedRows[0].Cells[0].Value) == null) { return; }
            Id id = new Id();
            id.id = long.Parse( dataGridView1.SelectedRows[0].Cells["id"].Value.ToString() );
            string str = JsonConvert.SerializeObject(id);　　　　//转为字符串
            string strRes = HttpHelp.PostJson(@"/api/Goods/Del", str);
            if (string.IsNullOrEmpty(strRes))
            {
                MessageBox.Show("网络请求有误，请重试！");
            }
            else
            {
                Res res = JsonConvert.DeserializeObject<Res>(strRes);
                MessageBox.Show(res.msg);
                if (res.code == 1) {
                    //查询最新的数据
                    query();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //如果没记录则不处理
            if (dataGridView1.RowCount <= 0) { return; }
            if ((dataGridView1.SelectedRows[0].Cells[0].Value) == null) { return; }
            //获取选择行并赋值给对象
            GoodsId goodsId = new GoodsId();
            Object temp;
            goodsId.id = long.Parse( dataGridView1.SelectedRows[0].Cells["id"].Value.ToString() );
            temp = dataGridView1.SelectedRows[0].Cells["goods"].Value;
            goodsId.goods = (temp == null ? "" : temp.ToString());
            temp = dataGridView1.SelectedRows[0].Cells["describe"].Value;
            goodsId.describe = (temp == null ? "" : temp.ToString());
            temp = dataGridView1.SelectedRows[0].Cells["collect_date"].Value;
            goodsId.collect_date = (temp == null ? DateTime.Now : DateTime.Parse(temp.ToString()));

            
            temp = dataGridView1.SelectedRows[0].Cells["collect_addr"].Value;
            goodsId.collect_addr = (temp==null?"": temp.ToString());
            temp = dataGridView1.SelectedRows[0].Cells["contact_man"].Value;
            goodsId.contact_man = (temp == null ? "" : temp.ToString());
            temp = dataGridView1.SelectedRows[0].Cells["contact_phone"].Value;
            goodsId.contact_phone = (temp == null ? "" : temp.ToString());
            temp = dataGridView1.SelectedRows[0].Cells["contact_email"].Value;
            goodsId.contact_email = (temp == null ? "" : temp.ToString());
            //打开维护物品界面，并把获取的输入传过去
            FrmGood frmGood = new FrmGood(this, goodsId);
            frmGood.title = "修改";
            frmGood.ShowDialog();
            //查询最新的数据
            query();
        }

        private void m_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("谢谢使用该软件");
        }

        private void m_ext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_modpwd_Click(object sender, EventArgs e)
        {
            //打开修改密码界面  并把账号传过去
            FrmModPwd frmModPwd = new FrmModPwd(name);
            frmModPwd.ShowDialog();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            this.dataGridView1.Width = this.Width - 30;
            this.dataGridView1.Height = this.Height - 150;
        }
    }
}
