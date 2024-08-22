namespace PL.DAM
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
            dgv_sanpham = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_ten = new TextBox();
            txt_nhasanxuat = new TextBox();
            txt_xuatxu = new TextBox();
            txt_mota = new TextBox();
            cb_gia = new ComboBox();
            cb_soluongton = new ComboBox();
            cb_trangthai = new ComboBox();
            cb_loaisanpham = new ComboBox();
            txt_timkiem = new TextBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).BeginInit();
            SuspendLayout();
            // 
            // dgv_sanpham
            // 
            dgv_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sanpham.Location = new Point(12, 348);
            dgv_sanpham.Name = "dgv_sanpham";
            dgv_sanpham.Size = new Size(1153, 285);
            dgv_sanpham.TabIndex = 0;
            dgv_sanpham.CellClick += dgv_sanpham_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 228);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Loại Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 267);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Mô Tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 192);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Trạng Thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 159);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Xuất Xứ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 122);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 5;
            label5.Text = "Nhà Sản Xuất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 77);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 6;
            label6.Text = "Số Lượng Tồn";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 44);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 7;
            label7.Text = "Giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 11);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 8;
            label8.Text = "Tên";
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(102, 8);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(331, 23);
            txt_ten.TabIndex = 9;
            // 
            // txt_nhasanxuat
            // 
            txt_nhasanxuat.Location = new Point(102, 114);
            txt_nhasanxuat.Name = "txt_nhasanxuat";
            txt_nhasanxuat.Size = new Size(331, 23);
            txt_nhasanxuat.TabIndex = 10;
            // 
            // txt_xuatxu
            // 
            txt_xuatxu.Location = new Point(102, 156);
            txt_xuatxu.Name = "txt_xuatxu";
            txt_xuatxu.Size = new Size(331, 23);
            txt_xuatxu.TabIndex = 11;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(102, 259);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(331, 23);
            txt_mota.TabIndex = 12;
            // 
            // cb_gia
            // 
            cb_gia.FormattingEnabled = true;
            cb_gia.Location = new Point(102, 41);
            cb_gia.Name = "cb_gia";
            cb_gia.Size = new Size(331, 23);
            cb_gia.TabIndex = 13;
            // 
            // cb_soluongton
            // 
            cb_soluongton.FormattingEnabled = true;
            cb_soluongton.Location = new Point(102, 74);
            cb_soluongton.Name = "cb_soluongton";
            cb_soluongton.Size = new Size(331, 23);
            cb_soluongton.TabIndex = 14;
            // 
            // cb_trangthai
            // 
            cb_trangthai.FormattingEnabled = true;
            cb_trangthai.Location = new Point(102, 189);
            cb_trangthai.Name = "cb_trangthai";
            cb_trangthai.Size = new Size(331, 23);
            cb_trangthai.TabIndex = 15;
            // 
            // cb_loaisanpham
            // 
            cb_loaisanpham.FormattingEnabled = true;
            cb_loaisanpham.Location = new Point(102, 225);
            cb_loaisanpham.Name = "cb_loaisanpham";
            cb_loaisanpham.Size = new Size(331, 23);
            cb_loaisanpham.TabIndex = 16;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(12, 319);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(422, 23);
            txt_timkiem.TabIndex = 17;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(679, 25);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(203, 53);
            btn_them.TabIndex = 18;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(679, 98);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(203, 53);
            btn_sua.TabIndex = 19;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(679, 173);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(203, 53);
            btn_xoa.TabIndex = 20;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(679, 248);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(203, 53);
            btn_clear.TabIndex = 21;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 645);
            Controls.Add(btn_clear);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(txt_timkiem);
            Controls.Add(cb_loaisanpham);
            Controls.Add(cb_trangthai);
            Controls.Add(cb_soluongton);
            Controls.Add(cb_gia);
            Controls.Add(txt_mota);
            Controls.Add(txt_xuatxu);
            Controls.Add(txt_nhasanxuat);
            Controls.Add(txt_ten);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_sanpham);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_sanpham;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_ten;
        private TextBox txt_nhasanxuat;
        private TextBox txt_xuatxu;
        private TextBox txt_mota;
        private ComboBox cb_gia;
        private ComboBox cb_soluongton;
        private ComboBox cb_trangthai;
        private ComboBox cb_loaisanpham;
        private TextBox txt_timkiem;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_clear;
    }
}
