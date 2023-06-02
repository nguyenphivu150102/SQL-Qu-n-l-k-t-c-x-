namespace SQL_Quản_lý_ký_túc_xá
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_TT = new System.Windows.Forms.TextBox();
            this.tb_TenSV = new System.Windows.Forms.TextBox();
            this.tb_MaSV = new System.Windows.Forms.TextBox();
            this.tb_Gioitinh = new System.Windows.Forms.TextBox();
            this.tb_Tuoi = new System.Windows.Forms.TextBox();
            this.tb_Sophong = new System.Windows.Forms.TextBox();
            this.tb_Ngaynhanphong = new System.Windows.Forms.TextBox();
            this.tb_Ngaytraphong = new System.Windows.Forms.TextBox();
            this.tb_them = new System.Windows.Forms.Button();
            this.tb_xoa = new System.Windows.Forms.Button();
            this.tb_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Location = new System.Drawing.Point(0, 19);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(584, 95);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_Ngaytraphong);
            this.groupBox2.Controls.Add(this.tb_Gioitinh);
            this.groupBox2.Controls.Add(this.tb_Ngaynhanphong);
            this.groupBox2.Controls.Add(this.tb_Sophong);
            this.groupBox2.Controls.Add(this.tb_Tuoi);
            this.groupBox2.Controls.Add(this.tb_TenSV);
            this.groupBox2.Controls.Add(this.tb_MaSV);
            this.groupBox2.Controls.Add(this.tb_TT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(29, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenSV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MaSV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gioitinh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tuoi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sophong";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngaynhanphong";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngaytraphong";
            // 
            // tb_TT
            // 
            this.tb_TT.Location = new System.Drawing.Point(100, 22);
            this.tb_TT.Name = "tb_TT";
            this.tb_TT.Size = new System.Drawing.Size(182, 20);
            this.tb_TT.TabIndex = 8;
            // 
            // tb_TenSV
            // 
            this.tb_TenSV.Location = new System.Drawing.Point(100, 47);
            this.tb_TenSV.Name = "tb_TenSV";
            this.tb_TenSV.Size = new System.Drawing.Size(182, 20);
            this.tb_TenSV.TabIndex = 9;
            // 
            // tb_MaSV
            // 
            this.tb_MaSV.Location = new System.Drawing.Point(100, 77);
            this.tb_MaSV.Name = "tb_MaSV";
            this.tb_MaSV.Size = new System.Drawing.Size(182, 20);
            this.tb_MaSV.TabIndex = 10;
            this.tb_MaSV.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tb_Gioitinh
            // 
            this.tb_Gioitinh.Location = new System.Drawing.Point(100, 105);
            this.tb_Gioitinh.Name = "tb_Gioitinh";
            this.tb_Gioitinh.Size = new System.Drawing.Size(182, 20);
            this.tb_Gioitinh.TabIndex = 11;
            this.tb_Gioitinh.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tb_Tuoi
            // 
            this.tb_Tuoi.Location = new System.Drawing.Point(100, 133);
            this.tb_Tuoi.Name = "tb_Tuoi";
            this.tb_Tuoi.Size = new System.Drawing.Size(182, 20);
            this.tb_Tuoi.TabIndex = 12;
            this.tb_Tuoi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tb_Sophong
            // 
            this.tb_Sophong.Location = new System.Drawing.Point(100, 160);
            this.tb_Sophong.Name = "tb_Sophong";
            this.tb_Sophong.Size = new System.Drawing.Size(182, 20);
            this.tb_Sophong.TabIndex = 13;
            this.tb_Sophong.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tb_Ngaynhanphong
            // 
            this.tb_Ngaynhanphong.Location = new System.Drawing.Point(100, 192);
            this.tb_Ngaynhanphong.Name = "tb_Ngaynhanphong";
            this.tb_Ngaynhanphong.Size = new System.Drawing.Size(182, 20);
            this.tb_Ngaynhanphong.TabIndex = 14;
            // 
            // tb_Ngaytraphong
            // 
            this.tb_Ngaytraphong.Location = new System.Drawing.Point(100, 225);
            this.tb_Ngaytraphong.Name = "tb_Ngaytraphong";
            this.tb_Ngaytraphong.Size = new System.Drawing.Size(182, 20);
            this.tb_Ngaytraphong.TabIndex = 15;
            // 
            // tb_them
            // 
            this.tb_them.Location = new System.Drawing.Point(422, 190);
            this.tb_them.Name = "tb_them";
            this.tb_them.Size = new System.Drawing.Size(75, 23);
            this.tb_them.TabIndex = 3;
            this.tb_them.Text = "THÊM";
            this.tb_them.UseVisualStyleBackColor = true;
            this.tb_them.Click += new System.EventHandler(this.tb_them_Click);
            // 
            // tb_xoa
            // 
            this.tb_xoa.Location = new System.Drawing.Point(422, 245);
            this.tb_xoa.Name = "tb_xoa";
            this.tb_xoa.Size = new System.Drawing.Size(75, 23);
            this.tb_xoa.TabIndex = 4;
            this.tb_xoa.Text = "XÓA";
            this.tb_xoa.UseVisualStyleBackColor = true;
            this.tb_xoa.Click += new System.EventHandler(this.tb_xoa_Click);
            // 
            // tb_sua
            // 
            this.tb_sua.Location = new System.Drawing.Point(422, 301);
            this.tb_sua.Name = "tb_sua";
            this.tb_sua.Size = new System.Drawing.Size(75, 23);
            this.tb_sua.TabIndex = 5;
            this.tb_sua.Text = "SỬA";
            this.tb_sua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 442);
            this.Controls.Add(this.tb_sua);
            this.Controls.Add(this.tb_xoa);
            this.Controls.Add(this.tb_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Ngaytraphong;
        private System.Windows.Forms.TextBox tb_Ngaynhanphong;
        private System.Windows.Forms.TextBox tb_Sophong;
        private System.Windows.Forms.TextBox tb_Tuoi;
        private System.Windows.Forms.TextBox tb_Gioitinh;
        private System.Windows.Forms.TextBox tb_MaSV;
        private System.Windows.Forms.TextBox tb_TenSV;
        private System.Windows.Forms.TextBox tb_TT;
        private System.Windows.Forms.Button tb_them;
        private System.Windows.Forms.Button tb_xoa;
        private System.Windows.Forms.Button tb_sua;
    }
}

