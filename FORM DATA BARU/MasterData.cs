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
    public partial class MasterData : Form
    {
        public MasterData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataAdmin dataAdmin = new DataAdmin();
                dataAdmin.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            DataGuru dataGuru = new DataGuru(); 
                dataGuru.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DataSiswa dataSiswa = new DataSiswa();
                dataSiswa.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            DataKelas dataKelas = new DataKelas();  
                dataKelas.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            DataPaketBimbel dataPaketBimbel = new DataPaketBimbel();
                dataPaketBimbel.Show(this);
            
        }
    }
}
