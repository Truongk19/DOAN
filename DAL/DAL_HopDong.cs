using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HopDong
    {
        public DataTable GetHopDong()
        {
            string query = $"SP_HienThi_HopDong";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public void add(DTO_HopDong nv)
        {
            string query = $"SP_Them_HopDong  @SoHD , @NgayBatDau , @NgayKetThuc , @NgayKy , @NoiDung , @ThoiHan , @HeSoLuong , @MaNV";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.SoHD,
                nv.NgayBatDau,
                nv.NgayKetThuc,
                nv.NgayKy,
                nv.NoiDung,
                nv.ThoiHan,
                nv.HeSoLuong,
                nv.MANV,
               
            });
        }
        public void update(DTO_HopDong nv)
        {
            string query = $"SP_Sua_HopDong @SoHD , @NgayBatDau , @NgayKetThuc , @NgayKy , @NoiDung , @ThoiHan , @HeSoLuong , @MaNV";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
               nv.SoHD,
                nv.NgayBatDau,
                nv.NgayKetThuc,
                nv.NgayKy,
                nv.NoiDung,
                nv.ThoiHan,
                nv.HeSoLuong,
                nv.MANV,
            });
        }
        public void delete(string sohd)
        {
            string query = $"SP_Xoa_HopDong @SoHD ";
            DBconnect.Instance.ExecuteQuery(query, new object[] { sohd });
        }
        public DataTable Timkiem(string keyword)
        {
            string query = $"SP_Tim_HopDong @key";
            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}
