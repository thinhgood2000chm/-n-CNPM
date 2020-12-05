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
    public partial class ManageEmployee : Form
    {
        QLCHDoChoiEntities db = new QLCHDoChoiEntities();
        public ManageEmployee()
        {
            InitializeComponent();
        }
        // ham xoa du lieu trne textbox
        public void ClearData()
        {
            txtNameE.Text = "";
            txtAddr.Text = "";
            txtPosition.Text = "";
            dtBirth.Value = DateTime.Now;
            radFemale.Checked = false;
            radMale.Checked = false ;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnChange.Enabled = true;
        }
        private void LoadData()
        {
            serviceManage data = new serviceManage();
            var list = data.getAllNhanVien();
            dataGridView1.DataSource = list;
        }
        //thiet lap enable cac nut 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSo.Text.Equals(""))
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = false;
                btnDelete.Enabled = false;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
        // hien thị data len textbox khi nhan vao gridview
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
            {
                return;
            }
            // get data in cells of gridView
            DataGridViewRow row = dataGridView1.Rows[index];
            String id = Convert.ToString(row.Cells[0].Value);
            String name = Convert.ToString(row.Cells[1].Value);
            String addr = Convert.ToString(row.Cells[2].Value);
            bool isMale = Convert.ToBoolean(row.Cells[3].Value);
            String position = Convert.ToString(row.Cells[4].Value);
            DateTime birth = Convert.ToDateTime(row.Cells[5].Value);

            //upload UI
            txtMaSo.Text = id;
            txtNameE.Text = name;
            txtAddr.Text = addr;
            txtPosition.Text = position;
            radMale.Checked = isMale;
            radFemale.Checked = !isMale;
            dtBirth.Value = birth;

            if (txtMaSo.Text == "")
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = false;
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void cácSảnPhẩmĐãBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsumeProduct consumeProduct = new ConsumeProduct();
            consumeProduct.Show();
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

  
   

        private void ManagerA_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        // add new employee
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddr.Text == "" || txtNameE.Text == "" || txtPosition.Text == ""|| (radFemale.Checked=false && radMale.Checked==false ))
            {
                MessageBox.Show("Bị thiếu thông tin vui lòng nhập lại");
            }
            else
            {
                nhanVien nv = new nhanVien()
                {
                    Ho_ten = txtNameE.Text,
                    Diachi = txtAddr.Text,
                    Gioi_tinh = radFemale.Checked ? true : false,
                    Chuc_vu = txtPosition.Text,
                    Ngay_sinh = dtBirth.Value
                };
                db.nhanViens.Add(nv);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("thêm nhân viên thành công ");

                // after add successfullly, delete data in textbox
                ClearData();
    
            }
        }
        // ham sau thông tin 
        private void btnChange_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells["Ma_nv"].Value.ToString());
            nhanVien nv = db.nhanViens.Find(id);
            nv.Ho_ten = txtNameE.Text;
            nv.Diachi = txtAddr.Text;
            nv.Chuc_vu = txtPosition.Text;
            nv.Gioi_tinh = radMale.Checked ? true : false;
            nv.Ngay_sinh = dtBirth.Value;
            db.SaveChanges();
            LoadData();
        }
        // ham xoa thong tin 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaSo.Text);
            nhanVien nv = db.nhanViens.Where(p => p.Ma_nv == id).SingleOrDefault();
            db.nhanViens.Remove(nv);
            db.SaveChanges();
            LoadData();
            ClearData();
        }
        // menuStrip chuyên qua màn hình account
        private void hiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
           string nameFind = txtFind.Text;
           //int stt = Convert.ToInt32(txtFind.Text);
           foreach (var nv in db.nhanViens)
            {
                if (nv.Ho_ten.Equals(nameFind)|| nv.Chuc_vu.Equals(nameFind))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                
                 var list2 = db.nhanViens.Where(p=> p.Ho_ten== nameFind||p.Chuc_vu==nameFind).ToList();
                 dataGridView1.DataSource = list2;
                
                /*var list2 = (from a in db.nhanViens where a.Ma_nv == stt select a).ToList();
                dataGridView1.DataSource = list2;*/
            }
            else MessageBox.Show("Không tìm thấy dữ liệu");
        }
    }
}
