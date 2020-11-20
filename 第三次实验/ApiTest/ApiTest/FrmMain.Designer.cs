namespace ApiTest
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collect_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collect_addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_man = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_xt = new System.Windows.Forms.ToolStripMenuItem();
            this.m_modpwd = new System.Windows.Forms.ToolStripMenuItem();
            this.m_ext = new System.Windows.Forms.ToolStripMenuItem();
            this.m_help = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 28);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "物品：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(330, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 28);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "描述：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(639, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 28);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "拾获日期：";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(811, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 28);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(788, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.goods,
            this.describe,
            this.collect_date,
            this.collect_addr,
            this.contact_man,
            this.contact_phone,
            this.contact_email});
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1377, 457);
            this.dataGridView1.TabIndex = 16;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // goods
            // 
            this.goods.DataPropertyName = "goods";
            this.goods.HeaderText = "物品";
            this.goods.Name = "goods";
            this.goods.Width = 200;
            // 
            // describe
            // 
            this.describe.DataPropertyName = "describe";
            this.describe.HeaderText = "描述";
            this.describe.Name = "describe";
            this.describe.Width = 400;
            // 
            // collect_date
            // 
            this.collect_date.DataPropertyName = "collect_date";
            this.collect_date.HeaderText = "拾获日期";
            this.collect_date.Name = "collect_date";
            this.collect_date.Width = 180;
            // 
            // collect_addr
            // 
            this.collect_addr.DataPropertyName = "collect_addr";
            this.collect_addr.HeaderText = "拾获地址";
            this.collect_addr.Name = "collect_addr";
            this.collect_addr.Width = 200;
            // 
            // contact_man
            // 
            this.contact_man.DataPropertyName = "contact_man";
            this.contact_man.HeaderText = "联系人";
            this.contact_man.Name = "contact_man";
            // 
            // contact_phone
            // 
            this.contact_phone.DataPropertyName = "contact_phone";
            this.contact_phone.HeaderText = "联系电话";
            this.contact_phone.Name = "contact_phone";
            // 
            // contact_email
            // 
            this.contact_email.DataPropertyName = "contact_email";
            this.contact_email.HeaderText = "EMAIL";
            this.contact_email.Name = "contact_email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(990, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 17;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1098, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1311, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 31);
            this.button3.TabIndex = 20;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1203, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 31);
            this.button4.TabIndex = 19;
            this.button4.Text = "修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_xt,
            this.m_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1404, 32);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_xt
            // 
            this.m_xt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_modpwd,
            this.m_ext});
            this.m_xt.Name = "m_xt";
            this.m_xt.Size = new System.Drawing.Size(58, 28);
            this.m_xt.Text = "系统";
            // 
            // m_modpwd
            // 
            this.m_modpwd.Name = "m_modpwd";
            this.m_modpwd.Size = new System.Drawing.Size(164, 30);
            this.m_modpwd.Text = "修改密码";
            this.m_modpwd.Click += new System.EventHandler(this.m_modpwd_Click);
            // 
            // m_ext
            // 
            this.m_ext.Name = "m_ext";
            this.m_ext.Size = new System.Drawing.Size(164, 30);
            this.m_ext.Text = "退出";
            this.m_ext.Click += new System.EventHandler(this.m_ext_Click);
            // 
            // m_help
            // 
            this.m_help.Name = "m_help";
            this.m_help.Size = new System.Drawing.Size(58, 28);
            this.m_help.Text = "帮助";
            this.m_help.Click += new System.EventHandler(this.m_help_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 565);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "失物招领管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods;
        private System.Windows.Forms.DataGridViewTextBoxColumn describe;
        private System.Windows.Forms.DataGridViewTextBoxColumn collect_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn collect_addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_man;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact_email;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_xt;
        private System.Windows.Forms.ToolStripMenuItem m_modpwd;
        private System.Windows.Forms.ToolStripMenuItem m_ext;
        private System.Windows.Forms.ToolStripMenuItem m_help;
    }
}