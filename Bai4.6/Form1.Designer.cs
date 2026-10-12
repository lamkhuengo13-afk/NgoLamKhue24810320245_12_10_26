namespace Bai4._6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaSV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtHoTen = new TextBox();
            txtTuoi = new TextBox();
            cmbGioiTinh = new ComboBox();
            picAvatar = new PictureBox();
            btnChonAnh = new Button();
            btnThem = new Button();
            btnCapNhat = new Button();
            btnXoa = new Button();
            btnXuatCSV = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(331, 30);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(162, 27);
            txtMaSV.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 37);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 75);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 115);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Tuổi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 156);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 4;
            label4.Text = "Giới tính:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(331, 68);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(162, 27);
            txtHoTen.TabIndex = 5;
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(331, 108);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(45, 27);
            txtTuoi.TabIndex = 6;
            // 
            // cmbGioiTinh
            // 
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioiTinh.FormattingEnabled = true;
            cmbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGioiTinh.Location = new Point(331, 148);
            cmbGioiTinh.Name = "cmbGioiTinh";
            cmbGioiTinh.Size = new Size(125, 28);
            cmbGioiTinh.TabIndex = 7;
            // 
            // picAvatar
            // 
            picAvatar.Location = new Point(40, 12);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(173, 188);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(40, 227);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(94, 29);
            btnChonAnh.TabIndex = 9;
            btnChonAnh.Text = "Chọn ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(140, 227);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(240, 227);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 11;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(92, 262);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnXuatCSV
            // 
            btnXuatCSV.Location = new Point(192, 262);
            btnXuatCSV.Name = "btnXuatCSV";
            btnXuatCSV.Size = new Size(94, 29);
            btnXuatCSV.TabIndex = 13;
            btnXuatCSV.Text = "Xuất CSV";
            btnXuatCSV.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(371, 227);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(403, 191);
            dgvStudents.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(btnXuatCSV);
            Controls.Add(btnXoa);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(btnChonAnh);
            Controls.Add(picAvatar);
            Controls.Add(cmbGioiTinh);
            Controls.Add(txtTuoi);
            Controls.Add(txtHoTen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaSV);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSV;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtHoTen;
        private TextBox txtTuoi;
        private ComboBox cmbGioiTinh;
        private PictureBox picAvatar;
        private Button btnChonAnh;
        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Button btnXuatCSV;
        private DataGridView dgvStudents;
    }
}
