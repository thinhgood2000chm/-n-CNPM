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
    public partial class ManageCustomer : Form
    {
        QLCHDoChoiEntities db = new QLCHDoChoiEntities();
        public ManageCustomer()
        {
            InitializeComponent();
        }
        public string dataAdd;
        public void LoadData()
        {
            serviceManage data = new serviceManage();
            var list = data.getAllKhachHang();
            dataGridView1.DataSource = list;

        }
        
        private void ManageCustomer_Load(object sender, EventArgs e)
        {

            LoadData();
            // sau khi lưu dữ liệu bên hóa đơn sẽ tự động chuyên qua quan 
            //lý khách hàng đê tiếp tục thêm những thông tin chưa có 

            int index = 0;
            foreach (var customer in db.khachHangs)
            {

                if (customer.Lan_mua.ToString() == "")
                {

                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
                    string stt = Convert.ToString(dataGridViewRow.Cells[0].Value);
                    string id = Convert.ToString(dataGridViewRow.Cells[1].Value);
                    string nameCus = Convert.ToString(dataGridViewRow.Cells[2].Value);
                    bool sex = Convert.ToBoolean(dataGridViewRow.Cells[4].Value);
                    string times = Convert.ToString(dataGridViewRow.Cells[5].Value);
                    string phone = Convert.ToString(dataGridViewRow.Cells[3].Value);

                    txtMaKh.Text = id;
                    txtCustomerName.Text = nameCus;
                    txtCustomerPhoneNum.Text = phone;
                    txtTimes.Text = times;
                    radMaleCus.Checked = sex;
                    radFemaleCus.Checked = !sex;
                    break;
                }
                else 
                index = index + 1;

            }
        }

    

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct();
            manageProduct.ShowDialog();
        }

  

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // add new customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtMaKh.Text == "" || txtCustomerPhoneNum.Text == "" || txtTimes.Text == "" || radFemaleCus.Checked == false && radMaleCus.Checked == false)
            {
                MessageBox.Show("bạn chưa nhập đầy đủ thông tin");
            }
            else
            {
                khachHang kh = new khachHang()
                {
                    Ma_kh = txtMaKh.Text,
                    Ho_ten = txtCustomerName.Text,
                    SDT = txtCustomerPhoneNum.Text,
                    Gioi_tinh = radMaleCus.Checked ? true : false,
                    Lan_mua = Convert.ToInt32(txtTimes.Text)
                };
                db.khachHangs.Add(kh);
                db.SaveChanges();
                LoadData();
                MessageBox.Show(" thêm mới khách hàng thành công ");


                // after add successfullly, delete data in textbox
                txtMaKh.Text = "";
                txtCustomerName.Text = "";
                txtCustomerPhoneNum.Text = "";
                txtTimes.Text = "";
                radMaleCus.Checked = false;
                radFemaleCus.Checked = false;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!txtCustomerName.Text.Equals("") || !txtMaKh.Text.Equals(""))
            {
                String Makh = txtMaKh.Text;
                khachHang kh = db.khachHangs.Where(p=>p.Ma_kh==Makh).SingleOrDefault();
                kh.Ho_ten = txtCustomerName.Text;
                kh.Gioi_tinh = radMaleCus.Checked ? true : false;
                kh.SDT = txtCustomerPhoneNum.Text;
                kh.Lan_mua = Convert.ToInt32(txtTimes.Text);
                db.SaveChanges();
                LoadData();
            }
            else
            {
                string MaKH = dataGridView1.SelectedCells[0].OwningRow.Cells["Ma_kh"].Value.ToString();
                khachHang kh = db.khachHangs.Find(MaKH);
                kh.Ho_ten = txtCustomerName.Text;
                kh.Gioi_tinh = radMaleCus.Checked ? true : false;
                kh.SDT = txtCustomerPhoneNum.Text;
                kh.Lan_mua = Convert.ToInt32(txtTimes.Text);
                db.SaveChanges();
                LoadData();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            if (index < 0 || index >= dataGridView1.RowCount)
            {
                return;
            }
            // get data in cells of gridView
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string stt = Convert.ToString(dataGridViewRow.Cells[0].Value);
            string id = Convert.ToString(dataGridViewRow.Cells[1].Value);
            string nameCus = Convert.ToString(dataGridViewRow.Cells[2].Value);
            bool sex = Convert.ToBoolean(dataGridViewRow.Cells[4].Value);
            string times = Convert.ToString(dataGridViewRow.Cells[5].Value);
            string phone = Convert.ToString(dataGridViewRow.Cells[3].Value);

            txtMaKh.Text = id;
            txtCustomerName.Text = nameCus;
            txtCustomerPhoneNum.Text = phone;
            txtTimes.Text = times;
            radMaleCus.Checked = sex;
            radFemaleCus.Checked = !sex;

        }

        private void btnDeleteTextBox_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtCustomerPhoneNum.Text = "";
            txtMaKh.Text = "";
            txtTimes.Text = "";
            radMaleCus.Checked=false;
            radMaleCus.Checked = false;
        }
           /*
            * delete data in khachhang and delete data in hoadon which have same Ma_kh
            */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Ma_kh = txtMaKh.Text;
            khachHang kh = db.khachHangs.Where(p => p.Ma_kh == Ma_kh).SingleOrDefault();
            HoaDon hd = db.HoaDons.Where(p => p.Ma_kh == Ma_kh).SingleOrDefault();
            db.khachHangs.Remove(kh);
            db.HoaDons.Remove(hd);
            db.SaveChanges();
            LoadData();

            //after delete , clear data in textbox

            txtCustomerName.Text = "";
            txtCustomerPhoneNum.Text = "";
            txtMaKh.Text = "";
            txtTimes.Text = "";
            radFemaleCus.Checked = false;
            radMaleCus.Checked = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimes_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = false;
            if (txtTimes.Text == "" || !Char.IsDigit(Convert.ToChar(txtTimes.Text)))
            {
                flag = true;
                lbMessage.Text = "Nhập sai định dạng, đã tự động xóa vui lòng nhập số";
                txtTimes.Text = "";
            }
        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach( var userInfo in db.taiKhoans)
            {
                if (userInfo.tenTK == dataAdd)
                {
                    MessageBox.Show("Tên người dùng: " + userInfo.TenNV + "\nChức vụ: " + userInfo.Chuc_vu + "\nTên tài khoản: " + userInfo.tenTK); ;
                }
            }
         
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string nameFind = txtFind.Text;
            Boolean flag = false;
            foreach (var kh in db.khachHangs)
            {
                if (kh.Ho_ten.Equals(nameFind)||kh.SDT.Equals(nameFind))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                var list2 = db.khachHangs.Where(p => p.Ho_ten == nameFind|| p.SDT==nameFind).ToList();
                dataGridView1.DataSource = list2;
            }
            else MessageBox.Show("Không tìm thấy dữ liệu");
        }
    }
}
