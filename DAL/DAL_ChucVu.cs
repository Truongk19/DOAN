using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ChucVu
    {
        public DataTable GetChucVu()
        {
            string query = $"SP_HienThi_ChucVu";
            return DBconnect.Instance.ExecuteQuery(query);
        }

        public void addChucvu(DTO_ChucVu nv)
        {
            string query = $"SP_Them_ChucVu @IdChucvu , @TenCV ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.IDCHUCVU,
                nv.TENCV,
            });
        }

        public void updateChucvu(DTO_ChucVu nv)
        {
            string query = $"SP_Sua_ChucVu @IdChucvu , @TenCV ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.IDCHUCVU,
                nv.TENCV,

            });
        }
        public void deleteChucvu(string IDchucvu)
        {
            string query = $"SP_Xoa_ChucVu @IdChucvu ";
            DBconnect.Instance.ExecuteQuery(query, new object[] { IDchucvu });
        }

        public DataTable Timkiem(string keyword)
        {
            string query = $"SP_Tim_ChucVu @key";
            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}
