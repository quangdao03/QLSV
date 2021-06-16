
namespace UTTquanlisv
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gIANG_VIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uTTquanlisvDataSet = new UTTquanlisv.UTTquanlisvDataSet();
            this.groupBoxph = new System.Windows.Forms.GroupBox();
            this.giangvien = new System.Windows.Forms.ListBox();
            this.txtphanloai = new System.Windows.Forms.ListBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.listBoxgioitinh = new System.Windows.Forms.ListBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gIANG_VIENTableAdapter = new UTTquanlisv.UTTquanlisvDataSetTableAdapters.GIANG_VIENTableAdapter();
            this.tableAdapterManager = new UTTquanlisv.UTTquanlisvDataSetTableAdapters.TableAdapterManager();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).BeginInit();
            this.groupBoxph.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(622, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 39);
            this.button4.TabIndex = 20;
            this.button4.Text = "Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(418, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 39);
            this.button3.TabIndex = 19;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(216, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(25, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(407, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 419);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 279);
            this.dataGridView1.TabIndex = 21;
            // 
            // gIANG_VIENBindingSource
            // 
            this.gIANG_VIENBindingSource.DataMember = "GIANG_VIEN";
            this.gIANG_VIENBindingSource.DataSource = this.uTTquanlisvDataSet;
            // 
            // uTTquanlisvDataSet
            // 
            this.uTTquanlisvDataSet.DataSetName = "UTTquanlisvDataSet";
            this.uTTquanlisvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxph
            // 
            this.groupBoxph.Controls.Add(this.giangvien);
            this.groupBoxph.Controls.Add(this.txtphanloai);
            this.groupBoxph.Controls.Add(this.txtemail);
            this.groupBoxph.Controls.Add(this.txtdienthoai);
            this.groupBoxph.Controls.Add(this.listBoxgioitinh);
            this.groupBoxph.Controls.Add(this.txthoten);
            this.groupBoxph.Controls.Add(this.label7);
            this.groupBoxph.Controls.Add(this.label6);
            this.groupBoxph.Controls.Add(this.label5);
            this.groupBoxph.Controls.Add(this.label4);
            this.groupBoxph.Controls.Add(this.label3);
            this.groupBoxph.Controls.Add(this.label2);
            this.groupBoxph.Location = new System.Drawing.Point(12, 120);
            this.groupBoxph.Name = "groupBoxph";
            this.groupBoxph.Size = new System.Drawing.Size(333, 419);
            this.groupBoxph.TabIndex = 15;
            this.groupBoxph.TabStop = false;
            this.groupBoxph.Text = "thông tin chi tiết";
            // 
            // giangvien
            // 
            this.giangvien.FormattingEnabled = true;
            this.giangvien.ItemHeight = 16;
            this.giangvien.Items.AddRange(new object[] {
            "...",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.giangvien.Location = new System.Drawing.Point(127, 50);
            this.giangvien.Name = "giangvien";
            this.giangvien.Size = new System.Drawing.Size(156, 20);
            this.giangvien.TabIndex = 33;
            // 
            // txtphanloai
            // 
            this.txtphanloai.FormattingEnabled = true;
            this.txtphanloai.ItemHeight = 16;
            this.txtphanloai.Items.AddRange(new object[] {
            "...",
            "Trung Bình",
            "Khá",
            "Tốt"});
            this.txtphanloai.Location = new System.Drawing.Point(126, 384);
            this.txtphanloai.Name = "txtphanloai";
            this.txtphanloai.Size = new System.Drawing.Size(157, 20);
            this.txtphanloai.TabIndex = 32;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(126, 317);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(157, 22);
            this.txtemail.TabIndex = 31;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(126, 244);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(157, 22);
            this.txtdienthoai.TabIndex = 30;
            // 
            // listBoxgioitinh
            // 
            this.listBoxgioitinh.FormattingEnabled = true;
            this.listBoxgioitinh.ItemHeight = 16;
            this.listBoxgioitinh.Items.AddRange(new object[] {
            "...",
            "Nam",
            "Nữ"});
            this.listBoxgioitinh.Location = new System.Drawing.Point(126, 181);
            this.listBoxgioitinh.Name = "listBoxgioitinh";
            this.listBoxgioitinh.Size = new System.Drawing.Size(157, 20);
            this.listBoxgioitinh.TabIndex = 29;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(126, 111);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(157, 22);
            this.txthoten.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Đánh giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã giảng viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(630, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "DANH SÁCH GIẢNG VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gIANG_VIENTableAdapter
            // 
            this.gIANG_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GIANG_VIENTableAdapter = this.gIANG_VIENTableAdapter;
            this.tableAdapterManager.KET_QUA2TableAdapter = null;
            this.tableAdapterManager.KET_QUA3TableAdapter = null;
            this.tableAdapterManager.KET_QUATableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONTableAdapter = null;
            this.tableAdapterManager.SINH_VIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UTTquanlisv.UTTquanlisvDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxph);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Giảng Viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).EndInit();
            this.groupBoxph.ResumeLayout(false);
            this.groupBoxph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxph;
        private System.Windows.Forms.ListBox txtphanloai;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.ListBox listBoxgioitinh;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private UTTquanlisvDataSet uTTquanlisvDataSet;
        private System.Windows.Forms.BindingSource gIANG_VIENBindingSource;
        private UTTquanlisvDataSetTableAdapters.GIANG_VIENTableAdapter gIANG_VIENTableAdapter;
        private UTTquanlisvDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox giangvien;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}