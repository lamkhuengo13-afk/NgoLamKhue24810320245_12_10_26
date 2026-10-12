namespace Baithuchanh4._7
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
            menuStrip1 = new MenuStrip();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            qLSinhViênToolStripMenuItem = new ToolStripMenuItem();
            cửaSổToolStripMenuItem = new ToolStripMenuItem();
            xếpChồngToolStripMenuItem = new ToolStripMenuItem();
            xếpNgangToolStripMenuItem = new ToolStripMenuItem();
            xếpDọcToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { danhMụcToolStripMenuItem, cửaSổToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { qLSinhViênToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // qLSinhViênToolStripMenuItem
            // 
            qLSinhViênToolStripMenuItem.Name = "qLSinhViênToolStripMenuItem";
            qLSinhViênToolStripMenuItem.Size = new Size(173, 26);
            qLSinhViênToolStripMenuItem.Text = "QL Sinh viên";
            qLSinhViênToolStripMenuItem.Click += qLSinhViênToolStripMenuItem_Click;
            // 
            // cửaSổToolStripMenuItem
            // 
            cửaSổToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xếpChồngToolStripMenuItem, xếpNgangToolStripMenuItem, xếpDọcToolStripMenuItem });
            cửaSổToolStripMenuItem.Name = "cửaSổToolStripMenuItem";
            cửaSổToolStripMenuItem.Size = new Size(68, 24);
            cửaSổToolStripMenuItem.Text = "Cửa sổ";
            // 
            // xếpChồngToolStripMenuItem
            // 
            xếpChồngToolStripMenuItem.Name = "xếpChồngToolStripMenuItem";
            xếpChồngToolStripMenuItem.Size = new Size(224, 26);
            xếpChồngToolStripMenuItem.Text = "Xếp chồng ";
            xếpChồngToolStripMenuItem.Click += xếpChồngToolStripMenuItem_Click;
            // 
            // xếpNgangToolStripMenuItem
            // 
            xếpNgangToolStripMenuItem.Name = "xếpNgangToolStripMenuItem";
            xếpNgangToolStripMenuItem.Size = new Size(224, 26);
            xếpNgangToolStripMenuItem.Text = "Xếp ngang";
            xếpNgangToolStripMenuItem.Click += xếpNgangToolStripMenuItem_Click;
            // 
            // xếpDọcToolStripMenuItem
            // 
            xếpDọcToolStripMenuItem.Name = "xếpDọcToolStripMenuItem";
            xếpDọcToolStripMenuItem.Size = new Size(224, 26);
            xếpDọcToolStripMenuItem.Text = "Xếp dọc";
            xếpDọcToolStripMenuItem.Click += xếpDọcToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(151, 20);
            lblTrangThai.Text = "toolStripStatusLabel1";
            lblTrangThai.Click += lblTrangThai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem qLSinhViênToolStripMenuItem;
        private ToolStripMenuItem cửaSổToolStripMenuItem;
        private ToolStripMenuItem xếpChồngToolStripMenuItem;
        private ToolStripMenuItem xếpNgangToolStripMenuItem;
        private ToolStripMenuItem xếpDọcToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
    }
}
