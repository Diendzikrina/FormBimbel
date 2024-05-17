using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM_DATA_BARU
{
    public partial class DashboardSiswa : Form
    {
        public DashboardSiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TambahAngsuran tambahAngsuran = new TambahAngsuran();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            JadwalPaten jadwalPaten = new JadwalPaten();    
        
        }
    }
}
