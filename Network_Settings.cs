using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Linq;
using System.Diagnostics;


namespace Windows_Tools
{
    public partial class Network_Settings : Form
    {
        private NetworkInterface[] _networkInterfaces;

        public Network_Settings()
        {
            InitializeComponent();
            _networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            foreach (NetworkInterface nic in _networkInterfaces)
            {
                // 排除环回地址
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    Select_NIC_ComboBox.Items.Add(nic.Name);
                }
            }
            if (Select_NIC_ComboBox.Items.Count > 0)
            {
                Select_NIC_ComboBox.SelectedIndex = 0;
            }
        }      

        private void Select_NIC_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNICName = Select_NIC_ComboBox.Text;
            foreach (NetworkInterface nic in _networkInterfaces)
            {
                if (nic.Name == selectedNICName)
                {
                    var macAddress = nic.GetPhysicalAddress();
                    MAC_Add_TextBox.Text = macAddress.ToString();
                    break;
                }               
            }
        }


        private void MAC_Add_TextBox_TextChanged(object sender, EventArgs e)
        {
            MAC_Add_TextBox.TextChanged -= MAC_Add_TextBox_TextChanged;
            try
            {
                string input = MAC_Add_TextBox.Text;
                if (input.Length > 17)
                {
                    input = input.Substring(0, 17);
                }
                input = input.ToUpper();
                input = new string(input.Where(c => char.IsDigit(c) || "ABCDEF".Contains(c)).ToArray());
                var formattedInput = "";
                for (int i = 0; i < input.Length; i++)
                {
                    formattedInput += input[i];
                    if ((i + 1) % 2 == 0 && i + 1 != input.Length)
                    {
                        formattedInput += " ";
                    }
                }
                MAC_Add_TextBox.Text = formattedInput;
                MAC_Add_TextBox.SelectionStart = MAC_Add_TextBox.Text.Length;
            }
            finally
            {
                MAC_Add_TextBox.TextChanged += MAC_Add_TextBox_TextChanged;
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能正在施工中……", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
