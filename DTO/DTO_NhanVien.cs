using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace DTO
{
    public class DTO_NhanVien
    {
        public string MANV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public string IDphongban { get; set; }
        public string IDchucvu { get; set; }
        public string IDtrinhdo { get; set; }

        public DTO_NhanVien() { }
        public DTO_NhanVien(string mANV, string hoTen, string gioiTinh, DateTime ngaySinh, string dienThoai, string cCCD, string diaChi, string iDphongban, string iDchucvu, string iDtrinhdo)
        {
            MANV = mANV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DienThoai = dienThoai;
            CCCD = cCCD;
            DiaChi = diaChi;
            IDphongban = iDphongban;
            IDchucvu = iDchucvu;
            IDtrinhdo = iDtrinhdo;
        }
    }
}
