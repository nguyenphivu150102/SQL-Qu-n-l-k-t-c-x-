using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_Quản_lý_ký_túc_xá
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=ADMIN\\SQL;Initial Catalog=QLKYTUCXA;Integrated Security=True";
        SqlDataAdapter adapter=new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command=connection.CreateCommand();
            command.CommandText="select*from SINHVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_TT.ReadOnly = true;
            int i;
            i = dgv.CurrentRow.Index;
            tb_TT.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tb_TenSV.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tb_MaSV.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tb_Gioitinh.Text = dgv.Rows[i].Cells[3].Value.ToString();
            tb_Tuoi.Text = dgv.Rows[i].Cells[4].Value.ToString();
            tb_Sophong.Text = dgv.Rows[i].Cells[5].Value.ToString();
            tb_Ngaynhanphong.Text = dgv.Rows[i].Cells[6].Value.ToString();
            tb_Ngaytraphong.Text = dgv.Rows[i].Cells[7].Value.ToString();
        }

        private void tb_them_Click(object sender, EventArgs e)
        {
            command=connection.CreateCommand();
            command.CommandText = "insert into SINHVIEN values('"+tb_TT.Text+"','"+tb_TenSV.Text+ "','"+tb_MaSV.Text+"','"+tb_Gioitinh.Text+ "','"+tb_Tuoi.Text+"','"+tb_Sophong.Text+ "','"+tb_Ngaynhanphong.Text+"','"+tb_Ngaytraphong.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void tb_xoa_Click(object sender, EventArgs e)
        {
            command= connection.CreateCommand();
            command.CommandText = "delete from SINHVIEN where TT='"+tb_TT.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }
        private void tb_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "update SINHVIEN set TenSV='" + tb_TenSV.Text + "', MaSV='" + tb_MaSV.Text + "', Gioitinh='" + tb_Gioitinh.Text + "', Tuoi='" + tb_Tuoi.Text + "', Sophong='" + tb_Sophong.Text + "', Ngaynhanphong='" + tb_Ngaynhanphong.Text + "', Ngaytraphong='" + tb_Ngaytraphong.Text + "' where TT='" + tb_TT.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }


    }
}
