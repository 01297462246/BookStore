
namespace QuanLyNhaSach
{
    partial class ControlHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.Submenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTTAll = new System.Windows.Forms.Button();
            this.btnTTStaff = new System.Windows.Forms.Button();
            this.pnlNhanVien = new System.Windows.Forms.Panel();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTTDate = new System.Windows.Forms.Button();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTTMoney = new System.Windows.Forms.Button();
            this.pnlTien = new System.Windows.Forms.Panel();
            this.txtMucSauCung = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMucKhoiDiem = new System.Windows.Forms.TextBox();
            this.btnTTCustomer = new System.Windows.Forms.Button();
            this.pnlKhachHang = new System.Windows.Forms.Panel();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBillPaied = new System.Windows.Forms.FlowLayoutPanel();
            this.itemBill1 = new QuanLyNhaSach.ItemBill();
            this.itemBill2 = new QuanLyNhaSach.ItemBill();
            this.itemBill3 = new QuanLyNhaSach.ItemBill();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Submenu.SuspendLayout();
            this.pnlNhanVien.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlTien.SuspendLayout();
            this.pnlKhachHang.SuspendLayout();
            this.listBillPaied.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 47);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 37);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thống kê";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.Submenu);
            this.panel1.Controls.Add(this.listBillPaied);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 615);
            this.panel1.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.DarkGray;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(352, 87);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(92, 47);
            this.btnCheck.TabIndex = 19;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Submenu
            // 
            this.Submenu.AutoScroll = true;
            this.Submenu.BackColor = System.Drawing.Color.Gray;
            this.Submenu.Controls.Add(this.btnTTAll);
            this.Submenu.Controls.Add(this.btnTTStaff);
            this.Submenu.Controls.Add(this.pnlNhanVien);
            this.Submenu.Controls.Add(this.btnTTDate);
            this.Submenu.Controls.Add(this.pnlDate);
            this.Submenu.Controls.Add(this.btnTTMoney);
            this.Submenu.Controls.Add(this.pnlTien);
            this.Submenu.Controls.Add(this.btnTTCustomer);
            this.Submenu.Controls.Add(this.pnlKhachHang);
            this.Submenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Submenu.Location = new System.Drawing.Point(0, 47);
            this.Submenu.Name = "Submenu";
            this.Submenu.Size = new System.Drawing.Size(346, 568);
            this.Submenu.TabIndex = 6;
            // 
            // btnTTAll
            // 
            this.btnTTAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTTAll.FlatAppearance.BorderSize = 2;
            this.btnTTAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTAll.Location = new System.Drawing.Point(3, 3);
            this.btnTTAll.Name = "btnTTAll";
            this.btnTTAll.Padding = new System.Windows.Forms.Padding(5);
            this.btnTTAll.Size = new System.Drawing.Size(308, 55);
            this.btnTTAll.TabIndex = 26;
            this.btnTTAll.Text = "Tất cả";
            this.btnTTAll.UseVisualStyleBackColor = true;
            this.btnTTAll.Click += new System.EventHandler(this.btnTTAll_Click);
            // 
            // btnTTStaff
            // 
            this.btnTTStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTStaff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTTStaff.FlatAppearance.BorderSize = 2;
            this.btnTTStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTStaff.Location = new System.Drawing.Point(3, 64);
            this.btnTTStaff.Name = "btnTTStaff";
            this.btnTTStaff.Padding = new System.Windows.Forms.Padding(5);
            this.btnTTStaff.Size = new System.Drawing.Size(308, 55);
            this.btnTTStaff.TabIndex = 27;
            this.btnTTStaff.Text = "Thống kê theo nhân viên";
            this.btnTTStaff.UseVisualStyleBackColor = true;
            this.btnTTStaff.Click += new System.EventHandler(this.btnTTStaff_Click);
            // 
            // pnlNhanVien
            // 
            this.pnlNhanVien.Controls.Add(this.cbbMaNV);
            this.pnlNhanVien.Controls.Add(this.txtTenNV);
            this.pnlNhanVien.Controls.Add(this.label7);
            this.pnlNhanVien.Controls.Add(this.label8);
            this.pnlNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhanVien.Enabled = false;
            this.pnlNhanVien.Location = new System.Drawing.Point(3, 125);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(308, 75);
            this.pnlNhanVien.TabIndex = 28;
            this.pnlNhanVien.Visible = false;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(118, 9);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(187, 21);
            this.cbbMaNV.TabIndex = 19;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(118, 38);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(187, 20);
            this.txtTenNV.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã NV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tên NV:";
            // 
            // btnTTDate
            // 
            this.btnTTDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTDate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTTDate.FlatAppearance.BorderSize = 2;
            this.btnTTDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTDate.Location = new System.Drawing.Point(3, 206);
            this.btnTTDate.Name = "btnTTDate";
            this.btnTTDate.Padding = new System.Windows.Forms.Padding(5);
            this.btnTTDate.Size = new System.Drawing.Size(308, 55);
            this.btnTTDate.TabIndex = 36;
            this.btnTTDate.Text = "Thống kê theo ngày";
            this.btnTTDate.UseVisualStyleBackColor = true;
            this.btnTTDate.Click += new System.EventHandler(this.btnTTDate_Click);
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.dtpEnd);
            this.pnlDate.Controls.Add(this.dtpStart);
            this.pnlDate.Controls.Add(this.label1);
            this.pnlDate.Controls.Add(this.label3);
            this.pnlDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDate.Location = new System.Drawing.Point(3, 267);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(308, 79);
            this.pnlDate.TabIndex = 37;
            this.pnlDate.Visible = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(118, 39);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(187, 22);
            this.dtpEnd.TabIndex = 15;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(118, 8);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(187, 22);
            this.dtpStart.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mốc ban đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mốc sau cùng:";
            // 
            // btnTTMoney
            // 
            this.btnTTMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTMoney.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTTMoney.FlatAppearance.BorderSize = 2;
            this.btnTTMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTMoney.Location = new System.Drawing.Point(3, 352);
            this.btnTTMoney.Name = "btnTTMoney";
            this.btnTTMoney.Padding = new System.Windows.Forms.Padding(5);
            this.btnTTMoney.Size = new System.Drawing.Size(308, 55);
            this.btnTTMoney.TabIndex = 38;
            this.btnTTMoney.Text = "Thống kê theo tiền";
            this.btnTTMoney.UseVisualStyleBackColor = true;
            this.btnTTMoney.Click += new System.EventHandler(this.btnTTMoney_Click);
            // 
            // pnlTien
            // 
            this.pnlTien.Controls.Add(this.txtMucSauCung);
            this.pnlTien.Controls.Add(this.label9);
            this.pnlTien.Controls.Add(this.label10);
            this.pnlTien.Controls.Add(this.txtMucKhoiDiem);
            this.pnlTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTien.Location = new System.Drawing.Point(3, 413);
            this.pnlTien.Name = "pnlTien";
            this.pnlTien.Size = new System.Drawing.Size(308, 79);
            this.pnlTien.TabIndex = 39;
            this.pnlTien.Visible = false;
            // 
            // txtMucSauCung
            // 
            this.txtMucSauCung.Location = new System.Drawing.Point(118, 43);
            this.txtMucSauCung.Name = "txtMucSauCung";
            this.txtMucSauCung.Size = new System.Drawing.Size(187, 20);
            this.txtMucSauCung.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mức khởi điểm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Mức sau cùng:";
            // 
            // txtMucKhoiDiem
            // 
            this.txtMucKhoiDiem.Location = new System.Drawing.Point(118, 9);
            this.txtMucKhoiDiem.Name = "txtMucKhoiDiem";
            this.txtMucKhoiDiem.Size = new System.Drawing.Size(187, 20);
            this.txtMucKhoiDiem.TabIndex = 17;
            // 
            // btnTTCustomer
            // 
            this.btnTTCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTTCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTTCustomer.FlatAppearance.BorderSize = 2;
            this.btnTTCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTTCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTCustomer.Location = new System.Drawing.Point(3, 498);
            this.btnTTCustomer.Name = "btnTTCustomer";
            this.btnTTCustomer.Padding = new System.Windows.Forms.Padding(5);
            this.btnTTCustomer.Size = new System.Drawing.Size(308, 55);
            this.btnTTCustomer.TabIndex = 40;
            this.btnTTCustomer.Text = "Thống kê theo khách hàng";
            this.btnTTCustomer.UseVisualStyleBackColor = true;
            this.btnTTCustomer.Click += new System.EventHandler(this.btnTTCustomer_Click);
            // 
            // pnlKhachHang
            // 
            this.pnlKhachHang.Controls.Add(this.cbbMaKH);
            this.pnlKhachHang.Controls.Add(this.txtTenKH);
            this.pnlKhachHang.Controls.Add(this.label4);
            this.pnlKhachHang.Controls.Add(this.label5);
            this.pnlKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKhachHang.Location = new System.Drawing.Point(3, 559);
            this.pnlKhachHang.Name = "pnlKhachHang";
            this.pnlKhachHang.Size = new System.Drawing.Size(308, 75);
            this.pnlKhachHang.TabIndex = 41;
            this.pnlKhachHang.Visible = false;
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(118, 9);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(187, 21);
            this.cbbMaKH.TabIndex = 19;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(118, 38);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(187, 20);
            this.txtTenKH.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã KH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tên KH:";
            // 
            // listBillPaied
            // 
            this.listBillPaied.AutoScroll = true;
            this.listBillPaied.Controls.Add(this.itemBill1);
            this.listBillPaied.Controls.Add(this.itemBill2);
            this.listBillPaied.Controls.Add(this.itemBill3);
            this.listBillPaied.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBillPaied.Location = new System.Drawing.Point(450, 47);
            this.listBillPaied.Name = "listBillPaied";
            this.listBillPaied.Size = new System.Drawing.Size(321, 568);
            this.listBillPaied.TabIndex = 4;
            // 
            // itemBill1
            // 
            this.itemBill1.BackColor = System.Drawing.Color.White;
            this.itemBill1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemBill1.Location = new System.Drawing.Point(3, 3);
            this.itemBill1.Name = "itemBill1";
            this.itemBill1.NameBill = null;
            this.itemBill1.NameKH = null;
            this.itemBill1.NameNV = null;
            this.itemBill1.Size = new System.Drawing.Size(283, 315);
            this.itemBill1.TabIndex = 0;
            this.itemBill1.TableCTHD = null;
            this.itemBill1.Time = null;
            this.itemBill1.Tongtien = null;
            // 
            // itemBill2
            // 
            this.itemBill2.BackColor = System.Drawing.Color.White;
            this.itemBill2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemBill2.Location = new System.Drawing.Point(3, 324);
            this.itemBill2.Name = "itemBill2";
            this.itemBill2.NameBill = null;
            this.itemBill2.NameKH = null;
            this.itemBill2.NameNV = null;
            this.itemBill2.Size = new System.Drawing.Size(283, 315);
            this.itemBill2.TabIndex = 1;
            this.itemBill2.TableCTHD = null;
            this.itemBill2.Time = null;
            this.itemBill2.Tongtien = null;
            // 
            // itemBill3
            // 
            this.itemBill3.BackColor = System.Drawing.Color.White;
            this.itemBill3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemBill3.Location = new System.Drawing.Point(3, 645);
            this.itemBill3.Name = "itemBill3";
            this.itemBill3.NameBill = null;
            this.itemBill3.NameKH = null;
            this.itemBill3.NameNV = null;
            this.itemBill3.Size = new System.Drawing.Size(283, 315);
            this.itemBill3.TabIndex = 2;
            this.itemBill3.TableCTHD = null;
            this.itemBill3.Time = null;
            this.itemBill3.Tongtien = null;
            // 
            // ControlHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ControlHistory";
            this.Size = new System.Drawing.Size(771, 635);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Submenu.ResumeLayout(false);
            this.pnlNhanVien.ResumeLayout(false);
            this.pnlNhanVien.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlTien.ResumeLayout(false);
            this.pnlTien.PerformLayout();
            this.pnlKhachHang.ResumeLayout(false);
            this.pnlKhachHang.PerformLayout();
            this.listBillPaied.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel Submenu;
        private System.Windows.Forms.Button btnTTAll;
        private System.Windows.Forms.Button btnTTStaff;
        private System.Windows.Forms.Panel pnlNhanVien;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTTDate;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTTMoney;
        private System.Windows.Forms.Panel pnlTien;
        private System.Windows.Forms.TextBox txtMucSauCung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMucKhoiDiem;
        private System.Windows.Forms.Button btnTTCustomer;
        private System.Windows.Forms.FlowLayoutPanel listBillPaied;
        private System.Windows.Forms.Button btnCheck;
        private ItemBill itemBill1;
        private ItemBill itemBill2;
        private ItemBill itemBill3;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Panel pnlKhachHang;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
