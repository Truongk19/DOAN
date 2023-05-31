using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_TrinhDo
    {

        public DataTable GetTrinhDo()
        {
            string query = $"SP_HienThi_TrinhDo";
            return DBconnect.Instance.ExecuteQuery(query);
        }
        
        public void addTrinhdo(DTO_TrinhDo nv)
        {
            string query = $"SP_Them_TrinhDo @IdTrinhDo , @TenTrinhdo ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.IDTRINHDO,
                nv.TENTRINHDO,
              
            });
        }

        public void updateTrinhdo(DTO_TrinhDo nv)
        {
            string query = $"SP_Sua_TrinhDo @IdTrinhDo , @TenTrinhdo ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                 nv.IDTRINHDO,
                nv.TENTRINHDO,

            });
        }
        public void deleteTrinhdo(string idTrinhDo)
        {
            string query = $"SP_Xoa_TrinhDo @IdTrinhDo ";
            DBconnect.Instance.ExecuteQuery(query, new object[] { idTrinhDo });
        }

        public DataTable Timkiem(string keyword)
        {
            string query = $"SP_Tim_TrinhDo @key";
            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}
