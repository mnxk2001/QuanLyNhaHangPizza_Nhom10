
namespace QuanLyNhaHangPizza_GUI
{
    partial class f_Bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridBill = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtID_Emp = new System.Windows.Forms.TextBox();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.txtDateFounded = new System.Windows.Forms.TextBox();
            this.txtID_Cus = new System.Windows.Forms.TextBox();
            this.txtID_Bill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridBill);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 339);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // gridBill
            // 
            this.gridBill.BackgroundColor = System.Drawing.Color.White;
            this.gridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBill.Location = new System.Drawing.Point(3, 23);
            this.gridBill.Name = "gridBill";
            this.gridBill.RowHeadersWidth = 51;
            this.gridBill.RowTemplate.Height = 24;
            this.gridBill.Size = new System.Drawing.Size(1090, 313);
            this.gridBill.TabIndex = 0;
            this.gridBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBill_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.txtID_Emp);
            this.groupBox2.Controls.Add(this.txtTotalMoney);
            this.groupBox2.Controls.Add(this.txtDateFounded);
            this.groupBox2.Controls.Add(this.txtID_Cus);
            this.groupBox2.Controls.Add(this.txtID_Bill);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(600, 127);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(280, 27);
            this.txtNote.TabIndex = 1;
            // 
            // txtID_Emp
            // 
            this.txtID_Emp.Enabled = false;
            this.txtID_Emp.Location = new System.Drawing.Point(137, 127);
            this.txtID_Emp.Name = "txtID_Emp";
            this.txtID_Emp.Size = new System.Drawing.Size(233, 27);
            this.txtID_Emp.TabIndex = 1;
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Enabled = false;
            this.txtTotalMoney.Location = new System.Drawing.Point(600, 81);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(280, 27);
            this.txtTotalMoney.TabIndex = 1;
            // 
            // txtDateFounded
            // 
            this.txtDateFounded.Enabled = false;
            this.txtDateFounded.Location = new System.Drawing.Point(600, 37);
            this.txtDateFounded.Name = "txtDateFounded";
            this.txtDateFounded.Size = new System.Drawing.Size(280, 27);
            this.txtDateFounded.TabIndex = 1;
            // 
            // txtID_Cus
            // 
            this.txtID_Cus.Enabled = false;
            this.txtID_Cus.Location = new System.Drawing.Point(137, 81);
            this.txtID_Cus.Name = "txtID_Cus";
            this.txtID_Cus.Size = new System.Drawing.Size(233, 27);
            this.txtID_Cus.TabIndex = 1;
            // 
            // txtID_Bill
            // 
            this.txtID_Bill.Enabled = false;
            this.txtID_Bill.Location = new System.Drawing.Point(137, 37);
            this.txtID_Bill.Name = "txtID_Bill";
            this.txtID_Bill.Size = new System.Drawing.Size(233, 27);
            this.txtID_Bill.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã KH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày tạo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(924, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 61);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy thanh toán";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // f_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 588);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "f_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            this.Load += new System.EventHandler(this.f_Bill_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridBill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtID_Emp;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.TextBox txtDateFounded;
        private System.Windows.Forms.TextBox txtID_Cus;
        private System.Windows.Forms.TextBox txtID_Bill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
    }
}