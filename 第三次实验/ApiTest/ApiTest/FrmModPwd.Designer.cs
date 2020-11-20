namespace ApiTest
{
    partial class FrmModPwd
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
            this.button1 = new System.Windows.Forms.Button();
            this.t_newpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_oldpwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_newpwd2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_newpwd
            // 
            this.t_newpwd.Location = new System.Drawing.Point(259, 143);
            this.t_newpwd.Name = "t_newpwd";
            this.t_newpwd.PasswordChar = '*';
            this.t_newpwd.Size = new System.Drawing.Size(333, 28);
            this.t_newpwd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "新密码：";
            // 
            // t_oldpwd
            // 
            this.t_oldpwd.Location = new System.Drawing.Point(259, 88);
            this.t_oldpwd.Name = "t_oldpwd";
            this.t_oldpwd.PasswordChar = '*';
            this.t_oldpwd.Size = new System.Drawing.Size(333, 28);
            this.t_oldpwd.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "旧密码：";
            // 
            // t_newpwd2
            // 
            this.t_newpwd2.Location = new System.Drawing.Point(259, 191);
            this.t_newpwd2.Name = "t_newpwd2";
            this.t_newpwd2.PasswordChar = '*';
            this.t_newpwd2.Size = new System.Drawing.Size(333, 28);
            this.t_newpwd2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "再次确认密码：";
            // 
            // FrmModPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t_newpwd2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_oldpwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_newpwd);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModPwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_newpwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_oldpwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_newpwd2;
        private System.Windows.Forms.Label label4;
    }
}