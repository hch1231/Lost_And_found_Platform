namespace ApiTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_api = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_releaseGoods = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.bt_releaseGoods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "接口地址";
            // 
            // txt_api
            // 
            this.txt_api.Location = new System.Drawing.Point(140, 22);
            this.txt_api.Name = "txt_api";
            this.txt_api.Size = new System.Drawing.Size(438, 28);
            this.txt_api.TabIndex = 1;
            this.txt_api.Text = "https://localhost:44307/api/Goods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "发布失物招领信息";
            // 
            // txt_releaseGoods
            // 
            this.txt_releaseGoods.Location = new System.Drawing.Point(57, 97);
            this.txt_releaseGoods.Multiline = true;
            this.txt_releaseGoods.Name = "txt_releaseGoods";
            this.txt_releaseGoods.Size = new System.Drawing.Size(440, 153);
            this.txt_releaseGoods.TabIndex = 3;
            this.txt_releaseGoods.Text = resources.GetString("txt_releaseGoods.Text");
            // 
            // txt_res
            // 
            this.txt_res.Location = new System.Drawing.Point(604, 12);
            this.txt_res.Multiline = true;
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(621, 480);
            this.txt_res.TabIndex = 4;
            // 
            // bt_releaseGoods
            // 
            this.bt_releaseGoods.Location = new System.Drawing.Point(503, 76);
            this.bt_releaseGoods.Name = "bt_releaseGoods";
            this.bt_releaseGoods.Size = new System.Drawing.Size(75, 34);
            this.bt_releaseGoods.TabIndex = 5;
            this.bt_releaseGoods.Text = "测试";
            this.bt_releaseGoods.UseVisualStyleBackColor = true;
            this.bt_releaseGoods.Click += new System.EventHandler(this.bt_releaseGoods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 504);
            this.Controls.Add(this.bt_releaseGoods);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.txt_releaseGoods);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_api);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_api;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_releaseGoods;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.Button bt_releaseGoods;
    }
}

