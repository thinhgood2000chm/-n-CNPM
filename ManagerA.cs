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
    public partial class ManagerA : Form
    {
        public ManagerA()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Account account = new Account();
            account.ShowDialog();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
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

        private void hiểnThịThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.ShowDialog();
        }
    }
}
