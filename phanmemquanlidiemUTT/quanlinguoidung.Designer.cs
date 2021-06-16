
namespace phanmemquanlidiemUTT
{
    partial class quanlinguoidung
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlinguoidung));
            System.Windows.Forms.Label quyenLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label gioiTinhLabel1;
            System.Windows.Forms.Label tenTaiKhoanLabel;
            System.Windows.Forms.Label matKhauLabel;
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.quyenComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLammoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.txtNhaplaimatkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.tenTaiKhoanTextBox = new System.Windows.Forms.TextBox();
            this.matKhauTextBox = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btXoa = new System.Windows.Forms.Button();
            this.uTTquanlisvDataSet = new phanmemquanlidiemUTT.UTTquanlisvDataSet();
            this.lOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOGINTableAdapter = new phanmemquanlidiemUTT.UTTquanlisvDataSetTableAdapters.LOGINTableAdapter();
            this.tableAdapterManager = new phanmemquanlidiemUTT.UTTquanlisvDataSetTableAdapters.TableAdapterManager();
            this.lOGINDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            quyenLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            gioiTinhLabel1 = new System.Windows.Forms.Label();
            tenTaiKhoanLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // quyenComboBox
            // 
            this.quyenComboBox.FormattingEnabled = true;
            this.quyenComboBox.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.quyenComboBox.Location = new System.Drawing.Point(372, 150);
            this.quyenComboBox.Name = "quyenComboBox";
            this.quyenComboBox.Size = new System.Drawing.Size(143, 21);
            this.quyenComboBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lOGINDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(70, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 265);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(346, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "QUẢN LÍ NGƯỜI DÙNG ";
            // 
            // btLammoi
            // 
            this.btLammoi.Image = ((System.Drawing.Image)(resources.GetObject("btLammoi.Image")));
            this.btLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLammoi.Location = new System.Drawing.Point(880, 375);
            this.btLammoi.Name = "btLammoi";
            this.btLammoi.Size = new System.Drawing.Size(89, 41);
            this.btLammoi.TabIndex = 32;
            this.btLammoi.Text = "Làm mới ";
            this.btLammoi.UseVisualStyleBackColor = true;
            this.btLammoi.Click += new System.EventHandler(this.btLammoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(quyenLabel);
            this.groupBox1.Controls.Add(this.quyenComboBox);
            this.groupBox1.Controls.Add(this.hoTenTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.dienThoaiTextBox);
            this.groupBox1.Controls.Add(dienThoaiLabel);
            this.groupBox1.Controls.Add(this.txtNhaplaimatkhau);
            this.groupBox1.Controls.Add(hoTenLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gioiTinhComboBox);
            this.groupBox1.Controls.Add(gioiTinhLabel1);
            this.groupBox1.Controls.Add(tenTaiKhoanLabel);
            this.groupBox1.Controls.Add(this.tenTaiKhoanTextBox);
            this.groupBox1.Controls.Add(this.matKhauTextBox);
            this.groupBox1.Controls.Add(matKhauLabel);
            this.groupBox1.Location = new System.Drawing.Point(149, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 195);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết ";
            // 
            // quyenLabel
            // 
            quyenLabel.AutoSize = true;
            quyenLabel.Location = new System.Drawing.Point(270, 153);
            quyenLabel.Name = "quyenLabel";
            quyenLabel.Size = new System.Drawing.Size(38, 13);
            quyenLabel.TabIndex = 16;
            quyenLabel.Text = "Quyền";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.Location = new System.Drawing.Point(108, 47);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(121, 20);
            this.hoTenTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(108, 150);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(21, 153);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // dienThoaiTextBox
            // 
            this.dienThoaiTextBox.Location = new System.Drawing.Point(108, 114);
            this.dienThoaiTextBox.Name = "dienThoaiTextBox";
            this.dienThoaiTextBox.Size = new System.Drawing.Size(121, 20);
            this.dienThoaiTextBox.TabIndex = 10;
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.Location = new System.Drawing.Point(21, 117);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(58, 13);
            dienThoaiLabel.TabIndex = 9;
            dienThoaiLabel.Text = "Điện thoại:";
            // 
            // txtNhaplaimatkhau
            // 
            this.txtNhaplaimatkhau.Location = new System.Drawing.Point(372, 114);
            this.txtNhaplaimatkhau.Name = "txtNhaplaimatkhau";
            this.txtNhaplaimatkhau.Size = new System.Drawing.Size(143, 20);
            this.txtNhaplaimatkhau.TabIndex = 16;
            this.txtNhaplaimatkhau.UseSystemPasswordChar = true;
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(21, 50);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(42, 13);
            hoTenLabel.TabIndex = 5;
            hoTenLabel.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhập lại mật khẩu:";
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(108, 84);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(64, 21);
            this.gioiTinhComboBox.TabIndex = 14;
            // 
            // gioiTinhLabel1
            // 
            gioiTinhLabel1.AutoSize = true;
            gioiTinhLabel1.Location = new System.Drawing.Point(21, 91);
            gioiTinhLabel1.Name = "gioiTinhLabel1";
            gioiTinhLabel1.Size = new System.Drawing.Size(50, 13);
            gioiTinhLabel1.TabIndex = 13;
            gioiTinhLabel1.Text = "Giới tính:";
            // 
            // tenTaiKhoanLabel
            // 
            tenTaiKhoanLabel.AutoSize = true;
            tenTaiKhoanLabel.Location = new System.Drawing.Point(270, 50);
            tenTaiKhoanLabel.Name = "tenTaiKhoanLabel";
            tenTaiKhoanLabel.Size = new System.Drawing.Size(76, 13);
            tenTaiKhoanLabel.TabIndex = 1;
            tenTaiKhoanLabel.Text = "Tên tài khoản:";
            // 
            // tenTaiKhoanTextBox
            // 
            this.tenTaiKhoanTextBox.Location = new System.Drawing.Point(372, 47);
            this.tenTaiKhoanTextBox.Name = "tenTaiKhoanTextBox";
            this.tenTaiKhoanTextBox.Size = new System.Drawing.Size(143, 20);
            this.tenTaiKhoanTextBox.TabIndex = 2;
            // 
            // matKhauTextBox
            // 
            this.matKhauTextBox.Location = new System.Drawing.Point(372, 84);
            this.matKhauTextBox.Name = "matKhauTextBox";
            this.matKhauTextBox.Size = new System.Drawing.Size(143, 20);
            this.matKhauTextBox.TabIndex = 4;
            this.matKhauTextBox.UseSystemPasswordChar = true;
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(270, 87);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(55, 13);
            matKhauLabel.TabIndex = 3;
            matKhauLabel.Text = "Mật khẩu:";
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(880, 445);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(89, 37);
            this.btThoat.TabIndex = 28;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(880, 235);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(89, 41);
            this.btSua.TabIndex = 26;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(880, 164);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(89, 41);
            this.btThem.TabIndex = 25;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(880, 302);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(89, 38);
            this.btXoa.TabIndex = 27;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // uTTquanlisvDataSet
            // 
            this.uTTquanlisvDataSet.DataSetName = "UTTquanlisvDataSet";
            this.uTTquanlisvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOGINBindingSource
            // 
            this.lOGINBindingSource.DataMember = "LOGIN";
            this.lOGINBindingSource.DataSource = this.uTTquanlisvDataSet;
            // 
            // lOGINTableAdapter
            // 
            this.lOGINTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANG_VIENTableAdapter = null;
            this.tableAdapterManager.KET_QUA2TableAdapter = null;
            this.tableAdapterManager.KET_QUA3TableAdapter = null;
            this.tableAdapterManager.KET_QUATableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOGINTableAdapter = this.lOGINTableAdapter;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = phanmemquanlidiemUTT.UTTquanlisvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOGINDataGridView
            // 
            this.lOGINDataGridView.AutoGenerateColumns = false;
            this.lOGINDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOGINDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.lOGINDataGridView.DataSource = this.lOGINBindingSource;
            this.lOGINDataGridView.Location = new System.Drawing.Point(8, 19);
            this.lOGINDataGridView.Name = "lOGINDataGridView";
            this.lOGINDataGridView.Size = new System.Drawing.Size(746, 220);
            this.lOGINDataGridView.TabIndex = 0;
            this.lOGINDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lOGINDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TenDN";
            this.dataGridViewTextBoxColumn1.HeaderText = "TenDN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "HoTen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GioiTinh";
            this.dataGridViewTextBoxColumn4.HeaderText = "GioiTinh";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DienThoai";
            this.dataGridViewTextBoxColumn5.HeaderText = "DienThoai";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Quyen";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quyen";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // quanlinguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btLammoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Name = "quanlinguoidung";
            this.Text = "quanlinguoidung";
            this.Load += new System.EventHandler(this.quanlinguoidung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGINDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLammoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox quyenComboBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox dienThoaiTextBox;
        private System.Windows.Forms.TextBox txtNhaplaimatkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gioiTinhComboBox;
        private System.Windows.Forms.TextBox tenTaiKhoanTextBox;
        private System.Windows.Forms.TextBox matKhauTextBox;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private UTTquanlisvDataSet uTTquanlisvDataSet;
        private System.Windows.Forms.BindingSource lOGINBindingSource;
        private UTTquanlisvDataSetTableAdapters.LOGINTableAdapter lOGINTableAdapter;
        private UTTquanlisvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lOGINDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}