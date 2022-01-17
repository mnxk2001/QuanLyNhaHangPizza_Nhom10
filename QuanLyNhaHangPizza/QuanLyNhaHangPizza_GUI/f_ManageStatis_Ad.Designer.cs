
namespace QuanLyNhaHangPizza_GUI
{
    partial class f_ManageStatis_Ad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ManageStatis_Ad));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRevenue = new System.Windows.Forms.TabPage();
            this.btnShow_tab1 = new System.Windows.Forms.Button();
            this.btnExit_tab1 = new System.Windows.Forms.Button();
            this.btnRefesh_tab1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEnd_tab1 = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin_tab1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.btnExit_tab2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridEmp_tab2 = new System.Windows.Forms.DataGridView();
            this.txtSearchEmp_Name_tab2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabRevenue.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabEmployee.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmp_tab2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRevenue);
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 614);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRevenue
            // 
            this.tabRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            this.tabRevenue.Controls.Add(this.btnShow_tab1);
            this.tabRevenue.Controls.Add(this.btnExit_tab1);
            this.tabRevenue.Controls.Add(this.btnRefesh_tab1);
            this.tabRevenue.Controls.Add(this.groupBox2);
            this.tabRevenue.Controls.Add(this.groupBox1);
            this.tabRevenue.Location = new System.Drawing.Point(4, 32);
            this.tabRevenue.Name = "tabRevenue";
            this.tabRevenue.Padding = new System.Windows.Forms.Padding(3);
            this.tabRevenue.Size = new System.Drawing.Size(796, 578);
            this.tabRevenue.TabIndex = 0;
            this.tabRevenue.Text = "Doanh thu";
            // 
            // btnShow_tab1
            // 
            this.btnShow_tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.btnShow_tab1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow_tab1.ForeColor = System.Drawing.Color.White;
            this.btnShow_tab1.Image = ((System.Drawing.Image)(resources.GetObject("btnShow_tab1.Image")));
            this.btnShow_tab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow_tab1.Location = new System.Drawing.Point(501, 99);
            this.btnShow_tab1.Name = "btnShow_tab1";
            this.btnShow_tab1.Size = new System.Drawing.Size(144, 53);
            this.btnShow_tab1.TabIndex = 2;
            this.btnShow_tab1.Text = "Xem";
            this.btnShow_tab1.UseVisualStyleBackColor = false;
            // 
            // btnExit_tab1
            // 
            this.btnExit_tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.btnExit_tab1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_tab1.ForeColor = System.Drawing.Color.White;
            this.btnExit_tab1.Image = ((System.Drawing.Image)(resources.GetObject("btnExit_tab1.Image")));
            this.btnExit_tab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit_tab1.Location = new System.Drawing.Point(651, 99);
            this.btnExit_tab1.Name = "btnExit_tab1";
            this.btnExit_tab1.Size = new System.Drawing.Size(140, 53);
            this.btnExit_tab1.TabIndex = 2;
            this.btnExit_tab1.Text = "Thoát";
            this.btnExit_tab1.UseVisualStyleBackColor = false;
            this.btnExit_tab1.Click += new System.EventHandler(this.btnExit_tab1_Click);
            // 
            // btnRefesh_tab1
            // 
            this.btnRefesh_tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.btnRefesh_tab1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefesh_tab1.ForeColor = System.Drawing.Color.White;
            this.btnRefesh_tab1.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh_tab1.Image")));
            this.btnRefesh_tab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefesh_tab1.Location = new System.Drawing.Point(501, 24);
            this.btnRefesh_tab1.Name = "btnRefesh_tab1";
            this.btnRefesh_tab1.Size = new System.Drawing.Size(144, 56);
            this.btnRefesh_tab1.TabIndex = 2;
            this.btnRefesh_tab1.Text = "Làm mới";
            this.btnRefesh_tab1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(5)))), ((int)(((byte)(61)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê doanh thu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 304);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEnd_tab1);
            this.groupBox1.Controls.Add(this.dtpBegin_tab1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(5)))), ((int)(((byte)(61)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn thời gian";
            // 
            // dtpEnd_tab1
            // 
            this.dtpEnd_tab1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd_tab1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd_tab1.Location = new System.Drawing.Point(234, 93);
            this.dtpEnd_tab1.Name = "dtpEnd_tab1";
            this.dtpEnd_tab1.Size = new System.Drawing.Size(182, 34);
            this.dtpEnd_tab1.TabIndex = 1;
            // 
            // dtpBegin_tab1
            // 
            this.dtpBegin_tab1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBegin_tab1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBegin_tab1.Location = new System.Drawing.Point(234, 40);
            this.dtpBegin_tab1.Name = "dtpBegin_tab1";
            this.dtpBegin_tab1.Size = new System.Drawing.Size(182, 34);
            this.dtpBegin_tab1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày bắt đầu:";
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(222)))));
            this.tabEmployee.Controls.Add(this.btnExit_tab2);
            this.tabEmployee.Controls.Add(this.groupBox3);
            this.tabEmployee.Controls.Add(this.txtSearchEmp_Name_tab2);
            this.tabEmployee.Controls.Add(this.label3);
            this.tabEmployee.Location = new System.Drawing.Point(4, 32);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(796, 578);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Nhân viên";
            // 
            // btnExit_tab2
            // 
            this.btnExit_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(81)))), ((int)(((byte)(112)))));
            this.btnExit_tab2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_tab2.ForeColor = System.Drawing.Color.White;
            this.btnExit_tab2.Image = ((System.Drawing.Image)(resources.GetObject("btnExit_tab2.Image")));
            this.btnExit_tab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit_tab2.Location = new System.Drawing.Point(634, 503);
            this.btnExit_tab2.Name = "btnExit_tab2";
            this.btnExit_tab2.Size = new System.Drawing.Size(138, 57);
            this.btnExit_tab2.TabIndex = 3;
            this.btnExit_tab2.Text = "Thoát";
            this.btnExit_tab2.UseVisualStyleBackColor = false;
            this.btnExit_tab2.Click += new System.EventHandler(this.btnExit_tab2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridEmp_tab2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(5)))), ((int)(((byte)(61)))));
            this.groupBox3.Location = new System.Drawing.Point(22, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(750, 398);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // gridEmp_tab2
            // 
            this.gridEmp_tab2.BackgroundColor = System.Drawing.Color.White;
            this.gridEmp_tab2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmp_tab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmp_tab2.Location = new System.Drawing.Point(3, 30);
            this.gridEmp_tab2.Name = "gridEmp_tab2";
            this.gridEmp_tab2.RowHeadersWidth = 51;
            this.gridEmp_tab2.RowTemplate.Height = 24;
            this.gridEmp_tab2.Size = new System.Drawing.Size(744, 365);
            this.gridEmp_tab2.TabIndex = 0;
            // 
            // txtSearchEmp_Name_tab2
            // 
            this.txtSearchEmp_Name_tab2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmp_Name_tab2.Location = new System.Drawing.Point(347, 24);
            this.txtSearchEmp_Name_tab2.Name = "txtSearchEmp_Name_tab2";
            this.txtSearchEmp_Name_tab2.Size = new System.Drawing.Size(365, 34);
            this.txtSearchEmp_Name_tab2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(5)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(51, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tìm kiếm nhân viên theo tên:";
            // 
            // f_ManageStatis_Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(804, 614);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "f_ManageStatis_Ad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THỐNG KÊ";
            this.tabControl1.ResumeLayout(false);
            this.tabRevenue.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabEmployee.ResumeLayout(false);
            this.tabEmployee.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmp_tab2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRevenue;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.Button btnShow_tab1;
        private System.Windows.Forms.Button btnExit_tab1;
        private System.Windows.Forms.Button btnRefesh_tab1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEnd_tab1;
        private System.Windows.Forms.DateTimePicker dtpBegin_tab1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit_tab2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridEmp_tab2;
        private System.Windows.Forms.TextBox txtSearchEmp_Name_tab2;
        private System.Windows.Forms.Label label3;
    }
}