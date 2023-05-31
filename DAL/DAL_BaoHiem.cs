using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BaoHiem
    {
        public DataTable GetBaoHiem()
        {
            string query = $"SP_HienThi_BaoHiem";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        public void add(DTO_BaoHiem nv)
        {
            string query = $"SP_Them_BaoHiem  @IdBAOHIEM , @SoBH , Ngaycap , @Noicap , @MaNV";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.IDbaohiem,
                nv.SOBH,
                nv.NgayCap,
                nv.NoiCap,
                nv.MANV,
               
            });
        }
        public void update(DTO_BaoHiem nv)
        {
            string query = $"SP_Sua_BaoHiem  @IdBAOHIEM , @SoBH , Ngaycap , @Noicap , @MaNV";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.IDbaohiem,
                nv.SOBH,
                nv.NgayCap,
                nv.NoiCap,
                nv.MANV,

            });
        }
       
        public void delete(string idbh)
        {
            string query = $"SP_Tim_BaoHiem @IDbaohiem ";
            DBconnect.Instance.ExecuteQuery(query, new object[] { idbh });
        }
        public DataTable Timkiem(string keyword)
        {
            string query = $"SP_Tim_HopDong @key";
            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }


    }
}
