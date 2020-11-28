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
    
    public partial class Payment : Form
    {
        QLCHDoChoiEntities db = new QLCHDoChoiEntities();
        public Payment()
        {
            InitializeComponent();
        }
        public string dataAdd;
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có thật sự muốn thoát ?", "thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

  
       
     
        /* 
         * load data to combobox
         */

        //List<string> listItem;
        private void btnShowDataBox_Click(object sender, EventArgs e)
        {
            //cách 1 
             serviceManage data = new serviceManage();
             var list = data.getAllDC();
            cbIdproduct.DataSource = list;
            cbIdproduct.DisplayMember = "Ma_sp";

            cbNameProd.DataSource = list;
            cbNameProd.DisplayMember = "Ten_sp";

            cbMoneyNeed.DataSource = list;
            cbMoneyNeed.DisplayMember = "Don_gia";

            cbCost.DataSource = list;
            cbCost.DisplayMember = "Don_gia";

            

            // cách 2 
            /* 
            listItem = new List<string>();
            foreach ( var product in db.doChois)
               {
                   listItem.Add(""+product.Ten_sp+""); 
               }
            comboBox1.DataSource = listItem;
            */
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            khachHang kh = new khachHang()
            {
                Ma_kh = txtIdCus.Text,
                Ho_ten = txtNameCus.Text,
                SDT = txtPhone.Text
            };
            db.khachHangs.Add(kh);
            //db.SaveChanges();

            string txtMoneyNeed = cbMoneyNeed.Text;
            HoaDon hd = new HoaDon()
            {
                
                Ma_kh = txtIdCus.Text,
                Ho_ten = txtNameCus.Text,
                SDT = txtPhone.Text,
                Ma_sp = cbIdproduct.Text,
                So_luong = Convert.ToInt32(txtAmounts.Text),
                Gia_tien = Convert.ToInt32(txtMoneyNeed),
                Tien_khach_tra=Convert.ToInt32(txtCusPay.Text)

            };
            db.HoaDons.Add(hd);
            db.SaveChanges();
            
            /*
             * after add infor of hoaDon, move on QLKH to continue update data of customer
             */
            ManageCustomer manageCustomer = new ManageCustomer();
            this.Hide();
            manageCustomer.ShowDialog();
            this.Show();
        }


        // 3 TRUONGF HOP : NHAP CHU, NHAP CHU VA SO , KHONG NHAP GI CA 
      
        private void txtAmounts_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = false;
            int txtCost = Convert.ToInt32(cbCost.Text);
            if ( txtAmounts.Text == ""||!Char.IsDigit(Convert.ToChar(txtAmounts.Text)) )
            {
                flag = true;
                lbMessage.Text = "Nhập sai định dạng, đã tự động xóa\n vui lòng nhập số";
                txtAmounts.Text = "";
            }
             else  if(!flag)
            {
                lbMessage.Text = "";
                cbMoneyNeed.Text = Convert.ToString(txtCost * Convert.ToInt32(txtAmounts.Text));

            }
            //   else


            // if (!(Convert.ToInt32(txtAmounts.Text)>=1 && Convert.ToInt32(txtAmounts.Text) <= 9999999))
            //else if (txtAmounts.Text == "")
            //{
            //    MessageBox.Show("Giá trị tối thiểu là 1");
            //}

           // else
            //cbMoneyNeed.Text = Convert.ToString(txtCost * Convert.ToInt32(txtAmounts.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var userInfo in db.taiKhoans)
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
    }
}
