﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHandle;
namespace PhieuThu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBHDataSet.PHIEUTHUFULL' table. You can move, or remove it, as needed.
            this.PHIEUTHUFULLTableAdapter.Fill(this.QLBHDataSet.PHIEUTHUFULL, HandleCLS.tempVal);

            this.reportViewer1.RefreshReport();
        }
    }
}