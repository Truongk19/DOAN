using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HopDong
    {

        public string SoHD { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime  NgayKetThuc { get; set; }
        public DateTime NgayKy { get; set; }
        public string NoiDung { get; set; }
        public string ThoiHan { get; set; }
        public float HeSoLuong  { get; set; }
        public string MANV { get; set; }


        public DTO_HopDong() { }

        public DTO_HopDong(string sobh, DateTime ngaybatdau,DateTime ngayketthuc,DateTime ngayky,string noidung,string thoihan,float hesoluong,string manv) 
        {
            SoHD = sobh;
            NgayBatDau = ngaybatdau;
            NgayKetThuc = ngayketthuc;
            NgayKy = ngayky;
            NoiDung = noidung;
            ThoiHan = thoihan;
            HeSoLuong=hesoluong;
            MANV = manv;

        }



    }
}
