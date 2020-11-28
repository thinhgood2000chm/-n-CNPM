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
    public partial class login : Form
    {
        QLCHDoChoiEntities db = new QLCHDoChoiEntities();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Boolean flag = false; // xet truong hợp nếu đăng nhập được thì đôi thành true
            foreach (var user in db.taiKhoans)
            {
                if (user.tenTK == txtUsername.Text && user.matkhau == txtPassword.Text)
                {
                    if (txtUsername.Text.Contains("admin"))
                    {
                        ManageEmployee manageEmployee = new ManageEmployee();
                        this.Hide();
                        manageEmployee.ShowDialog();
                        this.Show();
                    }
                    else if (txtUsername.Text.Contains("employee"))
                    {
                        ManageCustomer manageCustomer = new ManageCustomer();
                        manageCustomer.dataAdd = txtUsername.Text;
                        this.Hide();
                        manageCustomer.ShowDialog();
                        this.Show();
                    }
                    else if (txtUsername.Text.Contains("pay"))
                    {
                        Payment payment = new Payment();
                        payment.dataAdd = txtUsername.Text;
                        this.Hide();
                        payment.ShowDialog();
                        this.Show();
                    }
                    flag = true;
                    break;
                }

            }
            // nếu không đăng nhập được thì báo lỗi 
            if (!flag)
            {
                txtErrorMess.Text = "Sai tên tài khoản hoặc mật khẩu";
            }
            else if(flag)
            {
                txtErrorMess.Text = "";
            }
            


        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có thật sự muốn thoát ?", "thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
