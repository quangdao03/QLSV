
namespace phanmemquanlidiemUTT
{
    partial class QL_LOP
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.cbmakhoa = new System.Windows.Forms.ComboBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uTTquanlisvDataSet = new phanmemquanlidiemUTT.UTTquanlisvDataSet();
            this.uTTquanlisvDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new phanmemquanlidiemUTT.UTTquanlisvDataSetTableAdapters.LOPTableAdapter();
            this.maKhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(733, 378);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 47);
            this.button4.TabIndex = 17;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(733, 306);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 47);
            this.button3.TabIndex = 16;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 236);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(298, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÝ LỚP";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoaDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lOPBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(305, 342);
            this.dataGridView1.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(411, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(305, 387);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(76, 162);
            this.txttenlop.Margin = new System.Windows.Forms.Padding(2);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(182, 20);
            this.txttenlop.TabIndex = 7;
            // 
            // cbmakhoa
            // 
            this.cbmakhoa.FormattingEnabled = true;
            this.cbmakhoa.Location = new System.Drawing.Point(76, 106);
            this.cbmakhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbmakhoa.Name = "cbmakhoa";
            this.cbmakhoa.Size = new System.Drawing.Size(182, 21);
            this.cbmakhoa.TabIndex = 6;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(76, 54);
            this.txtmalop.Margin = new System.Windows.Forms.Padding(2);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(182, 20);
            this.txtmalop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttenlop);
            this.groupBox1.Controls.Add(this.cbmakhoa);
            this.groupBox1.Controls.Add(this.txtmalop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(110, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(296, 387);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
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
            // lOPBindingSource1
            // 
            this.lOPBindingSource1.DataMember = "LOP";
            this.lOPBindingSource1.DataSource = this.uTTquanlisvDataSetBindingSource;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // maKhoaDataGridViewTextBoxColumn
            // 
            this.maKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa";
            this.maKhoaDataGridViewTextBoxColumn.Name = "maKhoaDataGridViewTextBoxColumn";
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            // 
            // QL_LOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 557);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QL_LOP";
            this.Text = "QL_LOP";
            this.Load += new System.EventHandler(this.QL_LOP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uTTquanlisvDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.ComboBox cbmakhoa;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource uTTquanlisvDataSetBindingSource;
        private UTTquanlisvDataSet uTTquanlisvDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource1;
        private UTTquanlisvDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
    }
}