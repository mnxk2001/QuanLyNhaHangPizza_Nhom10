
namespace QuanLyNhaHangPizza_GUI
{
    partial class f_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogIn_Cus = new System.Windows.Forms.Button();
            this.btnLogIn_Admin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(156, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(106, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÀ HÀNG PIZZA";
            // 
            // btnLogIn_Cus
            // 
            this.btnLogIn_Cus.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogIn_Cus.FlatAppearance.BorderSize = 0;
            this.btnLogIn_Cus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn_Cus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnLogIn_Cus.Location = new System.Drawing.Point(156, 496);
            this.btnLogIn_Cus.Name = "btnLogIn_Cus";
            this.btnLogIn_Cus.Size = new System.Drawing.Size(290, 72);
            this.btnLogIn_Cus.TabIndex = 2;
            this.btnLogIn_Cus.Text = "ĐĂNG NHẬP NHÂN VIÊN";
            this.btnLogIn_Cus.UseVisualStyleBackColor = false;
            this.btnLogIn_Cus.Click += new System.EventHandler(this.btnLogIn_Cus_Click);
            // 
            // btnLogIn_Admin
            // 
            this.btnLogIn_Admin.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogIn_Admin.FlatAppearance.BorderSize = 0;
            this.btnLogIn_Admin.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn_Admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnLogIn_Admin.Location = new System.Drawing.Point(156, 593);
            this.btnLogIn_Admin.Name = "btnLogIn_Admin";
            this.btnLogIn_Admin.Size = new System.Drawing.Size(290, 72);
            this.btnLogIn_Admin.TabIndex = 2;
            this.btnLogIn_Admin.Text = "ĐĂNG NHẬP QUẢN LÝ";
            this.btnLogIn_Admin.UseVisualStyleBackColor = false;
            this.btnLogIn_Admin.Click += new System.EventHandler(this.btnLogIn_Admin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            this.btnExit.Location = new System.Drawing.Point(156, 693);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(290, 72);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // f_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(48)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(605, 885);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogIn_Admin);
            this.Controls.Add(this.btnLogIn_Cus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "f_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHÀ HÀNG PIZZA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.f_Home_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogIn_Cus;
        private System.Windows.Forms.Button btnLogIn_Admin;
        private System.Windows.Forms.Button btnExit;
    }
}