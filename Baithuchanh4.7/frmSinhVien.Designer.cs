namespace Baithuchanh4._7
{
    partial class frmSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xóaDòngToolStripMenuItem = new ToolStripMenuItem();
            làmMớiDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            xemChiTiếtToolStripMenuItem = new ToolStripMenuItem();
            btnNapDuLieu = new Button();
            prgTienTrinh = new ProgressBar();
            lblPhanTram = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { xóaDòngToolStripMenuItem, làmMớiDữLiệuToolStripMenuItem, xemChiTiếtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(187, 76);
            // 
            // xóaDòngToolStripMenuItem
            // 
            xóaDòngToolStripMenuItem.Name = "xóaDòngToolStripMenuItem";
            xóaDòngToolStripMenuItem.Size = new Size(186, 24);
            xóaDòngToolStripMenuItem.Text = "Xóa dòng";
            // 
            // làmMớiDữLiệuToolStripMenuItem
            // 
            làmMớiDữLiệuToolStripMenuItem.Name = "làmMớiDữLiệuToolStripMenuItem";
            làmMớiDữLiệuToolStripMenuItem.Size = new Size(186, 24);
            làmMớiDữLiệuToolStripMenuItem.Text = "Làm mới dữ liệu";
            // 
            // xemChiTiếtToolStripMenuItem
            // 
            xemChiTiếtToolStripMenuItem.Name = "xemChiTiếtToolStripMenuItem";
            xemChiTiếtToolStripMenuItem.Size = new Size(186, 24);
            xemChiTiếtToolStripMenuItem.Text = "Xem chi tiết";
            // 
            // btnNapDuLieu
            // 
            btnNapDuLieu.Location = new Point(12, 61);
            btnNapDuLieu.Name = "btnNapDuLieu";
            btnNapDuLieu.Size = new Size(125, 29);
            btnNapDuLieu.TabIndex = 1;
            btnNapDuLieu.Text = "Nạp dữ liệu";
            btnNapDuLieu.UseVisualStyleBackColor = true;
            btnNapDuLieu.Click += btnNapDuLieu_Click;
            // 
            // prgTienTrinh
            // 
            prgTienTrinh.Location = new Point(12, 108);
            prgTienTrinh.Name = "prgTienTrinh";
            prgTienTrinh.Size = new Size(125, 29);
            prgTienTrinh.TabIndex = 2;
            // 
            // lblPhanTram
            // 
            lblPhanTram.AutoSize = true;
            lblPhanTram.Location = new Point(143, 117);
            lblPhanTram.Name = "lblPhanTram";
            lblPhanTram.Size = new Size(29, 20);
            lblPhanTram.TabIndex = 3;
            lblPhanTram.Text = "0%";
            // 
            // frmSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(lblPhanTram);
            Controls.Add(prgTienTrinh);
            Controls.Add(btnNapDuLieu);
            Controls.Add(button1);
            Name = "frmSinhVien";
            Text = "frmSinhVien";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem xóaDòngToolStripMenuItem;
        private ToolStripMenuItem làmMớiDữLiệuToolStripMenuItem;
        private ToolStripMenuItem xemChiTiếtToolStripMenuItem;
        private Button btnNapDuLieu;
        private ProgressBar prgTienTrinh;
        private Label lblPhanTram;
    }
}