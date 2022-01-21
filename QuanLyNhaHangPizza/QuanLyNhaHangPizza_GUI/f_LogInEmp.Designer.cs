
namespace QuanLyNhaHangPizza_GUI
{
    partial class f_LogInEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_LogInEmp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass_Emp = new System.Windows.Forms.TextBox();
            this.txtID_Emp = new System.Windows.Forms.TextBox();
            this.btnLogIn_Cus = new System.Windows.Forms.Button();
            this.btnExit_Cus = new System.Windows.Forms.Button();
            this.checkPass_Cus = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(403, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHÀO MỪNG ĐĂNG NHẬP";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(20, 93);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 282);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtPass_Emp
            // 
            this.txtPass_Emp.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass_Emp.Location = new System.Drawing.Point(440, 309);
            this.txtPass_Emp.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass_Emp.Name = "txtPass_Emp";
            this.txtPass_Emp.Size = new System.Drawing.Size(208, 26);
            this.txtPass_Emp.TabIndex = 4;
            this.txtPass_Emp.TextChanged += new System.EventHandler(this.txtPass_Cus_TextChanged);
            // 
            // txtID_Emp
            // 
            this.txtID_Emp.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Emp.Location = new System.Drawing.Point(440, 249);
            this.txtID_Emp.Margin = new System.Windows.Forms.Padding(2);
            this.txtID_Emp.Name = "txtID_Emp";
            this.txtID_Emp.Size = new System.Drawing.Size(208, 26);
            this.txtID_Emp.TabIndex = 4;
            this.txtID_Emp.TextChanged += new System.EventHandler(this.txtID_Cus_TextChanged);
            // 
            // btnLogIn_Cus
            // 
            this.btnLogIn_Cus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.btnLogIn_Cus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn_Cus.ForeColor = System.Drawing.Color.White;
            this.btnLogIn_Cus.Location = new System.Drawing.Point(534, 410);
            this.btnLogIn_Cus.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn_Cus.Name = "btnLogIn_Cus";
            this.btnLogIn_Cus.Size = new System.Drawing.Size(112, 46);
            this.btnLogIn_Cus.TabIndex = 5;
            this.btnLogIn_Cus.Text = "Đăng nhập";
            this.btnLogIn_Cus.UseVisualStyleBackColor = false;
            this.btnLogIn_Cus.Click += new System.EventHandler(this.btnLogIn_Cus_Click);
            // 
            // btnExit_Cus
            // 
            this.btnExit_Cus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.btnExit_Cus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_Cus.ForeColor = System.Drawing.Color.White;
            this.btnExit_Cus.Location = new System.Drawing.Point(357, 410);
            this.btnExit_Cus.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit_Cus.Name = "btnExit_Cus";
            this.btnExit_Cus.Size = new System.Drawing.Size(112, 46);
            this.btnExit_Cus.TabIndex = 5;
            this.btnExit_Cus.Text = "Thoát";
            this.btnExit_Cus.UseVisualStyleBackColor = false;
            this.btnExit_Cus.Click += new System.EventHandler(this.btnExit_Cus_Click);
            // 
            // checkPass_Cus
            // 
            this.checkPass_Cus.AutoSize = true;
            this.checkPass_Cus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPass_Cus.Location = new System.Drawing.Point(440, 353);
            this.checkPass_Cus.Margin = new System.Windows.Forms.Padding(2);
            this.checkPass_Cus.Name = "checkPass_Cus";
            this.checkPass_Cus.Size = new System.Drawing.Size(144, 24);
            this.checkPass_Cus.TabIndex = 6;
            this.checkPass_Cus.Text = "Hiển thị mật khẩu";
            this.checkPass_Cus.UseVisualStyleBackColor = true;
            this.checkPass_Cus.CheckedChanged += new System.EventHandler(this.checkPass_Cus_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // f_LogInEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(765, 491);
            this.Controls.Add(this.checkPass_Cus);
            this.Controls.Add(this.btnExit_Cus);
            this.Controls.Add(this.btnLogIn_Cus);
            this.Controls.Add(this.txtID_Emp);
            this.Controls.Add(this.txtPass_Emp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "f_LogInEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP NHÂN VIÊN";
            this.Load += new System.EventHandler(this.f_LogInEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass_Emp;
        private System.Windows.Forms.TextBox txtID_Emp;
        private System.Windows.Forms.Button btnLogIn_Cus;
        private System.Windows.Forms.Button btnExit_Cus;
        private System.Windows.Forms.CheckBox checkPass_Cus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}