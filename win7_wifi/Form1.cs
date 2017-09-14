using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace win7_wifi
{
    public partial class Form1 : Form
    {
        //dosCommand Dos命令语句
        public string cmd(string dosCommand)
        {
            return cmd(dosCommand, 30000);
        }
        /// <summary>
        /// 执行DOS命令，返回DOS命令的输出
        /// </summary>
        /// <param name="dosCommand">dos命令</param>
        /// <param name="milliseconds">等待命令执行的时间（单位：毫秒），
        /// 如果设定为0，则无限等待</param>
        /// <returns>返回DOS命令的输出</returns>
        public static string cmd(string command, int seconds)
        {
            string output = ""; //输出字符串
            if (command != null && !command.Equals(""))
            {
                Process process = new Process();//创建进程对象
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";//设定需要执行的命令
                startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动
                startInfo.RedirectStandardInput = false;//不重定向输入
                startInfo.RedirectStandardOutput = true; //重定向输出
                startInfo.CreateNoWindow = true;//不创建窗口
                process.StartInfo = startInfo;
                try
                {
                    if (process.Start())//开始进程
                    {
                        if (seconds == 0)
                        {
                            process.WaitForExit();//这里无限等待进程结束
                        }
                        else
                        {
                            process.WaitForExit(seconds); //等待进程结束，等待时间为指定的毫秒
                        }
                        output = process.StandardOutput.ReadToEnd();//读取进程的输出
                    }
                }
                catch
                {
                }
                finally
                {
                    if (process != null)
                        process.Close();
                }
            }
            return output;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void st_Click(object sender, EventArgs e)
        {
            string temp_psword;
            if (pwd_check.Checked == true)
            {
                temp_psword = psword2.Text;

            }
            else {
                temp_psword = psword.Text;
            }
            if (temp_psword.Length < 8)
            {
                MessageBox.Show("密码长度需大于8位~~~", "提示~");
            }
            else
            {
                wifi_status.Text = cmd("netsh wlan set hostednetwork mode=allow ssid=" + nname.Text + " key=" + temp_psword);
                wifi_status.Text += cmd("netsh wlan start hostednetwork");

                if (File.Exists("LM.ini"))
                {
                    System.IO.StreamWriter lm = new System.IO.StreamWriter("LM.ini");
                    lm.WriteLine(nname.Text);

                    //密码加密
                    char[] temp_w = temp_psword.ToCharArray();
                    temp_w[0] = (char)(temp_w[0] - 1);
                    temp_w[1] = (char)(temp_w[1] - 5);
                    temp_w[2] = (char)(temp_w[2] - 3);
                    temp_w[3] = (char)(temp_w[3] + 1);
                    temp_w[4] = (char)(temp_w[4] + temp_w[5]);
                    temp_w[5] = (char)(temp_w[5] + 25 - temp_w[0]);
                    temp_w[6] = (char)(temp_w[6] - 3);
                    temp_w[7] = (char)(temp_w[7] + 10);
                    string temp_ww = new string(temp_w);
                    lm.WriteLine(temp_ww);
                    lm.Close();
                    lm.Dispose();
                }


                st.Enabled = false;
                psword.Enabled = false;
                psword2.Enabled = false;
                nname.Enabled = false;
                wifi_status.Text += "完成！";
            }
        }

        private void en_Click(object sender, EventArgs e)
        {
            wifi_status.Text = cmd("netsh wlan stop hostednetwork");
            wifi_status.Text += cmd("netsh wlan set hostednetwork mode=disallow");
            wifi_status.Text += "程序即将退出……";
            timer1.Enabled = true;
        }

        private void pwd_changed(object sender, EventArgs e)
        {

            if (pwd_check.Checked == true)
            {
                psword2.Visible = true;
                psword2.Text = psword.Text;
            }
            else {
                psword2.Visible = false;
                psword.Text = psword2.Text;
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            psword2.Visible = false;
            if (File.Exists("LM.ini")) {
                System.IO.StreamReader test = new System.IO.StreamReader("LM.ini");
                nname.Text = test.ReadLine();

                //密码解密
                string temp_jm=test.ReadLine();
                char[] temp_jmch = temp_jm.ToCharArray();
                temp_jmch[0] = (char)(temp_jmch[0] + 1);
                temp_jmch[1] = (char)(temp_jmch[1] + 5);
                temp_jmch[2] = (char)(temp_jmch[2] + 3);
                temp_jmch[3] = (char)(temp_jmch[3] - 1);
                temp_jmch[5] = (char)(temp_jmch[5] - 26 + temp_jmch[0]);
                temp_jmch[4] = (char)(temp_jmch[4] - temp_jmch[5]);
                temp_jmch[6] = (char)(temp_jmch[6] + 3);
                temp_jmch[7] = (char)(temp_jmch[7] - 10);
                string temp_jmww = new string(temp_jmch);
                 if (pwd_check.Checked == true)
            {
                
                psword2.Text  = temp_jmww;
            }
            else {

                psword.Text = temp_jmww;
            }
                 test.Close();
                 test.Dispose();
            }
            else{
                StreamWriter sw = File.CreateText("LM.ini");
                sw.WriteLine("Maozi");

                char[] temp_2w = "12345678".ToCharArray();
                temp_2w[0] = (char)(temp_2w[0] - 1);
                temp_2w[1] = (char)(temp_2w[1] - 5);
                temp_2w[2] = (char)(temp_2w[2] - 3);
                temp_2w[3] = (char)(temp_2w[3] + 1);
                temp_2w[4] = (char)(temp_2w[4] + temp_2w[5]);
                temp_2w[5] = (char)(temp_2w[5] + 25 - temp_2w[0]);
                temp_2w[6] = (char)(temp_2w[6] - 3);
                temp_2w[7] = (char)(temp_2w[7] + 10);
                string temp_2ww = new string(temp_2w);
                sw.WriteLine(temp_2ww);
                nname.Text = "Maozi";
                psword.Text = "12345678";
                sw.Close();
                sw.Dispose();
            }
            
        }

        private void time_tickk(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Powered by M.Lee 2013.05 供win7用……\r\n基于BSD许可证,重庆邮电大学自动化学院2009级强化班", "O(∩_∩)O关于~");
            
           

        }
    }
}
