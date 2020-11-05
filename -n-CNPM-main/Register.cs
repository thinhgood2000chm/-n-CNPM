using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class Register : Form
    {
        QLCHDCEntities db = new QLCHDCEntities();
        public Register()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có thật sự muốn thoát ?", "thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            taiKhoan createAcc = new taiKhoan()
            {
                TenNV = txtNameEmp.Text,
                Chuc_vu = txtPosition.Text,
                tenTK = txtUsername.Text,
                matkhau = txtPassword.Text,
            };
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                db.taiKhoans.Add(createAcc);
                db.SaveChanges();
                MessageBox.Show("Đăng kí tài khoan thành công");
                txtNameEmp.Text = "";
                txtPosition.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
            }
            else MessageBox.Show("mật khẩu không khớp");
        }
    }
}
