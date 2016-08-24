using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace QL_QuanAn
{
    public class CreateQRCode
    {
        public string link = "vanloi.xyz/Maban=?";
        Image codeImage;
        
        public CreateQRCode(string maban)
        {
            string linktable = link + maban;
        }
        public Image getImage()
        {
            return codeImage;
        }
    }
}
