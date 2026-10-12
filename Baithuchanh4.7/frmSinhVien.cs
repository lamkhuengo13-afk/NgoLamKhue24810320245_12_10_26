using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Baithuchanh4._7
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is Form1 frmCha)
            {
                frmCha.CapNhatTrangThai("Sinh viên vừa có thao tác mới!");
            }
        }
    }
}
