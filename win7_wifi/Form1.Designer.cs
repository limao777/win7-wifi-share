namespace win7_wifi
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.st = new System.Windows.Forms.Button();
            this.en = new System.Windows.Forms.Button();
            this.nname = new System.Windows.Forms.TextBox();
            this.psword = new System.Windows.Forms.TextBox();
            this.wifi_status = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwd_check = new System.Windows.Forms.CheckBox();
            this.psword2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(33, 87);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(91, 30);
            this.st.TabIndex = 0;
            this.st.Text = "建立";
            this.st.UseVisualStyleBackColor = true;
            this.st.Click += new System.EventHandler(this.st_Click);
            // 
            // en
            // 
            this.en.Location = new System.Drawing.Point(160, 87);
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(91, 30);
            this.en.TabIndex = 1;
            this.en.Text = "删除并退出";
            this.en.UseVisualStyleBackColor = true;
            this.en.Click += new System.EventHandler(this.en_Click);
            // 
            // nname
            // 
            this.nname.Location = new System.Drawing.Point(101, 9);
            this.nname.Name = "nname";
            this.nname.Size = new System.Drawing.Size(100, 21);
            this.nname.TabIndex = 2;
            // 
            // psword
            // 
            this.psword.Location = new System.Drawing.Point(101, 48);
            this.psword.Name = "psword";
            this.psword.PasswordChar = '*';
            this.psword.Size = new System.Drawing.Size(100, 21);
            this.psword.TabIndex = 3;
            // 
            // wifi_status
            // 
            this.wifi_status.Location = new System.Drawing.Point(12, 133);
            this.wifi_status.Multiline = true;
            this.wifi_status.Name = "wifi_status";
            this.wifi_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.wifi_status.Size = new System.Drawing.Size(268, 130);
            this.wifi_status.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "名字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码：";
            // 
            // pwd_check
            // 
            this.pwd_check.AutoSize = true;
            this.pwd_check.Location = new System.Drawing.Point(208, 53);
            this.pwd_check.Name = "pwd_check";
            this.pwd_check.Size = new System.Drawing.Size(72, 16);
            this.pwd_check.TabIndex = 7;
            this.pwd_check.Text = "显示密码";
            this.pwd_check.UseVisualStyleBackColor = true;
            this.pwd_check.CheckedChanged += new System.EventHandler(this.pwd_changed);
            // 
            // psword2
            // 
            this.psword2.Location = new System.Drawing.Point(101, 49);
            this.psword2.Name = "psword2";
            this.psword2.Size = new System.Drawing.Size(100, 21);
            this.psword2.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 3500;
            this.timer1.Tick += new System.EventHandler(this.time_tickk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 21);
            this.button1.TabIndex = 9;
            this.button1.Text = "关于";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.psword2);
            this.Controls.Add(this.pwd_check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wifi_status);
            this.Controls.Add(this.psword);
            this.Controls.Add(this.nname);
            this.Controls.Add(this.en);
            this.Controls.Add(this.st);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Win7建立无线热点";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button st;
        private System.Windows.Forms.Button en;
        private System.Windows.Forms.TextBox nname;
        private System.Windows.Forms.TextBox psword;
        private System.Windows.Forms.TextBox wifi_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox pwd_check;
        private System.Windows.Forms.TextBox psword2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

