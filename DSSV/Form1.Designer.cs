namespace DSSV
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
            lbSo = new Label();
            btnThem = new Button();
            btnKhong = new Button();
            btnGhi = new Button();
            btnHuy = new Button();
            btnSau = new Button();
            btnTruoc = new Button();
            label8 = new Label();
            dateNgay = new DateTimePicker();
            comKhoa = new ComboBox();
            txtDiem = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtHocBong = new TextBox();
            txtNoiSinh = new TextBox();
            label7 = new Label();
            label4 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtHo = new TextBox();
            checkGioiTinh = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbSo
            // 
            lbSo.AutoSize = true;
            lbSo.Location = new Point(117, 239);
            lbSo.Name = "lbSo";
            lbSo.Size = new Size(51, 19);
            lbSo.TabIndex = 49;
            lbSo.Text = "00/00";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.Maroon;
            btnThem.Location = new Point(253, 229);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 39);
            btnThem.TabIndex = 48;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnKhong
            // 
            btnKhong.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhong.ForeColor = Color.Maroon;
            btnKhong.Location = new Point(493, 229);
            btnKhong.Name = "btnKhong";
            btnKhong.Size = new Size(75, 39);
            btnKhong.TabIndex = 47;
            btnKhong.Text = "Không";
            btnKhong.UseVisualStyleBackColor = true;
            // 
            // btnGhi
            // 
            btnGhi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGhi.ForeColor = Color.Maroon;
            btnGhi.Location = new Point(413, 229);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(75, 39);
            btnGhi.TabIndex = 46;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.Maroon;
            btnHuy.Location = new Point(333, 229);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 39);
            btnHuy.TabIndex = 45;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnSau
            // 
            btnSau.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSau.ForeColor = Color.Maroon;
            btnSau.Location = new Point(173, 229);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(75, 39);
            btnSau.TabIndex = 44;
            btnSau.Text = "Sau";
            btnSau.UseVisualStyleBackColor = true;
            // 
            // btnTruoc
            // 
            btnTruoc.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTruoc.ForeColor = Color.Maroon;
            btnTruoc.Location = new Point(37, 229);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(75, 39);
            btnTruoc.TabIndex = 43;
            btnTruoc.Text = "Trước";
            btnTruoc.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Blue;
            label8.ImageAlign = ContentAlignment.TopCenter;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(598, 43);
            label8.TabIndex = 42;
            label8.Text = "DANH SÁCH SINH VIÊN";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateNgay
            // 
            dateNgay.CustomFormat = "MM/dd/yyyy";
            dateNgay.Format = DateTimePickerFormat.Custom;
            dateNgay.Location = new Point(392, 119);
            dateNgay.Name = "dateNgay";
            dateNgay.Size = new Size(180, 27);
            dateNgay.TabIndex = 41;
            // 
            // comKhoa
            // 
            comKhoa.FormattingEnabled = true;
            comKhoa.Location = new Point(392, 155);
            comKhoa.Name = "comKhoa";
            comKhoa.Size = new Size(180, 27);
            comKhoa.TabIndex = 40;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(392, 186);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(180, 27);
            txtDiem.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 195);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 36;
            label3.Text = "Tổng điểm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(290, 128);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 37;
            label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 164);
            label5.Name = "label5";
            label5.Size = new Size(44, 19);
            label5.TabIndex = 38;
            label5.Text = "Khoa";
            // 
            // txtHocBong
            // 
            txtHocBong.Location = new Point(129, 189);
            txtHocBong.Name = "txtHocBong";
            txtHocBong.Size = new Size(124, 27);
            txtHocBong.TabIndex = 34;
            // 
            // txtNoiSinh
            // 
            txtNoiSinh.Location = new Point(129, 156);
            txtNoiSinh.Name = "txtNoiSinh";
            txtNoiSinh.Size = new Size(124, 27);
            txtNoiSinh.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 197);
            label7.Name = "label7";
            label7.Size = new Size(77, 19);
            label7.TabIndex = 32;
            label7.Text = "Học bổng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 164);
            label4.Name = "label4";
            label4.Size = new Size(69, 19);
            label4.TabIndex = 33;
            label4.Text = "Nơi Sinh";
            // 
            // txtMa
            // 
            txtMa.Location = new Point(129, 55);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(443, 27);
            txtMa.TabIndex = 29;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(440, 86);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(132, 27);
            txtTen.TabIndex = 30;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(129, 86);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(297, 27);
            txtHo.TabIndex = 31;
            // 
            // checkGioiTinh
            // 
            checkGioiTinh.CheckAlign = ContentAlignment.MiddleRight;
            checkGioiTinh.Location = new Point(32, 127);
            checkGioiTinh.Name = "checkGioiTinh";
            checkGioiTinh.Size = new Size(111, 23);
            checkGioiTinh.TabIndex = 28;
            checkGioiTinh.Text = "Giới tính";
            checkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 94);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 26;
            label2.Text = "Họ tên SV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 63);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 27;
            label1.Text = "Mã SV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 295);
            Controls.Add(lbSo);
            Controls.Add(btnThem);
            Controls.Add(btnKhong);
            Controls.Add(btnGhi);
            Controls.Add(btnHuy);
            Controls.Add(btnSau);
            Controls.Add(btnTruoc);
            Controls.Add(label8);
            Controls.Add(dateNgay);
            Controls.Add(comKhoa);
            Controls.Add(txtDiem);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHocBong);
            Controls.Add(txtNoiSinh);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(txtMa);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(checkGioiTinh);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "DSSV Access";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSo;
        private Button btnThem;
        private Button btnKhong;
        private Button btnGhi;
        private Button btnHuy;
        private Button btnSau;
        private Button btnTruoc;
        private Label label8;
        private DateTimePicker dateNgay;
        private ComboBox comKhoa;
        private TextBox txtDiem;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtHocBong;
        private TextBox txtNoiSinh;
        private Label label7;
        private Label label4;
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtHo;
        private CheckBox checkGioiTinh;
        private Label label2;
        private Label label1;
    }
}
