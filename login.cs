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
    public partial class login : Form
    {
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
            if (username.Text.Contains("admin"))
            {
                ManagerA f = new ManagerA();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if(username.Text.Contains("employee")){ 
                employee employee = new employee();
                this.Hide();
                employee.ShowDialog();
                this.Show();
                 }
            else if( username.Text.Contains("pay"))
            {
                Payment payment = new Payment();
                this.Hide();
                payment.ShowDialog();
                this.Show();
                    }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult= MessageBox.Show("bạn có thật sự muốn thoát ?", "thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
