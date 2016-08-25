using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MyControls
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        public string GetMD5(string strkey)
        {
            string newkey = "";
            byte[] array = System.Text.Encoding.UTF8.GetBytes(strkey);
            MD5CryptoServiceProvider md5_provider = new MD5CryptoServiceProvider();
            array = md5_provider.ComputeHash(array);
            foreach (byte b in array)
            {
                newkey += b.ToString("X2");
            }
            return newkey;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strmk = GetMD5(txtPW.Text);

            if (User.comparePW(strmk))
            {
                MessageBox.Show("Đăng nhập thành công!");
                //Open form main
            }
            else
             {
                MessageBox.Show("Tên đăng nhập và mật khẩu không khớp!");
                txtPW.Clear();
             }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
