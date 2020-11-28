using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
namespace QuanLyCuaHang
{
    public partial class Account : Form
    {
        QLCHDoChoiEntities db = new QLCHDoChoiEntities();
        public Account()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            serviceManage data = new serviceManage();
            var list = data.getAllAcc();
            dataGridView1.DataSource = list;
        }
        // load data from database
        private void Account_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
            {
                return;
            }
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            //string id = Convert.ToString(dataGridViewRow.Cells[0].Value);
            string name = Convert.ToString(dataGridViewRow.Cells[1].Value);
            string position = Convert.ToString(dataGridViewRow.Cells[2].Value);
            string username = Convert.ToString(dataGridViewRow.Cells[3].Value);
            string password = Convert.ToString(dataGridViewRow.Cells[4].Value);

            txtNameEmp.Text = name;
            txtPosition.Text = position;
            txtUserName.Text = username;
            txtPass.Text = password;
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            taiKhoan tc = db.taiKhoans.Where(p => p.tenTK == username).SingleOrDefault();
            db.taiKhoans.Remove(tc);
            db.SaveChanges();
            LoadData();


            // after delete clear data in textBox
            txtNameEmp.Text = "";
            txtPass.Text = "";
            txtPosition.Text = "";
            txtUserName.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameEmp.Text = "";
            txtPass.Text = "";
            txtPosition.Text = "";
            txtUserName.Text = "";
        }

        private void btnChangeDataAcc_Click(object sender, EventArgs e)
        {
            int stt =Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["stt"].Value.ToString());
            taiKhoan tk = db.taiKhoans.SingleOrDefault(m=>m.stt==stt);
            tk.TenNV = txtNameEmp.Text;
            tk.tenTK = txtUserName.Text;
            tk.matkhau = txtPass.Text;

            db.SaveChanges();
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có thật sự muốn thoát ?", "thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
