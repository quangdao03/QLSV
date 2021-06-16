
namespace phanmemquanlidiemUTT
{
    partial class QL_GiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QL_GiangVien));
            this.label1 = new System.Windows.Forms.Label();
            this.txtphanloai = new System.Windows.Forms.ListBox();
            this.groupBoxph = new System.Windows.Forms.GroupBox();
            this.maGVTextBox = new System.Windows.Forms.TextBox();
            this.gIANG_VIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uTTquanlisvDataSet = new phanmemquanlidiemUTT.UTTquanlisvDataSet();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gIANG_VIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIANG_VIENTableAdapter = new phanmemquanlidiemUTT.UTTquanlisvDataSetTableAdapters.GIANG_VIENTableAdapter();
            this.groupBoxph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(477, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "DANH SÁCH GIẢNG VIÊN";
            // 
            // txtphanloai
            // 
            this.txtphanloai.FormattingEnabled = true;
            this.txtphanloai.Items.AddRange(new object[] {
            "...",
            "Trung Bình",
            "Khá",
            "Tốt"});
            this.txtphanloai.Location = new System.Drawing.Point(94, 312);
            this.txtphanloai.Margin = new System.Windows.Forms.Padding(2);
            this.txtphanloai.Name = "txtphanloai";
            this.txtphanloai.Size = new System.Drawing.Size(119, 17);
            this.txtphanloai.TabIndex = 32;
            // 
            // groupBoxph
            // 
            this.groupBoxph.Controls.Add(this.maGVTextBox);
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
            this.groupBoxph.Location = new System.Drawing.Point(14, 130);
            this.groupBoxph.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxph.Name = "groupBoxph";
            this.groupBoxph.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxph.Size = new System.Drawing.Size(250, 340);
            this.groupBoxph.TabIndex = 18;
            this.groupBoxph.TabStop = false;
            this.groupBoxph.Text = "thông tin chi tiết";
            // 
            // maGVTextBox
            // 
            this.maGVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIANG_VIENBindingSource1, "MaGV", true));
            this.maGVTextBox.Location = new System.Drawing.Point(94, 41);
            this.maGVTextBox.Name = "maGVTextBox";
            this.maGVTextBox.Size = new System.Drawing.Size(119, 20);
            this.maGVTextBox.TabIndex = 20;
            this.maGVTextBox.TextChanged += new System.EventHandler(this.maGVTextBox_TextChanged_1);
            // 
            // gIANG_VIENBindingSource1
            // 
            this.gIANG_VIENBindingSource1.DataMember = "GIANG_VIEN";
            this.gIANG_VIENBindingSource1.DataSource = this.uTTquanlisvDataSet;
            // 
            // uTTquanlisvDataSet
            // 
            this.uTTquanlisvDataSet.DataSetName = "UTTquanlisvDataSet";
            this.uTTquanlisvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(94, 258);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(119, 20);
            this.txtemail.TabIndex = 31;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(94, 198);
            this.txtdienthoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(119, 20);
            this.txtdienthoai.TabIndex = 30;
            // 
            // listBoxgioitinh
            // 
            this.listBoxgioitinh.FormattingEnabled = true;
            this.listBoxgioitinh.Items.AddRange(new object[] {
            "...",
            "Nam",
            "Nữ"});
            this.listBoxgioitinh.Location = new System.Drawing.Point(94, 147);
            this.listBoxgioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxgioitinh.Name = "listBoxgioitinh";
            this.listBoxgioitinh.Size = new System.Drawing.Size(119, 17);
            this.listBoxgioitinh.TabIndex = 29;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(94, 90);
            this.txthoten.Margin = new System.Windows.Forms.Padding(2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(119, 20);
            this.txthoten.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Đánh giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã giảng viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 227);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(310, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(741, 340);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "danh sách";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(466, 285);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 32);
            this.button4.TabIndex = 20;
            this.button4.Text = "Thoát ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(314, 285);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 19;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(19, 285);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(162, 285);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gIANG_VIENBindingSource
            // 
            this.gIANG_VIENBindingSource.DataMember = "GIANG_VIEN";
            // 
            // gIANG_VIENTableAdapter
            // 
            this.gIANG_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // QL_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxph);
            this.Controls.Add(this.groupBox2);
            this.Name = "QL_GiangVien";
            this.Text = "QL_GiangVien";
            this.Load += new System.EventHandler(this.QL_GiangVien_Load);
            this.groupBoxph.ResumeLayout(false);
            this.groupBoxph.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIANG_VIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox txtphanloai;
        private System.Windows.Forms.GroupBox groupBoxph;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource gIANG_VIENBindingSource;
        private UTTquanlisvDataSet uTTquanlisvDataSet;
        private System.Windows.Forms.BindingSource gIANG_VIENBindingSource1;
        private UTTquanlisvDataSetTableAdapters.GIANG_VIENTableAdapter gIANG_VIENTableAdapter;
        private System.Windows.Forms.TextBox maGVTextBox;
    }
}