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
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaSp.Text =="" || txtNameProduct.Text == "" || txtProducer.Text == "" || txtCost.Text == "" || cbSpicesToy.Text=="")
            {
                MessageBox.Show("Bị thiếu thông tin vui lòng nhập lại");
            }
            else
            {

                doChoi dc = new doChoi()
                {
                    Ma_sp = txtMaSp.Text,
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
                txtMaSp.Text = "";
                txtNameProduct.Text = "";
                txtCost.Text = "";
                txtProducer.Text = "";
                cbSpicesToy.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn có chắc muốn thoát","thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            this.Close();
        }

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
            txtStt.Text = "";
            txtMaSp.Text = "";
            txtNameProduct.Text = "";
            txtProducer.Text = "";
            txtNameProduct.Text = "";
            cbSpicesToy.Text = "";
            txtCost.Text = "";

        }

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
    }
}
