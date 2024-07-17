using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Principal;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Security;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Reflection;

namespace Windows_Tools
{
    public partial class Activation : Form
    {
        public Activation()
        {
            InitializeComponent();
        }

        private void Check_Activation_Button_Click(object sender, EventArgs e)
        {
            // 检查系统是否激活.
            Process.Start("cmd.exe", "/c slmgr -xpr");
        }

        private void KMS_Activation_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Find_KMS_Server();
            Code_Lable.Enabled = true;
            Code_TextBox.Enabled = true;
            Spw_Code.Enabled = true;
            Start_Activation_Button.Enabled = false;
            Start_Activation_Button.Text = "使用此序列号激活";
            Choose_KMS_Server_GroupBox.Enabled = true;
            if (Code_TextBox.Text == "")
            {
                Spw_Code_Click(sender, e);
            }
            else
            {
                Start_Activation_Button.Enabled = true;
            }

        }

        private void Num_Activation_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Code_Lable.Enabled = false;
            Code_TextBox.Enabled = false;
            Spw_Code.Enabled = false;
            Start_Activation_Button.Enabled = true;
            Start_Activation_Button.Text = "开始激活";
            Activations_Tips_Lable.Visible = false;
            Choose_KMS_Server_GroupBox.Enabled = false;
        }

        private void OEM_Activation_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Code_Lable.Enabled = false;
            Code_TextBox.Enabled = false;
            Spw_Code.Enabled = false;
            Start_Activation_Button.Enabled = true;
            Start_Activation_Button.Text = "开始激活";
            Activations_Tips_Lable.Visible = false;
            Choose_KMS_Server_GroupBox.Enabled = false;
        }



        // 开始激活
        private void Start_Activation_Button_Click(object sender, EventArgs e)
        {
            if (HWID_Activation_RadioButton.Checked == true)
            {
                MessageBox.Show("此功能正在施工中……", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (KMS_Activation_RadioButton.Checked == true)
            {
                Find_KMS_Server();
                DialogResult result = MessageBox.Show("即将连接 KMS 服务器 " + Choose_KMS_Server_ComboBox.Text + "并尝试使用序列号 " + Code_TextBox.Text + " 进行激活，继续吗？", "激活组件", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("稍后将出现一个命令提示符或 Power Shell 窗口，不要关闭它，你应该等待它自行关闭。\n\n系统的激活状态大概会每隔 180 天进行一次自动续期，你只需 180 天内联网一次即可。\n\n当然，你选择的 KMS 服务器也可能会跑路导致你无法续签，到时候换个 KMS 服务器再来一次就行。", "激活组件", MessageBoxButtons.OK);
                    // 专业版
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 0)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 专业版 N
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 1)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk MH37W-N47XK-V7XM9-C7227-GCQG9");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 专业工作站版
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 2)
                    {
                        Process.Start("cmd.exe", "slmgr /ipk NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 专业工作站版 N
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 3)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk 9FNHH-K3HBT-3W4TD-6383H-6XYWF");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }           
                    // 专业教育版
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 4)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk 6TP4R-GNPTD-KYYHQ-7B7DP-J447Y");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 专业教育版 N
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 5)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk YVWGF-BXNMC-HTQYQ-CPQ99-66QFC");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 教育版
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 6)
                    {
                        Process.Start("cmd.exe", "/c cd slmgr /ipk NW6C2-QMPVW-D7KKK-3GKT6-VCFB2");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 教育版 N
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 7)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 企业版
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 8)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk NPPR9-FWDCX-D2C8J-H872K-2YT43");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 企业版 N
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 9)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 企业版 G
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 10)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk YYVX9-NTFWV-6MDM3-9PT4T-4M68B");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }
                    // 企业版 G N
                    if (Set_Activation_Version_ComboBox.SelectedIndex == 11)
                    {
                        Process.Start("cmd.exe", "/c slmgr /ipk 44RPN-FTY23-9VTTB-MP9BX-T84FV");
                        Process.Start("cmd.exe", "/c slmgr /skms " + Choose_KMS_Server_ComboBox.Text);
                    }                                       
                    return;
                }
                else
                {
                    return;
                }
            }
            if (OEM_Activation_RadioButton.Checked == true)
            {
                MessageBox.Show("此功能正在施工中……", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*DialogResult result = MessageBox.Show("将伪装成品牌机进行 OEM 激活，继续吗？", "激活组件", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }*/
            }
        }

        private void GetKMSServerList()
        {            
            
        }


        private void Code_TextBox_TextChanged(object sender, EventArgs e)
        {            
            // 小写字母转换为大写
            Code_TextBox.Text = Code_TextBox.Text.ToUpper();
            Code_TextBox.SelectionStart = Code_TextBox.Text.Length;

            // 限制输入长度
            if (Code_TextBox.Text.Length > 29)
            {
                Code_TextBox.Text = Code_TextBox.Text.Remove(Code_TextBox.Text.Length - 1, 1);
            }
            // 自动处理序列号的格式
            string Automatic_Processing_Code = Code_TextBox.Text.Replace("-", "");
            if (Automatic_Processing_Code.Length > 29)
            {
                Automatic_Processing_Code = Automatic_Processing_Code.Substring(0, 29);
            }
            // 构建字符串
            string formattedText = "";
            for (int i = 0; i < Automatic_Processing_Code.Length; i++)
            {
                if (i > 0 && i % 5 == 0)
                {
                    formattedText += "-";
                }
                formattedText += Automatic_Processing_Code[i];
            }
            // 更新TextBox的内容
            Code_TextBox.Text = formattedText;
            Code_TextBox.SelectionStart = formattedText.Length;

            // 不能出现字母A、E、I、L、O、S、Z和数字1和0，因为这些字符根本不会出现在 Wiindows 的激活序列号中
            if (Regex.IsMatch(Code_TextBox.Text, @"[aeloszAELOSZ10]"))
            {
                Activations_Tips_Lable.Visible = true;               
                return;
            }
            else
            {
                Activations_Tips_Lable.Visible = false;
                Rearrange_the_Components_Default();
            }

            // 输入格式正确的序列号后，激活按钮可以点击。
            if (Regex.IsMatch(Code_TextBox.Text, @"^[BCDFGHJKMNPQRTUVWXY23456789-]{5}-[BCDFGHJKMNPQRTUVWXY23456789-]{5}-[BCDFGHJKMNPQRTUVWXY23456789-]{5}-[BCDFGHJKMNPQRTUVWXY23456789-]{5}-[BCDFGHJKMNPQRTUVWXY23456789-]{5}$"))
            {
                Start_Activation_Button.Enabled = true;
            }
            else
            {
                Start_Activation_Button.Enabled = false;
            }

        }

        private void Activation_Load(object sender, EventArgs e)
        {
            Choose_KMS_Server_GroupBox.Enabled = false;
            GetKMSServerList();
            Set_Activation_Version_ComboBox.SelectedIndex = 0;
            Office_Setup_Version_ComboBox.SelectedIndex = 0;
            Choose_KMS_Server_ComboBox.SelectedIndex = 0;


        }
        // 初始化
        private const string ValidCharacters = "BCDFGHJKMNPQRTUVWXY23456789";
        private const int GroupSize = 5;
        private const int GroupDelimiterLength = 1;
        private Random random = new Random();

        // 复原组件
        private void Rearrange_the_Components_Default()
        {
            this.Height = 435;
            Activations_Tips_Lable.Enabled = false;
            Check_Activation_Button.Location = new Point(8, 97);
            Backup_Windows_Key_Button.Location = new Point(174, 97);
            Start_Activation_Button.Location = new Point(340, 97);
            Activation_Windows.Location = new Point(13, 13);
            Activation_Office.Location = new Point(13, 160);
            Choose_KMS_Server_GroupBox.Location = new Point(13, 266);
            Activation_Windows.Size = new Size(500, 140);
        }

        private void Spw_Code_Click(object sender, EventArgs e)
        {
            StringBuilder serialNumber = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < GroupSize; j++)
                {
                    serialNumber.Append(ValidCharacters[random.Next(ValidCharacters.Length)]);
                }
                if (i < 4)
                {
                    serialNumber.Append('-');
                }
            }

            Code_TextBox.Text = serialNumber.ToString();
            Start_Activation_Button.Enabled = true;

            // 如果按下 Alt 键的同时点击 Spw_Code 按钮，则将 Code_TextBox 中的内容复制到剪贴板。
            if (ModifierKeys == Keys.Alt)
            {
                if (Code_TextBox.Text != "")
                {
                    Clipboard.SetText(Code_TextBox.Text);
                    MessageBox.Show("序列号已复制到剪贴板。", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
        }

        private void Get_Ping_Button_Click(object sender, EventArgs e)
        {
            Find_KMS_Server();
        }

        private void Find_KMS_Server()
        {
            try
            {
                // 鼠标指针置为loading
                Cursor.Current = Cursors.WaitCursor;
                Start_Activation_Button.Enabled = false;
                Start_Activation_Button.Text = "正在寻找可用服务器 ……";

                // 遍历列表
                string[] servers = new string[Choose_KMS_Server_ComboBox.Items.Count];
                for (int i = 0; i < Choose_KMS_Server_ComboBox.Items.Count; i++)
                {
                    servers[i] = Choose_KMS_Server_ComboBox.Items[i].ToString();
                }
                // 取得Ping值
                int[] pings = new int[servers.Length];
                for (int i = 0; i < servers.Length; i++)
                {
                    pings[i] = PingServer(servers[i]);
                }
                // 找出最小Ping值
                int minPing = pings[0];
                int minIndex = 0;

                for (int i = 1; i < pings.Length; i++)
                {
                    if (pings[i] < minPing)
                    {
                        minPing = pings[i];
                        minIndex = i;
                    }

                }

                Choose_KMS_Server_ComboBox.SelectedIndex = minIndex;

                // 恢复鼠标指针
                Cursor.Current = Cursors.Default;
                Start_Activation_Button.Enabled = true;
                Start_Activation_Button.Text = "开始激活";
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错了" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int PingServer(string server)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(server);
                    if (reply.Status == IPStatus.Success)
                    {
                        return (int)reply.RoundtripTime;
                    }
                    else
                    {
                        return int.MaxValue;
                    }
                }
            }
            catch
            {
                return int.MaxValue;
            }
        }


        private void Backup_Office_Key_Button_Click(object sender, EventArgs e)
        {
            string Get_Office_Key = "C:\\Program Files\\Microsoft Office\\Office16\\OSPP.HTM";
            try
            {
                string[] lines = File.ReadAllLines(Get_Office_Key);
                foreach (string line in lines)
                {
                    if (line.Contains("ospp.vbs /inpkey:"))
                    {
                        string key = line.Substring(line.IndexOf("ospp.vbs /inpkey:") + 17, 23);
                        Clipboard.SetText(key);
                        // 赋值
                        string Office_Key = key;
                        MessageBox.Show("取得当前 Office 序列号为 " + Office_Key + " ，并已复制到剪切板，请妥善保存。\n\n但请注意：即使登录同一账号、使用同一设备，你可能也无法使用这个序列号激活 Offcie 产品。", "已截取当前的 Office 密钥", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("无法截取序列号，可能是你还没安装 Office。\n\n 另外，本程序暂时不支持激活 UWP 版本的 Office。", "出错了", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void What_This_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("带 “N” 的版本：去除了 Windows Media Player 的版本；\n\n带 “G” 的版本：各版本的增强版；\n\n专业工作站版：支持 ReFS、Ersistent Memory、Faster File Sharing 以及 Expanded Hardware，专业工作站版的硬件支持多达 4 路 CPU 和 6TB 内存， 包括 Intel Xeon 和 AMD Opteron. \n\n对于个人用户，建议使用专业版。", "各版本说明");
        }

        private void HWID_Activation()
        {
            if (MessageBox.Show("数字权利许可激活是最推荐的方式，此方法耗时较长，但之后可以绑定你的微软账号。只要没有更换主板，不论几次重装系统，都可以直接登录微软账号激活。\n\n现在开始使用数字权利许可证激活吗？", "数字权力许可证激活", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("稍后将出现一个命令提示符或 Power Shell 窗口，不要关闭它，你应该等待它自行关闭。", "提示", MessageBoxButtons.OK);
                return;
            }
            else
            {
                return;
            }
        }

        private void Backup_Windows_Key_Button_Click(object sender, EventArgs e)
        {
            // 取得激活码           
            string Registry_Path_64 = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform";
            string Registry_Path_32 = @"SOFTWARE\WoW6432Node\Microsoft\Windows NT\CurrentVersion\SoftwareProtectionPlatform";
            string keyName = "BackupProductKeyDefault";

            // 捕获当前系统激活码
            if (Environment.Is64BitOperatingSystem)
            {
                using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(Registry_Path_64, false))
                {
                    if (key != null)
                    {
                        string ProductKey64 = (string)key.GetValue(keyName);
                        if (!string.IsNullOrEmpty(ProductKey64))
                        {
                            MessageBox.Show("取得本机目前的激活序列号：" + ProductKey64 + "，已写入剪切板，请妥善保存。", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 将激活码写入剪贴板
                            Clipboard.SetText(ProductKey64);
                        }
                        else
                        {
                            MessageBox.Show("无法读取激活码，可能是权限不足。", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("无法读取激活码，可能是权限不足。", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(Registry_Path_32, false))
                {
                    if (key != null)
                    {
                        string ProductKey32 = (string)key.GetValue(keyName);
                        if (!string.IsNullOrEmpty(ProductKey32))
                        {
                            MessageBox.Show("取得本机目前的激活序列号：" + ProductKey32 + "，已写入剪切板，请妥善保存。", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 将激活码写入剪贴板
                            Clipboard.SetText(ProductKey32);
                        }
                        else
                        {
                            MessageBox.Show("无法读取激活码，可能是权限不足。", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("无法读取激活码，可能是权限不足。", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void HWID_Activation_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("此功能正在施工中……", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Code_Lable.Enabled = false;
            Code_TextBox.Enabled = false;
            Spw_Code.Enabled = false;
            Choose_KMS_Server_GroupBox.Enabled = false;
            Start_Activation_Button.Text = "开始激活";
        }

        private void OEM_Activation_RadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            // MessageBox.Show("此功能正在施工中……", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Code_Lable.Enabled = false;
            Code_TextBox.Enabled = false;
            Spw_Code.Enabled = false;
            Choose_KMS_Server_GroupBox.Enabled = false;
            Start_Activation_Button.Text = "开始激活";
        }

        private void Start_Activation_Office_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能正在施工中……", "激活组件", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

