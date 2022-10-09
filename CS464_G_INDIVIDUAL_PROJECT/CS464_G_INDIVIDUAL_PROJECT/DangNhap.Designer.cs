
namespace CS464_G_INDIVIDUAL_PROJECT
{
    partial class DangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDN.Location = new System.Drawing.Point(421, 134);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(265, 39);
            this.txt_TenDN.TabIndex = 2;
            // 
            // txt_MK
            // 
            this.txt_MK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MK.Location = new System.Drawing.Point(421, 239);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(265, 39);
            this.txt_MK.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(304, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // btn_DN
            // 
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN.Location = new System.Drawing.Point(169, 312);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(167, 39);
            this.btn_DN.TabIndex = 5;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(470, 312);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(167, 39);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 377);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TenDN;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Button btn_Exit;
    }
}