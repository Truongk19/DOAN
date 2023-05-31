using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        public DataTable Getnhanvien()
        {
            string query = $"SP_HienThi_NhanVien";
            return DBconnect.Instance.ExecuteQuery(query);
        }

        public void addNhanvien(DTO_NhanVien nv)
        {
            string query = $"SP_Them_NhanVien @MANV , @HoTen , @GioiTinh , @NgaySinh , @DienThoai , @CCCD , @DiaChi , @IDphongban , @IDchucvu , @IDtrinhdo ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.MANV,
                nv.HoTen,
                nv.GioiTinh,
                nv.NgaySinh,
                nv.DienThoai,
                nv.CCCD,
                nv.DiaChi,
                nv.IDphongban,
                nv.IDchucvu,
                nv.IDtrinhdo
            });
        }

        public void updateNhanvien(DTO_NhanVien nv)
        {
            string query = $"SP_Sua_NhanVien @MANV , @HoTen , @GioiTinh , @NgaySinh , @DienThoai , @CCCD , @DiaChi , @IDphongban , @IDchucvu , @IDtrinhdo ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
               nv.MANV,
                nv.HoTen,
                nv.GioiTinh,
                nv.NgaySinh,
                nv.DienThoai,
                nv.CCCD,
                nv.DiaChi,
                nv.IDphongban,
                nv.IDchucvu,
                nv.IDtrinhdo
            });
        }
        public void deleteNhanvien(string maNV)
        {
            string query = $"SP_Xoa_NhanVien @MANV ";
            DBconnect.Instance.ExecuteQuery(query,new object[] { maNV });
        }

        public DataTable Timkiem(string keyword)
        {
            string query = $"SP_Tim_NhanVien @key";
            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}
