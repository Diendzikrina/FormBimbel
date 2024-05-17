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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MasterData form4 = new MasterData();
                form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            JadwalPelajaran form10 = new JadwalPelajaran();
                form10.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnggotaBimbel form11 = new AnggotaBimbel();
                form11.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            DataAngsuran form12 = new DataAngsuran();   
                form12.ShowDialog();
        }
    }
}
