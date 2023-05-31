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
    public class BLL_ChucVu
    {
        DAL_ChucVu nv = new DAL_ChucVu();

        public DataTable GetChucvu()
        {
            return nv.GetChucVu();
        }

        public void add(DTO_ChucVu chucvu)
        {
            nv.addChucvu(chucvu);
        }

        public void update(DTO_ChucVu chucvu)
        {
            nv.updateChucvu(chucvu);
        }

        public void delete(string idcv)
        {
            nv.deleteChucvu(idcv);
        }

        public DataTable timkiem(string key)
        {
            return nv.Timkiem(key);
        }
    }
}
