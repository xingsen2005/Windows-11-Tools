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
using System.Diagnostics;
using System.Management;
using System.IO;

namespace Windows_Tools
{
    public partial class Main_Window : Form
    {        
        public Main_Window()
        {
            InitializeComponent();
            Taskbar_UP_RadioButton.CheckedChanged += Taskbar_Position_Changed;
            Taskbar_Down_RadioButton.CheckedChanged += Taskbar_Position_Changed;
            Taskbar_Left_RadioButton.CheckedChanged += Taskbar_Position_Changed;
            Taskbar_Right_RadioButton.CheckedChanged += Taskbar_Position_Changed;
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {
            InstallGroupPolicy();
            this.Text += " Build：" + Application.ProductVersion;
            // 最小日期设置为当前系统时间；
            DateTimePicker.MinDate = DateTime.Now;           
            // 查询系统是否联网；
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == false)
            {
                MessageBox.Show("系统似乎没有联网，激活功能无法正常使用，请检查网络适配器设置。", "网络未连接", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // 打开“更改适配器设置”
                Process.Start("ms-settings:network-wired");
                // 由于没有联网，禁用激活按钮；
                Activation_Button.Enabled = false;
            }
            // 禁止重复运行；
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                Application.Exit();
            }
            // 程序打开前检查是否为管理员权限；
            if (!(new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
            {
                if (MessageBox.Show("当前程序未以管理员权限运行，部分功能可能无法使用。\n\n点击“是”则尝试以管理员身份重新启动，点击“否”则继续运行，但某些功能需要管理员权限才可以正常使用。", "权限错误", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 尝试以管理员身份重启程序；
                    Process.Start(new ProcessStartInfo(Application.ExecutablePath) { Verb = "runas" });
                }
                else
                {                    
                    return;                   
                }
                
            }            
        }
        private void InstallGroupPolicy()
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion"))
                {
                    string editionId = (string)key.GetValue("EditionID");
                    if (editionId == "Core")
                    {
                        DialogResult result = MessageBox.Show("当前系统为“家庭版”，没有“组策略编辑器”功能。现在安装吗？安装“组策略编辑器”可以实现更多的系统控制。", "安装组策略编辑器", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string currentDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
                            string windowsFolder = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
                            string clientExtensionsPattern = Path.Combine(windowsFolder, @"servicing\Packages\Microsoft-Windows-GroupPolicy-ClientExtensions-Package~3*.mum");
                            string clientToolsPattern = Path.Combine(windowsFolder, @"servicing\Packages\Microsoft-Windows-GroupPolicy-ClientTools-Package~3*.mum");

                            List<string> packages = Directory.GetFiles(clientExtensionsPattern, "*.mum", SearchOption.TopDirectoryOnly)
                                .Concat(Directory.GetFiles(clientToolsPattern, "*.mum", SearchOption.TopDirectoryOnly))
                                .ToList();

                            MessageBox.Show("组策略功能已安装，你可能需要重启计算机来应用修改。", "安装组策略包", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (packages.Count == 0)
                            {
                                MessageBox.Show("未找到组策略包。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            File.WriteAllLines(Path.Combine(currentDirectory, "List.txt"), packages);

                            foreach (var package in packages)
                            {
                                if (!ExecuteDismCommand(package))
                                {
                                    MessageBox.Show("执行安装时遇到了意料之外的错误。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法读取注册表，错误：" + ex.Message, "错误");
            }
        }

        static bool ExecuteDismCommand(string packagePath)
        {
            string dismCmd = $"dism /online /norestart /add-package \"{packagePath}\"";
            ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", $"/c {dismCmd}")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            using (Process process = new Process() { StartInfo = psi })
            {
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();
                if (process.ExitCode != 0)
                {
                    MessageBox.Show($"无法安装组策略包：{packagePath} 的安装命令无法执行。\n\n错误代码：{process.ExitCode}，输出为：" + output.Trim() + "，" + error.Trim(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                    return false;
                }
            }

            return true;
        }

        // 取得系统版本
        /*private void GetSystemProductName()
        {
            string SystemVersion;
            string productNameKey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";

            // 获取系统架构信息
            string architecture = Environment.Is64BitOperatingSystem ? "64 位" : "32 位";
            string currentBuild, displayVersion;

            // 封装方法以避免代码重复
            bool isRegistryReadSuccessful = ReadRegistryValues(productNameKey, out currentBuild, out displayVersion, architecture);

            if (!isRegistryReadSuccessful)
            {
                Console.WriteLine("无法从注册表获取系统版本信息。");
                return;
            }

            // 判断系统版本并显示程序 Build 版本
            int buildNumber;
            if (int.TryParse(currentBuild, out buildNumber))
            {
                if (buildNumber >= 22000)
                {
                    SystemVersion = "Windows 11 " + displayVersion + " " + architecture;
                }
                else if (buildNumber >= 10240)
                {
                    SystemVersion = "Windows 10 " + displayVersion + " " + architecture;
                }
                else
                {
                    Application.Exit();
                }
            }
        }*/

        // 重启资源管理器
        private void Restart_Explorer()
        {
            Process[] explorerProcesses = Process.GetProcessesByName("explorer");
            foreach (Process explorer in explorerProcesses)
            {
                explorer.Kill();
            }
        }
        // 封装清除图标缓存的方法
        private void Clear_Disktop_Icon_Cache()
        {
            try
            {
                // 删除图标缓存数据库文件
                string[] deleteIconCacheCommands = new string[]
                {
                   "attrib -h -s -r \"%userprofile%\\AppData\\Local\\IconCache.db\"",
                   "del /f \"%userprofile%\\AppData\\Local\\IconCache.db\""
                };
                foreach (string command in deleteIconCacheCommands)
                {
                    Process.Start("cmd.exe", $"/c {command}").WaitForExit();
                }

                // 删除缩略图缓存文件
                string[] deleteThumbCacheCommands = new string[]
                {
                    "attrib /s /d -h -s -r \"%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\*\"",
                    "del /f \"%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_32.db\"",
                    "del /f \"%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_96.db\"",
                    "del /f \"%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_102.db\"",
                    "del /f \"%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_256.db\"",
                    "del /f \"%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_1024.db\"",
                    "del /f \"%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_idx.db\"",
                    "del /f \"%userprofile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\thumbcache_sr.db\""
                };
                foreach (string command in deleteThumbCacheCommands)
                {
                    Process.Start("cmd.exe", $"/c {command}").WaitForExit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("清理图标缓存时出错: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*private RegistryKey GetRegistryKeyForArchitecture(string architecture)
        {
            return Environment.Is64BitOperatingSystem && architecture == "64 位"
                ? RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                : RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
        }*/

        private void Disable_ShortcutArrows_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // 定义不同位数的注册表路径；
            const string ShortcutArrows_RegistryPath_64 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons";
            const string ShortcutArrows_RegistryPath_32 = @"SOFTWARE\WoW6432Node\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons";
            // 根据系统位数选择视图；
            string RegistryPath = Environment.Is64BitOperatingSystem ? ShortcutArrows_RegistryPath_64 : ShortcutArrows_RegistryPath_32;
            RegistryView RegistryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

            if (Disable_ShortcutArrows_CheckBox.Checked)
            {
                // 如果 Shell Icons 项不存在，则创建它；
                try
                {
                    using (RegistryKey Key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView))
                    {
                        using (RegistryKey subKey = Key.CreateSubKey(RegistryPath, true))
                        {
                            // 将 29 号图标设置为空白；
                            subKey.SetValue("29", @"%systemroot%\system32\imageres.dll,197");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"设置注册表值时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    // 恢复快捷方式小箭头；
                    using (RegistryKey Key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView).OpenSubKey(RegistryPath, true))
                    {
                        Key.DeleteValue("29", true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"删除注册表值时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Clear_Disktop_Icon_Cache();
            Restart_Explorer();
        }

        private void Disable_ShieldIcon_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // 定义不同位数的注册表路径；
            const string ShieldIcon_RegistryPath_64 = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons";
            const string ShieldIcon_RegistryPath_32 = @"SOFTWARE\WoW6432Node\Microsoft\Windows\CurrentVersion\Explorer\Shell Icons";
            // 根据系统位数选择视图；
            string RegistryPath = Environment.Is64BitOperatingSystem ? ShieldIcon_RegistryPath_64 : ShieldIcon_RegistryPath_32;
            RegistryView RegistryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

            if (Disable_ShieldIcon_CheckBox.Checked)
            {
                // 如果 Shell Icons 项不存在，则创建它；
                try
                {
                    using (RegistryKey Key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView))
                    {
                        using (RegistryKey subKey = Key.CreateSubKey(RegistryPath, true))
                        {
                            // 将 77 号图标设置为空白；
                            subKey.SetValue("77", @"%systemroot%\system32\imageres.dll,197");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"设置注册表值时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    // 恢复快捷方式小箭头；
                    using (RegistryKey Key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView).OpenSubKey(RegistryPath, true))
                    {
                        Key.DeleteValue("77", true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"删除注册表值时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Clear_Disktop_Icon_Cache();
            Restart_Explorer();
        }       

        private void Disable_Update_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Disable_Update_CheckBox.Checked)
            {
                // 分别确定 64 位和 32 位的注册表路径。
                const string RegistryPath_64 = @"SOFTWARE\Microsoft\WindowsUpdate\UX\Settings";
                const string RegistryPath_32 = @"SOFTWARE\WoW6432Node\Microsoft\WindowsUpdate\UX\Settings";
                // 设置 DWORD 值。
                string Disable_Update_Time = DateTimePicker.Value.ToString("yyyy-MM-dd") + "T23:59:59Z";

                // 读取当前年月日。
                string Now_Time = DateTime.Now.ToString("yyyy-MM-dd") + "T23:59:59Z";
                // 计算当前计算机时间距离“DateTimePicker”所选时间之间的天数。
                int Disable_Update_Days = (DateTime.Parse(Now_Time) - DateTime.Parse(Disable_Update_Time)).Days;                
                // 格式化时间。
                string Disable_Update_Time_Tips = DateTimePicker.Value.ToString("yyyy年MM月dd日");
                // 判断系统位数，根据不同位数执行操作。
                string RegistryPath = Environment.Is64BitOperatingSystem ? RegistryPath_64 : RegistryPath_32;
                RegistryView RegistryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                try
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView).OpenSubKey(RegistryPath, true))
                    {
                        if (key == null)
                        {
                            MessageBox.Show("权限不足。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        key.SetValue("FlightSettingsMaxPauseDays", Disable_Update_Days);
                        key.SetValue("PauseFeatureUpdatesEndTime", Disable_Update_Time);
                        key.SetValue("PauseQualityUpdatesEndTime", Disable_Update_Time);
                        key.SetValue("PauseUpdatesExpiryTime", Disable_Update_Time);

                        key.SetValue("PauseFeatureUpdatesStartTime", Now_Time);
                        key.SetValue("PauseQualityUpdatesStartTime", Now_Time);
                        key.SetValue("PauseUpdatesStartTime", Now_Time);

                        MessageBox.Show("Windows 系统更新已被暂停到 " + Disable_Update_Time_Tips + " 。\n\n你“可能”还需要在更新设置中把“暂停时间”拉到最底部 ……", "暂停系统更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出错了：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("如果需要继续更新，打开“设置”-“Windows 更新”后再点击“继续更新”即可。", "恢复系统更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Disable_Firewall_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Disable_Firewall_CheckBox.Checked)
            {
                // 将“专用网络设置”的防火墙设置为“关闭”。
                Process.Start("cmd.exe", "/c netsh advfirewall set allprofiles state off");
                // 将“公共网络设置”的防火墙设置为“关闭”。
                Process.Start("cmd.exe", "/c netsh advfirewall set domainprofile state off");
                MessageBox.Show("专用网络和公用网络的防火墙已被设置为从不通知。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 将“专用网络设置”的防火墙设置为“开启”。
                Process.Start("cmd.exe", "/c netsh advfirewall set allprofiles state on");
                // 将“公共网络设置”的防火墙设置为“开启”。
                Process.Start("cmd.exe", "/c netsh advfirewall set domainprofile state on");
                MessageBox.Show("专用网络和公用网络的防火墙已被设置开启。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Disable_UAC_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Disable_UAC_CheckBox.Checked)
            {
                try
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
                    {
                        key.SetValue("ConsentPromptBehaviorAdmin", 0, RegistryValueKind.DWord);
                        key.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
                        MessageBox.Show("用户账户控制的通知已被设置为从不通知。", "用户账户控制", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }

            }
            else
            {
                try
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true))
                    {
                        key.SetValue("ConsentPromptBehaviorAdmin", 5, RegistryValueKind.DWord);
                        key.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
                        MessageBox.Show("用户账户控制的通知已被设置为默认。", "用户账户控制", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
        }
        private void Re_Explorer_Click(object sender, EventArgs e)
        {
            Restart_Explorer();
        }

        private void Startup_Management_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能正在施工中……", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*Startup_Management Startup_Management = new Startup_Management();
            Startup_Management.Show();
            this.Enabled = false;
            Startup_Management.FormClosed += (s, ea) => { this.Enabled = true; };
            Startup_Management.FormClosed += (s, ea) => { Startup_Management.Dispose(); };*/
        }

        private void Disable_SmartScreen_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // 分别确定 64 位和 32 位的注册表路径（检查应用和文件）。
            string System_SmartScreen_RegistryPath_64 = @"Software\Policies\Microsoft\Windows\System";
            string System_SmartScreen_RegistryPath_32 = @"Software\WoW6432Node\Policies\Microsoft\Windows\System";
            // 分别确定 64 位和 32 位的注册表路径（适用于 Microsoft Edeg 的 SmartScreen）。
            /*string Edeg_SmartScreen_RegistryPath_64 = @"Software\Microsoft\Edge\SmartScreenEnabled";
            string Edeg_SmartScreen_RegistryPath_32 = @"Software\WoW6432Node\Microsoft\Edge\SmartScreenEnabled";*/
            // 判断系统位数，根据不同位数执行操作。   
            string System_SmartScreen_RegistryPath = Environment.Is64BitOperatingSystem ? System_SmartScreen_RegistryPath_64 : System_SmartScreen_RegistryPath_32;
            // string Edeg_SmartScreen_RegistryPath = Environment.Is64BitOperatingSystem ? Edeg_SmartScreen_RegistryPath_64 : Edeg_SmartScreen_RegistryPath_32;
            RegistryView RegistryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            if (Disable_SmartScreen_CheckBox.Checked)
            {                           
                try
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView).OpenSubKey(System_SmartScreen_RegistryPath, true))
                    {
                        key.SetValue("EnableSmartScreen", 0, RegistryValueKind.DWord);
                    }
                    /*using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView).OpenSubKey(Edeg_SmartScreen_RegistryPath, true))
                    {
                        key.SetValue("Default", 1, RegistryValueKind.DWord);
                    }*/
                    MessageBox.Show("Windows 系统和 Edge 浏览器的 SmartScreen 功能已被禁用。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView).OpenSubKey(System_SmartScreen_RegistryPath, true))
                    {
                        key.SetValue("EnableSmartScreen", 1, RegistryValueKind.DWord);
                    }
                    /*using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView).OpenSubKey(Edeg_SmartScreen_RegistryPath, true))
                    {
                        key.SetValue("Default", 0, RegistryValueKind.DWord);
                    }*/
                    MessageBox.Show("Windows 系统和 Edge 浏览器的 SmartScreen 功能已被重新打开。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
        }

        private void Activation_Button_Click(object sender, EventArgs e)
        {
            Activation activation = new Activation();
            activation.Show();
            this.Enabled = false;
            activation.FormClosed += (s, ea) => { this.Enabled = true; };
            activation.FormClosed += (s, ea) => { activation.Dispose(); };
        }

        private void Github_Pages_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("本程序遵循 Apache 2.0 开源协议，点击“是”访问我的 GitHub 主页前往下载。", "开放源代码", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start("https://github.com/xingsen2005/Windows-11-Tools");
            }
            else
            {
                return;
            }
        }

        private void Disclaimer_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("安全声明：本软件的部分操作可能导致系统崩溃，执行操作前请三思，并保证你拥有解决崩溃问题的经验；\n\n版权声明：本软件提供的激活功能仅供学习参考之用，因此作者同时也提供了源码。请勿将其用于商业用途，因此引发的一切法律纠纷均由你自己负责；\n\n编译时间：2024/07/16", "免责声明", MessageBoxButtons.OK);
        }

        private void Clear_Disktop_Icon_Cache_Button_Click(object sender, EventArgs e)
        {
            Clear_Disktop_Icon_Cache();
        }

        

        private void Network_Settings_Button_Click(object sender, EventArgs e)
        {
            Network_Settings Network_Settings = new Network_Settings();
            Network_Settings.Show();
            this.Enabled = false;
            Network_Settings.FormClosed += (s, ea) => { this.Enabled = true; };
            Network_Settings.FormClosed += (s, ea) => { Network_Settings.Dispose(); };
        }

        private void Disable_Link_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            const string Shortcut_Suffix_RegistryPath_64 = @"Software\Microsoft\Windows\CurrentVersion\Explorer";
            const string Shortcut_Suffix_RegistryPath_32 = @"Software\WoW6432Node\Microsoft\Windows\CurrentVersion\Explorer";
            string RegistryPath = Environment.Is64BitOperatingSystem ? Shortcut_Suffix_RegistryPath_64 : Shortcut_Suffix_RegistryPath_32;
            RegistryView RegistryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

            try
            {
                byte[] valueBytes = Disable_Link_CheckBox.Checked
                    ? new byte[] { 0x00, 0x00, 0x00, 0x00 }
                    : new byte[] { 0x99, 0x00, 0x00, 0x00 };

                using (RegistryKey Key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView))
                using (RegistryKey subKey = Key.CreateSubKey(RegistryPath, true))
                {
                    subKey.SetValue("link", valueBytes, RegistryValueKind.Binary);
                }
                Restart_Explorer();
            }           
            catch (Exception ex)
            {
                MessageBox.Show($"设置注册表值时出错：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customize_Taskbar_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnabled = Customize_Taskbar_CheckBox.Checked;
            Taskbar_UP_RadioButton.Enabled = Taskbar_Down_RadioButton.Enabled = Taskbar_Left_RadioButton.Enabled = Taskbar_Right_RadioButton.Enabled = isEnabled;
        }

        private enum TaskbarPosition
        {
            Top = 983050,
            Bottom = 983052,
            Left = 983048,
            Right = 983051
        }

        private void SetTaskbarPosition(TaskbarPosition position)
        {
            string baseValue = "30 00 00 00 FE FF FF 7A F4 00 00 ";
            string endingValue = "00 00 00 30 00 00 00 30 00 00 00 00 00 00 00 08 04 00 00 80 07 00 00 38 04 00 00 60 00 00 00 01 00 00 00";
            string value = $"{baseValue}{((int)position).ToString("X4")} {endingValue}";

            SetTaskbarPositionInRegistry(value);
            Restart_Explorer();
        }

        private void SetTaskbarPositionInRegistry(string value)
        {
            string registryPath = Environment.Is64BitOperatingSystem
                ? @"Software\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3"
                : @"Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Explorer\StuckRects3";

            using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser,Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32))
            using (RegistryKey subKey = key.CreateSubKey(registryPath, true))
            {
                subKey.SetValue("Settings", ConvertHexToBinary(value), RegistryValueKind.Binary);
            }
        }

        private byte[] ConvertHexToBinary(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }
        
        private void Taskbar_Position_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                switch (radioButton.Name)
                {
                    case "Taskbar_UP_RadioButton": SetTaskbarPosition(TaskbarPosition.Top); break;
                    case "Taskbar_Down_RadioButton": SetTaskbarPosition(TaskbarPosition.Bottom); break;
                    case "Taskbar_Left_RadioButton": SetTaskbarPosition(TaskbarPosition.Left); break;
                    case "Taskbar_Right_RadioButton": SetTaskbarPosition(TaskbarPosition.Right); break;
                }
            }
            Restart_Explorer();
        }

        private void Disable_AD_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // 分别确定 64 位和 32 位的注册表路径。
            string System_AD_RegistryPath_64 = @"Software\Microsoft\Windows\CurrentVersion\SearchSettings";
            string System_AD_RegistryPath_32 = @"Software\WoW6432Node\Microsoft\Windows\CurrentVersion\SearchSettings";
            // 判断系统位数，根据不同位数执行操作。   
            string System_AD_RegistryPath = Environment.Is64BitOperatingSystem ? System_AD_RegistryPath_64 : System_AD_RegistryPath_32;           
            RegistryView RegistryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            if (Disable_AD_CheckBox.Checked == true)
            {
                try
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView).OpenSubKey(System_AD_RegistryPath, true))
                    {
                        key.SetValue("IsAADCloudSearchEnabled", 0, RegistryValueKind.DWord);
                        key.SetValue("IsDeviceSearchHistoryEnabled", 0, RegistryValueKind.DWord);
                        key.SetValue("IsDynamicSearchBoxEnabled", 0, RegistryValueKind.DWord);
                        key.SetValue("IsMSACloudSearchEnabled", 0, RegistryValueKind.DWord);
                        key.SetValue("SafeSearchMode", 0, RegistryValueKind.DWord);
                    }
                    Restart_Explorer();
                    MessageBox.Show("任务栏的所有搜索推荐均已被关闭。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView).OpenSubKey(System_AD_RegistryPath, true))
                    {
                        key.SetValue("IsAADCloudSearchEnabled", 1, RegistryValueKind.DWord);
                        key.SetValue("IsDeviceSearchHistoryEnabled", 1, RegistryValueKind.DWord);
                        key.SetValue("IsDynamicSearchBoxEnabled", 1, RegistryValueKind.DWord);
                        key.SetValue("IsMSACloudSearchEnabled", 1, RegistryValueKind.DWord);
                        key.SetValue("SafeSearchMode", 1, RegistryValueKind.DWord);
                    }
                    Restart_Explorer();
                    MessageBox.Show("任务栏的广告已被打开（想不通你为什么要这么做……）。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
        }

        // 恢复为默认风格的右键菜单
        private void Restore_the_Context_Menu_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string Restore_the_Context_Menu_RegistryPath_64 = @"Software\Classes\CLSID";
            string Restore_the_Context_Menu_RegistryPath_32 = @"Software\WoW6432Node\Classes\CLSID";           
            string Restore_the_Context_Menu_RegistryPath = Environment.Is64BitOperatingSystem ? Restore_the_Context_Menu_RegistryPath_64 : Restore_the_Context_Menu_RegistryPath_32;
            RegistryView RegistryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            if (Restore_the_Context_Menu_CheckBox.Checked == true)
            {
                try
                {                    
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView).CreateSubKey(Restore_the_Context_Menu_RegistryPath, true))
                    {
                        using (RegistryKey key2 = key.CreateSubKey("{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}", true))
                        {
                            key2.CreateSubKey("InprocServer32", true);
                        }
                        Restart_Explorer();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView).OpenSubKey(Restore_the_Context_Menu_RegistryPath, true))
                    {
                        key.DeleteSubKeyTree("{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}");
                    }
                    Restart_Explorer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误：" + ex.Message);
                }
            }
        }

        private void Right_ClickMenu_Management_Button_Click(object sender, EventArgs e)
        {
            /*Right_ClickMenu_Management Right_ClickMenu_Management = new Right_ClickMenu_Management();
            Right_ClickMenu_Management.Show();
            this.Enabled = false;   
            Right_ClickMenu_Management.FormClosed += (s, ea) => { this.Enabled = true; };
            Right_ClickMenu_Management.FormClosed += (s, ea) => { Right_ClickMenu_Management.Dispose(); };*/
            MessageBox.Show("此功能正在施工中……", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Disable_Open_File_Waring_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Windows_Defender_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            /*if (Remove_Windows_Defender_CheckBox.Checked == true)
            {
                if (MessageBox.Show("关闭 Windows Defender 可能会导致某些不可预知的问题，确定吗？", "关闭 Windows Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                }
                else
                {
                    return;
                }
            }*/
        }
    }
}
