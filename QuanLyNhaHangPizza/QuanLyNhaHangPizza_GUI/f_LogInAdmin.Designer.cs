﻿
namespace QuanLyNhaHangPizza_GUI
{
    partial class f_LogInAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_LogInAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass_Ad = new System.Windows.Forms.TextBox();
            this.txtID_Ad = new System.Windows.Forms.TextBox();
            this.btnLogIn_Ad = new System.Windows.Forms.Button();
            this.btnExit_Ad = new System.Windows.Forms.Button();
            this.checkPass_Ad = new System.Windows.Forms.CheckBox();
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
            this.label1.ForeColor = System.Drawing.Color.Black;
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
            this.pictureBox2.Location = new System.Drawing.Point(24, 93);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 282);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
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
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(308, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtPass_Ad
            // 
            this.txtPass_Ad.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass_Ad.Location = new System.Drawing.Point(440, 309);
            this.txtPass_Ad.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass_Ad.Name = "txtPass_Ad";
            this.txtPass_Ad.Size = new System.Drawing.Size(208, 26);
            this.txtPass_Ad.TabIndex = 4;
            this.txtPass_Ad.TextChanged += new System.EventHandler(this.txtPass_Ad_TextChanged);
            // 
            // txtID_Ad
            // 
            this.txtID_Ad.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_Ad.Location = new System.Drawing.Point(440, 249);
            this.txtID_Ad.Margin = new System.Windows.Forms.Padding(2);
            this.txtID_Ad.Name = "txtID_Ad";
            this.txtID_Ad.Size = new System.Drawing.Size(208, 26);
            this.txtID_Ad.TabIndex = 4;
            this.txtID_Ad.TextChanged += new System.EventHandler(this.txtID_Ad_TextChanged);
            // 
            // btnLogIn_Ad
            // 
            this.btnLogIn_Ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.btnLogIn_Ad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogIn_Ad.FlatAppearance.BorderSize = 2;
            this.btnLogIn_Ad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn_Ad.ForeColor = System.Drawing.Color.White;
            this.btnLogIn_Ad.Location = new System.Drawing.Point(534, 397);
            this.btnLogIn_Ad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn_Ad.Name = "btnLogIn_Ad";
            this.btnLogIn_Ad.Size = new System.Drawing.Size(112, 46);
            this.btnLogIn_Ad.TabIndex = 5;
            this.btnLogIn_Ad.Text = "Đăng nhập";
            this.btnLogIn_Ad.UseVisualStyleBackColor = false;
            this.btnLogIn_Ad.Click += new System.EventHandler(this.btnLogIn_Ad_Click);
            // 
            // btnExit_Ad
            // 
            this.btnExit_Ad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.btnExit_Ad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit_Ad.FlatAppearance.BorderSize = 2;
            this.btnExit_Ad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit_Ad.ForeColor = System.Drawing.Color.White;
            this.btnExit_Ad.Location = new System.Drawing.Point(357, 397);
            this.btnExit_Ad.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit_Ad.Name = "btnExit_Ad";
            this.btnExit_Ad.Size = new System.Drawing.Size(112, 46);
            this.btnExit_Ad.TabIndex = 5;
            this.btnExit_Ad.Text = "Thoát";
            this.btnExit_Ad.UseVisualStyleBackColor = false;
            this.btnExit_Ad.Click += new System.EventHandler(this.btnExit_Ad_Click);
            // 
            // checkPass_Ad
            // 
            this.checkPass_Ad.AutoSize = true;
            this.checkPass_Ad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPass_Ad.ForeColor = System.Drawing.Color.Black;
            this.checkPass_Ad.Location = new System.Drawing.Point(440, 353);
            this.checkPass_Ad.Margin = new System.Windows.Forms.Padding(2);
            this.checkPass_Ad.Name = "checkPass_Ad";
            this.checkPass_Ad.Size = new System.Drawing.Size(144, 24);
            this.checkPass_Ad.TabIndex = 6;
            this.checkPass_Ad.Text = "Hiển thị mật khẩu";
            this.checkPass_Ad.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // f_LogInAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(765, 491);
            this.Controls.Add(this.checkPass_Ad);
            this.Controls.Add(this.btnExit_Ad);
            this.Controls.Add(this.btnLogIn_Ad);
            this.Controls.Add(this.txtID_Ad);
            this.Controls.Add(this.txtPass_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "f_LogInAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP QUẢN LÝ";
            this.Load += new System.EventHandler(this.f_LogInAdmin_Load);
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
        private System.Windows.Forms.TextBox txtPass_Ad;
        private System.Windows.Forms.TextBox txtID_Ad;
        private System.Windows.Forms.Button btnLogIn_Ad;
        private System.Windows.Forms.Button btnExit_Ad;
        private System.Windows.Forms.CheckBox checkPass_Ad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}