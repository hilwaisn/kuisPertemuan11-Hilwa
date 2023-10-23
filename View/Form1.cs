using kuisPertemuan11_Hilwa.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kuisPertemuan11_Hilwa
{
    public partial class unasPasim : Form
    {
        private DataController dtController;
        public unasPasim()
        {
            InitializeComponent();
        }
        private void unasPasim_Load(object sender, EventArgs e)
        {
            segarkan();
        }
        private void segarkan()
        {
            dataGridView1.DataSource = dtController.tampilData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 mn = new Form2();
            mn.Show();
            this.Hide();
        }


    }
}
