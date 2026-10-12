using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

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

        private async Task<List<string>> NapDuLieuAsync(IProgress<int> progress)
        {
            List<string> danhSach = new List<string>();

            await Task.Run(async () =>
            {
                for (int i = 1; i <= 100; i++)
                {
                    await Task.Delay(30);
                    if (progress != null)
                    {
                        progress.Report(i);
                    }
                }

                danhSach.Add("Nguyễn Văn A");
                danhSach.Add("Trần Thị B");
            });

            return danhSach;
        }

        private async void btnNapDuLieu_Click(object sender, EventArgs e)
        {
            btnNapDuLieu.Enabled = false;
            prgTienTrinh.Value = 0;
            lblPhanTram.Text = "0%";

            try
            {
                var progress = new Progress<int>(phanTram =>
                {
                    prgTienTrinh.Value = phanTram;
                    lblPhanTram.Text = $"{phanTram}%";

                    if (this.MdiParent is Form1 frmCha)
                    {
                        frmCha.CapNhatTrangThai($"Đang tải dữ liệu: {phanTram}%");
                    }
                });

                List<string> ketQua = await NapDuLieuAsync(progress);

                MessageBox.Show($"Đã tải xong {ketQua.Count} sinh viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (this.MdiParent is Form1 frmChaDone)
                {
                    frmChaDone.CapNhatTrangThai("Tải dữ liệu hoàn tất!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnNapDuLieu.Enabled = true;
            }
        }
    }
}