using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace QLNS_Pro
{
    public partial class frm_NhanVien : Form
    {
        BLL_NhanVien db = new BLL_NhanVien();
        public frm_NhanVien()
        {
            InitializeComponent();
        }


        private void tsbAdd_Click(object sender, EventArgs e)
        {
            string manv = txtID.Text;
            string hoten = txtNAME.Text;
            string gioitinh = txtGIOITINH.Text;
            DateTime ngaysinh = DateTime.Parse(txtNGAYSINH.Text);
            string dienthoai = txtPHONE.Text;
            string CCCD = txtCCCD.Text;
            string diachi = txtFrom.Text;
            string idphongban = cbPHONGBAN.Text;
            string idchucvu = cbCHUCVU.Text;
            string idtrinhdo = cbTRINHDO.Text;

            DTO_NhanVien nhanvien = new DTO_NhanVien(manv, hoten, gioitinh, ngaysinh, dienthoai, CCCD, diachi, idphongban, idchucvu, idtrinhdo);
            db.addNhanvien(nhanvien);
            frm_NhanVien_Load(sender, e);
            MessageBox.Show("them thanh cong !");

        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            string manv = txtID.Text;
            string hoten = txtNAME.Text;
            string gioitinh = txtGIOITINH.Text;
            DateTime ngaysinh = DateTime.Parse(txtNGAYSINH.Text);
            string dienthoai = txtPHONE.Text;
            string CCCD = txtCCCD.Text;
            string diachi = txtFrom.Text;
            string idphongban = cbPHONGBAN.Text;
            string idchucvu = cbCHUCVU.Text;
            string idtrinhdo = cbTRINHDO.Text;

            DTO_NhanVien nhanvien = new DTO_NhanVien(manv, hoten, gioitinh, ngaysinh, dienthoai, CCCD, diachi, idphongban, idchucvu, idtrinhdo);
            db.updateNhanvienu(nhanvien);
            frm_NhanVien_Load(sender, e);
            MessageBox.Show("sua thanh cong !");

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            string manv = txtID.Text;
            db.deleteNhanvien(manv);
            frm_NhanVien_Load(sender, e);
            MessageBox.Show("xoa thanh cong !");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = db.Getnhanvien();
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text;
            dgvNhanVien.DataSource = db.timkiemNhanvien(keyword);
        }

        private void tsbExcel_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count > 0)
            {
                if (dgvNhanVien.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgvNhanVien.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgvNhanVien.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dgvNhanVien.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvNhanVien.Columns.Count; j++)
                        {
                            if (dgvNhanVien.Rows[i].Cells[j].Value != null)
                            {
                                XcelApp.Cells[i + 2, j + 1] = dgvNhanVien.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                XcelApp.Cells[i + 2, j + 1] = string.Empty; 
                            }
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtID.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtNAME.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtGIOITINH.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtNGAYSINH.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txtPHONE.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txtCCCD.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtFrom.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            cbPHONGBAN.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            cbCHUCVU.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
            cbTRINHDO.Text = dgvNhanVien.Rows[i].Cells[9].Value.ToString();

        }


       
            
        
    }
}
