﻿using System;
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
    public partial class DataAngsuran : Form
    {
        public DataAngsuran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahAngsuran tambahAngsuran = new TambahAngsuran();   
        }
    }
}
