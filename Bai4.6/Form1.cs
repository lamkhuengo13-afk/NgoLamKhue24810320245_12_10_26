using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bai4._6
{    public class Student
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string AvatarPath { get; set; }
    }

    public partial class Form1 : Form
    {
        private BindingList<Student> listStudents = new BindingList<Student>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);
            btnChonAnh.Click += new EventHandler(btnChonAnh_Click);
            btnThem.Click += new EventHandler(btnThem_Click);
            btnXoa.Click += new EventHandler(btnXoa_Click);
            btnCapNhat.Click += new EventHandler(btnCapNhat_Click);
            btnXuatCSV.Click += new EventHandler(btnXuatCSV_Click);

            bindingSource.CurrentChanged += new EventHandler(bindingSource_CurrentChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = listStudents;
            dgvStudents.DataSource = bindingSource;

            if (dgvStudents.Columns["AvatarPath"] != null)
                dgvStudents.Columns["AvatarPath"].Visible = false;

            txtMaSV.DataBindings.Add("Text", bindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtHoTen.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtTuoi.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbGioiTinh.DataBindings.Add("Text", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentStudent)
            {
                if (!string.IsNullOrEmpty(currentStudent.AvatarPath) && File.Exists(currentStudent.AvatarPath))
                {
                    picAvatar.Image = Image.FromFile(currentStudent.AvatarPath);
                }
                else
                {
                    picAvatar.Image = null; 
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentStudent)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                ofd.Title = "Chọn ảnh đại diện";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentStudent.AvatarPath = ofd.FileName;
                    picAvatar.Image = Image.FromFile(ofd.FileName);
                    bindingSource.ResetCurrentItem(); // Làm mới lại dòng hiện tại
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thêm hoặc chọn một sinh viên trước khi gắn ảnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                StudentId = "SV_Mới",
                FullName = "",
                Age = 18,
                Gender = "Nam",
                AvatarPath = ""
            };

            listStudents.Add(newStudent);
            bindingSource.MoveLast();
            txtMaSV.Focus();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            dgvStudents.Refresh();
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current != null)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bindingSource.RemoveCurrent();
                    picAvatar.Image = null;
                }
            }
        }

        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            if (listStudents.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            sfd.FileName = "DanhSachSinhVien.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        sw.WriteLine("Mã SV,Họ Tên,Tuổi,Giới Tính,Đường dẫn ảnh");

                        foreach (Student sv in listStudents)
                        {
                            sw.WriteLine($"{sv.StudentId},{sv.FullName},{sv.Age},{sv.Gender},{sv.AvatarPath}");
                        }
                    }
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}