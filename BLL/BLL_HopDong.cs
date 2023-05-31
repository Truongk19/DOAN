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
    public class BLL_HopDong
    {

        DAL_HopDong nv = new DAL_HopDong();
        public DataTable Gethopdong()
        { return nv.GetHopDong(); }


        public void add(DTO_HopDong hopDong)
        {
            nv.add(hopDong);
        }
        public void update(DTO_HopDong hopDong)
        {
            nv.update(hopDong);
        }
        public void delete(string sohb)
        {
            nv.delete(sohb);
        }
        public DataTable timkiem(string key)
        {
            return nv.Timkiem(key);
        }
    }
}
