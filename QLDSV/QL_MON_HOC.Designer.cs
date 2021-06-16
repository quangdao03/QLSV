
namespace QLDSV
{
    partial class QL_MON_HOC
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmakhoa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txthocky = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDVHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmamon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mONTableAdapter = new QLDSV.QLDiemsvDataSetTableAdapters.MONTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLDiemsvDataSet = new QLDSV.QLDiemsvDataSet();
            this.mONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDVHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemsvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(244, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(484, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmakhoa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txthocky);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmagv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDVHT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttenmon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmamon);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 436);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cbmakhoa
            // 
            this.cbmakhoa.FormattingEnabled = true;
            this.cbmakhoa.Location = new System.Drawing.Point(112, 363);
            this.cbmakhoa.Name = "cbmakhoa";
            this.cbmakhoa.Size = new System.Drawing.Size(232, 24);
            this.cbmakhoa.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã Khoa";
            // 
            // txthocky
            // 
            this.txthocky.Location = new System.Drawing.Point(112, 298);
            this.txthocky.Name = "txthocky";
            this.txthocky.Size = new System.Drawing.Size(232, 22);
            this.txthocky.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Học Kỳ";
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(112, 236);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(232, 22);
            this.txtmagv.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã GV";
            // 
            // txtDVHT
            // 
            this.txtDVHT.Location = new System.Drawing.Point(112, 177);
            this.txtDVHT.Name = "txtDVHT";
            this.txtDVHT.Size = new System.Drawing.Size(232, 22);
            this.txtDVHT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số DVHT";
            // 
            // txttenmon
            // 
            this.txttenmon.Location = new System.Drawing.Point(112, 116);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(232, 22);
            this.txttenmon.TabIndex = 5;
            this.txttenmon.TextChanged += new System.EventHandler(this.txttenkhoa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Môn";
            // 
            // txtmamon
            // 
            this.txtmamon.Location = new System.Drawing.Point(112, 67);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(232, 22);
            this.txtmamon.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(393, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 436);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(814, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 50);
            this.button4.TabIndex = 10;
            this.button4.Text = "Thoat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(814, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 50);
            this.button3.TabIndex = 9;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(814, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn,
            this.tenMonDataGridViewTextBoxColumn,
            this.soDVHTDataGridViewTextBoxColumn,
            this.maGVDataGridViewTextBoxColumn,
            this.hocKiDataGridViewTextBoxColumn,
            this.maKhoaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mONBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(372, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // qLDiemsvDataSet
            // 
            this.qLDiemsvDataSet.DataSetName = "QLDiemsvDataSet";
            this.qLDiemsvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONBindingSource1
            // 
            this.mONBindingSource1.DataMember = "MON";
            this.mONBindingSource1.DataSource = this.qLDiemsvDataSet;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "MaMon";
            this.maMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            this.maMonDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            this.tenMonDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDVHTDataGridViewTextBoxColumn
            // 
            this.soDVHTDataGridViewTextBoxColumn.DataPropertyName = "SoDVHT";
            this.soDVHTDataGridViewTextBoxColumn.HeaderText = "SoDVHT";
            this.soDVHTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDVHTDataGridViewTextBoxColumn.Name = "soDVHTDataGridViewTextBoxColumn";
            this.soDVHTDataGridViewTextBoxColumn.Width = 125;
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            this.maGVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hocKiDataGridViewTextBoxColumn
            // 
            this.hocKiDataGridViewTextBoxColumn.DataPropertyName = "HocKi";
            this.hocKiDataGridViewTextBoxColumn.HeaderText = "HocKi";
            this.hocKiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hocKiDataGridViewTextBoxColumn.Name = "hocKiDataGridViewTextBoxColumn";
            this.hocKiDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            this.maKhoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // QL_MON_HOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 561);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "QL_MON_HOC";
            this.Text = "QL_MON_HOC";
            this.Load += new System.EventHandler(this.QL_MON_HOC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemsvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbmakhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthocky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDVHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource mONBindingSource;
        private QLDiemsvDataSetTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDVHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mONBindingSource1;
        private QLDiemsvDataSet qLDiemsvDataSet;
    }
}