using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WP_2020_01_HW01_9A713031
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.Default.GetBytes(this.name.Text.Trim());  //name為輸入密碼的文字框
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            this.output.Text = BitConverter.ToString(output).Replace("-", ""); //output為輸出加密文字的文字框
        }
    }
}
