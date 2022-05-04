using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataHandle;
namespace PhieuThu
{
    public partial class Form1 : Form
    {
        SqlConnection conn = HandleCLS.conn(".", "QLBH"); 
        public Form1()
        {
            InitializeComponent();
        }
        public void activeDataSQL()
        {
            DataTable dt = HandleCLS.selectData("PHIEU_XUAT", conn);
            cb_phieuxuat.DataSource = dt;
            cb_phieuxuat.DisplayMember = "SoPX";
            cb_phieuxuat.ValueMember = "SoPX";
            txt_phaitra.DataBindings.Clear();
            txt_datra.DataBindings.Clear();
            txt_conno.DataBindings.Clear();
            txt_phaitra.DataBindings.Add("Text", dt, "SoTienPhaiTra");
            txt_datra.DataBindings.Add("Text", dt, "SoTienDaTra");
            txt_conno.DataBindings.Add("Text", dt, "SoTienConLai");

            string soCT = "CT" + Convert.ToInt32(HandleCLS.selectData("PHIEU_THU", conn).Rows.Count + 1);
            txt_sct.Text = soCT;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            activeDataSQL();
        }

        private void txt_sotien_TextChanged(object sender, EventArgs e)
        {
            if (txt_sotien.Text == "")
            {
                txt_sotien.Text = "0";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cb_phieuxuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private string magicDate(string date)
        {
            string[] arr = date.Split('/');
            Array.Reverse(arr);
            return String.Join("-", arr);
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            Dictionary<string,object> dataIn = new Dictionary<string,object>();
            dataIn.Add("SoCT", txt_sct.Text);
            dataIn.Add("NgayCT", magicDate(dateTimePicker1.Text));
            dataIn.Add("SoTien", txt_sotien.Text);
            dataIn.Add("DienGiai", txt_diengiai.Text);
            dataIn.Add("SoPX", cb_phieuxuat.Text);
            if (HandleCLS.insertData("PHIEU_THU", dataIn, conn))
            {
                MessageBox.Show("Lưu thành công");
            }
            else MessageBox.Show("Hổng được òi");
           // MessageBox.Show(HandleCLS.insertData("PHIEU_THU", dataIn, conn));
        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            activeDataSQL();
            txt_sotien.Text = "0";
            txt_diengiai.Text = "";
        }
    }
}
