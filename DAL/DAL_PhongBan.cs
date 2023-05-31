using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_PhongBan
    {
        public DataTable GetPhongBan()
        {
            string query = $"SP_HienThi_PhongBan";
            return DBconnect.Instance.ExecuteQuery(query);
        }

        public void addPhongban(DTO_PhongBan nv)
        {
            string query = $"SP_Them_PhongBan @IPhongBan , @TenPB";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.IDPHONGBAN,
                nv.TENPB,
            });
        }

        public void updatePhongBan(DTO_PhongBan nv)
        {
            string query = $"SP_Sua_PhongBan @IPhongBan , @TenPB ";
            DBconnect.Instance.ExecuteQuery(query, new object[]
            {
                nv.IDPHONGBAN,
                nv.TENPB,
               
            });
        }
        public void deletePhongban(string IDphongban)
        {
            string query = $"SP_Xoa_PhongBan @IPhongBan ";
            DBconnect.Instance.ExecuteQuery(query, new object[] { IDphongban });
        }

        public DataTable Timkiem(string keyword)
        {
            string query = $"SP_Tim_PhongBan @key";
            return DBconnect.Instance.ExecuteQuery(query, new object[] { keyword });
        }
    }
}
