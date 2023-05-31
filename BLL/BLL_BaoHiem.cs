using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class BLL_BaoHiem
    {
        DAL_BaoHiem nv = new DAL_BaoHiem();
        public DataTable GetBaoHiem()
            { return nv.GetBaoHiem(); }


        public void addBaohiem(DTO_BaoHiem baohiem)
        {
            nv.add(baohiem);
        }
        public void update(DTO_BaoHiem baohiem)
        {
            nv.update(baohiem);
        }
        public void delete(string idbh)
        {
            nv.delete(idbh);
        }
        public DataTable timkiem(string key)
        {
            return nv.Timkiem(key);
        }
    }
}
