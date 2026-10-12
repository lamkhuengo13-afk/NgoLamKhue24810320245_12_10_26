using System;
using System.Windows.Forms;

namespace Baithuchanh4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void qLSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is frmSinhVien)
                {
                    frm.Activate();
                    return;
                }
            }

            frmSinhVien frmMoi = new frmSinhVien();
            frmMoi.MdiParent = this;
            frmMoi.Show();
        }

        private void xếpChồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void xếpNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void xếpDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {
        }

        public void CapNhatTrangThai(string thongBao)
        {
            lblTrangThai.Text = thongBao + " lúc " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}