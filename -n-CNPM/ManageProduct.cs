using System;
using System.Collections;
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
    public partial class ManageProduct : Form
    {
        QLCHDoChoiEntities db = new QLCHDoChoiEntities();
        public ManageProduct()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            serviceManage data = new serviceManage();
            var list = data.getAllDC();
            dataGridView1.DataSource = list;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có thật sự muốn thoát ?", "thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
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
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string stt = Convert.ToString(dataGridViewRow.Cells[0].Value);
            string maSp = (Convert.ToString(dataGridViewRow.Cells[1].Value));
            string tenSp = Convert.ToString(dataGridViewRow.Cells[2].Value);
            string nsx = Convert.ToString(dataGridViewRow.Cells[3].Value);
            string donGia = Convert.ToString(dataGridViewRow.Cells[4].Value);
            string loaiDc = Convert.ToString(dataGridViewRow.Cells[5].Value);

            // upload to textbox
            txtStt.Text = stt;
            txtMaSp.Text = maSp;
            txtNameProduct.Text = tenSp;
            txtProducer.Text = nsx;
            cbSpicesToy.Text = loaiDc;
            txtCost.Text = donGia;

            if (txtStt.Text == "")
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

        // ham xoa du lieu trne textbox
        public void ClearData()
        {
            txtMaSp.Text = "";
            txtNameProduct.Text = "";
            txtCost.Text = "";
            txtProducer.Text = "";
            cbSpicesToy.Text = "";
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnChange.Enabled = true;
        }
  

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        // chuc nang them 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ( txtNameProduct.Text == "" || txtProducer.Text == "" || txtCost.Text == "" || cbSpicesToy.Text=="")
            {
                MessageBox.Show("Bị thiếu thông tin vui lòng nhập lại");
            }
            else
            {
                ArrayList temp = new ArrayList();
                foreach (var product in db.doChois)
                {

                    temp.Add(Convert.ToInt32(product.stt));
                }

                doChoi dc = new doChoi()
                {
                    Ma_sp ="sp"+ Convert.ToString(temp.Count + 1),
                    Ten_sp = txtNameProduct.Text,
                    Nsx = txtProducer.Text,
                    Don_gia = Convert.ToInt32(txtCost.Text),
                    Loai_do_choi = cbSpicesToy.Text
                };
                db.doChois.Add(dc);
                db.SaveChanges();
                MessageBox.Show("thêm đồ chơi thành công");
                LoadData();

                // after add successfullly, delete data in textbox
                ClearData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn có chắc muốn thoát","thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            this.Close();
        }
        // chuc nang chinh sua 
        private void btnChange_Click(object sender, EventArgs e)
        { 
            string maSp = dataGridView1.SelectedCells[0].OwningRow.Cells["Ma_sp"].Value.ToString();
            doChoi dc = db.doChois.Find(maSp);
            //dc.Ma_sp = txtMaSp.Text;
            dc.Ten_sp = txtNameProduct.Text;
            dc.Nsx = txtProducer.Text;
            dc.Loai_do_choi = cbSpicesToy.Text;
            dc.Don_gia = Convert.ToInt32(txtCost.Text);
            db.SaveChanges();
            LoadData();
            MessageBox.Show("sửa dữ liệu thành công ");

        }

        private void btnDeleteTextbox_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        // chuc nang xoa 
        private void btnDelete_Click(object sender, EventArgs e)
        {
           int stt =Convert.ToInt32(txtStt.Text);
            doChoi dc = db.doChois.Where(p => p.stt == stt).SingleOrDefault();
            db.doChois.Remove(dc);
            db.SaveChanges();
            LoadData();

            txtStt.Text = "";
            txtMaSp.Text = "";
            txtNameProduct.Text = "";
            txtProducer.Text = "";
            txtNameProduct.Text = "";
            cbSpicesToy.Text = "";
            txtCost.Text = "";
        }

        private void cbSpicesToy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        // chưc nang tìm kiem 
        private void btnFind_Click(object sender, EventArgs e)
        {
            string nameFind = txtFind.Text;
            Boolean flag = false;
            foreach (var dc in db.doChois)
            {
                if (dc.Ten_sp.Equals(nameFind))
                {
                    flag = true;
                }
            }
            if (flag)
            {
                var list2 = db.doChois.Where(p => p.Ten_sp == nameFind).ToList();
                dataGridView1.DataSource = list2;
            }
            else  MessageBox.Show("Không tìm thấy dữ liệu");
        }

        private void txtMaSp_TextChanged(object sender, EventArgs e)
        {
     
        }
        // thiet lap enable nút bam 
        private void txtNameProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSp.Text.Equals(""))
            {
                btnAdd.Enabled = true;
                btnChange.Enabled = false;
                btnDelete.Enabled = false;

            }
        }
    }
}
