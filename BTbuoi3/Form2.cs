using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTbuoi3
{
    public partial class Form2 : Form
    {
      
        public Form2()
        {
            InitializeComponent();
        }

        public string MSNV
        {
            get { return txtMSNV.Text; }
            set { txtMSNV.Text = value; }
        }

        public string TenNV
        {
            get { return txtTenNv.Text; }
            set { txtTenNv.Text = value; }
        }

        public string LuongCB
        {
            get { return txtLCB.Text; }
            set { txtLCB.Text = value; }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(MSNV) || string.IsNullOrEmpty(TenNV) || string.IsNullOrEmpty(LuongCB))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

