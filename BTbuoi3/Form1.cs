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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dgvNV.ColumnCount = 3;
            dgvNV.Columns[0].Name = "MSNV";
            dgvNV.Columns[1].Name = "Tên NV";
            dgvNV.Columns[2].Name = "Lương CB";
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            Form2 employeeForm = new Form2();
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                string[] row = { employeeForm.MSNV, employeeForm.TenNV, employeeForm.LuongCB };
                dgvNV.Rows.Add(row);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (dgvNV.SelectedRows.Count > 0)
            {
                if (dgvNV.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvNV.SelectedRows[0];
                    Form2 employeeForm = new Form2();

                  
                    employeeForm.MSNV = selectedRow.Cells[0].Value.ToString();
                    employeeForm.TenNV = selectedRow.Cells[1].Value.ToString();
                    employeeForm.LuongCB = selectedRow.Cells[2].Value.ToString();

                   
                    if (employeeForm.ShowDialog() == DialogResult.OK)
                    {
                        
                        selectedRow.Cells[0].Value = employeeForm.MSNV;
                        selectedRow.Cells[1].Value = employeeForm.TenNV;
                        selectedRow.Cells[2].Value = employeeForm.LuongCB;
                    }
                }
                else
                {
                    
                    MessageBox.Show("Vui lòng chọn một nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (dgvNV.SelectedRows.Count > 0)
            {
               
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

              
                if (result == DialogResult.Yes)
                {
                    dgvNV.Rows.RemoveAt(dgvNV.SelectedRows[0].Index);
                }
            }
            else
            {
         
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đóng ứng dụng không?",
                "Xác nhận đóng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }

}



