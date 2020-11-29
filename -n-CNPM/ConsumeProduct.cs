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
    public partial class ConsumeProduct : Form
    {
        QLCHDoChoiEntities db = new QLCHDoChoiEntities();

        public ConsumeProduct()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsumeProduct_Load(object sender, EventArgs e)
        {
            serviceManage data = new serviceManage();
            var list = data.getAllConsumeP();
            dataGridView1.DataSource = list;
        }
    }
}
