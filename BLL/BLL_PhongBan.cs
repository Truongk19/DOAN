using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PhongBan
    {
        DAL_PhongBan nv = new DAL_PhongBan();

        public DataTable GetPhongBan()
        {
            return nv.GetPhongBan();
        }

        public void add(DTO_PhongBan phongban)
        {
            nv.addPhongban(phongban);
        }

        public void update(DTO_PhongBan phongban)
        {
            nv.updatePhongBan(phongban);
        }

        public void delete(string idpb)
        {
            nv.deletePhongban(idpb);
        }

        public DataTable timkiem(string key)
        {
            return nv.Timkiem(key);
        }
    }
}
