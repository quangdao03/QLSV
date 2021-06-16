
namespace phanmemquanlidiemUTT
{
    partial class QL_MON
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
            this.mONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.uTTquanlisvDataSet = new phanmemquanlidiemUTT.UTTquanlisvDataSet();
            this.uTTquanlisvDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mONTableAdapter = new phanmemquanlidiemUTT.UTTquanlisvDataSetTableAdapters.MONTableAdapter();
            this.maMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDVHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(751, 362);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 41);
            this.button4.TabIndex = 17;
            this.button4.Text = "Thoat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(751, 303);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(751, 252);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 41);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mONBindingSource1
            // 
            this.mONBindingSource1.DataMember = "MON";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonDataGridViewTextBoxColumn,
            this.tenMonDataGridViewTextBoxColumn,
            this.soDVHTDataGridViewTextBoxColumn,
            this.maGVDataGridViewTextBoxColumn,
            this.hocKiDataGridViewTextBoxColumn,
            this.maKhoaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mONBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(279, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // cbmakhoa
            // 
            this.cbmakhoa.FormattingEnabled = true;
            this.cbmakhoa.Location = new System.Drawing.Point(84, 295);
            this.cbmakhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbmakhoa.Name = "cbmakhoa";
            this.cbmakhoa.Size = new System.Drawing.Size(175, 21);
            this.cbmakhoa.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã Khoa";
            // 
            // txthocky
            // 
            this.txthocky.Location = new System.Drawing.Point(84, 242);
            this.txthocky.Margin = new System.Windows.Forms.Padding(2);
            this.txthocky.Name = "txthocky";
            this.txthocky.Size = new System.Drawing.Size(175, 20);
            this.txthocky.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Học Kỳ";
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(84, 192);
            this.txtmagv.Margin = new System.Windows.Forms.Padding(2);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(175, 20);
            this.txtmagv.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã GV";
            // 
            // txtDVHT
            // 
            this.txtDVHT.Location = new System.Drawing.Point(84, 144);
            this.txtDVHT.Margin = new System.Windows.Forms.Padding(2);
            this.txtDVHT.Name = "txtDVHT";
            this.txtDVHT.Size = new System.Drawing.Size(175, 20);
            this.txtDVHT.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số DVHT";
            // 
            // txttenmon
            // 
            this.txttenmon.Location = new System.Drawing.Point(84, 94);
            this.txttenmon.Margin = new System.Windows.Forms.Padding(2);
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(175, 20);
            this.txttenmon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên Môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Môn";
            // 
            // txtmamon
            // 
            this.txtmamon.Location = new System.Drawing.Point(84, 54);
            this.txtmamon.Margin = new System.Windows.Forms.Padding(2);
            this.txtmamon.Name = "txtmamon";
            this.txtmamon.Size = new System.Drawing.Size(175, 20);
            this.txtmamon.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(436, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(281, 354);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
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
            this.groupBox1.Location = new System.Drawing.Point(150, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(281, 354);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(324, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // uTTquanlisvDataSet
            // 
            this.uTTquanlisvDataSet.DataSetName = "UTTquanlisvDataSet";
            this.uTTquanlisvDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uTTquanlisvDataSetBindingSource
            // 
            this.uTTquanlisvDataSetBindingSource.DataSource = this.uTTquanlisvDataSet;
            this.uTTquanlisvDataSetBindingSource.Position = 0;
            // 
            // mONBindingSource2
            // 
            this.mONBindingSource2.DataMember = "MON";
            this.mONBindingSource2.DataSource = this.uTTquanlisvDataSetBindingSource;
            // 
            // mONTableAdapter
            // 
            this.mONTableAdapter.ClearBeforeFill = true;
            // 
            // maMonDataGridViewTextBoxColumn
            // 
            this.maMonDataGridViewTextBoxColumn.DataPropertyName = "MaMon";
            this.maMonDataGridViewTextBoxColumn.HeaderText = "MaMon";
            this.maMonDataGridViewTextBoxColumn.Name = "maMonDataGridViewTextBoxColumn";
            // 
            // tenMonDataGridViewTextBoxColumn
            // 
            this.tenMonDataGridViewTextBoxColumn.DataPropertyName = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.HeaderText = "TenMon";
            this.tenMonDataGridViewTextBoxColumn.Name = "tenMonDataGridViewTextBoxColumn";
            // 
            // soDVHTDataGridViewTextBoxColumn
            // 
            this.soDVHTDataGridViewTextBoxColumn.DataPropertyName = "SoDVHT";
            this.soDVHTDataGridViewTextBoxColumn.HeaderText = "SoDVHT";
            this.soDVHTDataGridViewTextBoxColumn.Name = "soDVHTDataGridViewTextBoxColumn";
            // 
            // maGVDataGridViewTextBoxColumn
            // 
            this.maGVDataGridViewTextBoxColumn.DataPropertyName = "MaGV";
            this.maGVDataGridViewTextBoxColumn.HeaderText = "MaGV";
            this.maGVDataGridViewTextBoxColumn.Name = "maGVDataGridViewTextBoxColumn";
            // 
            // hocKiDataGridViewTextBoxColumn
            // 
            this.hocKiDataGridViewTextBoxColumn.DataPropertyName = "HocKi";
            this.hocKiDataGridViewTextBoxColumn.HeaderText = "HocKi";
            this.hocKiDataGridViewTextBoxColumn.Name = "hocKiDataGridViewTextBoxColumn";
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            // 
            // QL_MON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 565);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "QL_MON";
            this.Text = "QL_MON";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QL_MON_FormClosing);
            this.Load += new System.EventHandler(this.QL_MON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mONBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource mONBindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmakhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthocky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDVHT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenmon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmamon;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private UTTquanlisvDataSet uTTquanlisvDataSet;
        private System.Windows.Forms.BindingSource uTTquanlisvDataSetBindingSource;
        private System.Windows.Forms.BindingSource mONBindingSource2;
        private UTTquanlisvDataSetTableAdapters.MONTableAdapter mONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDVHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
    }
}