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
    public class BLL_TrinhDo
    {
        DAL_TrinhDo nv = new DAL_TrinhDo();

        public DataTable GetTrinhdo()
        {
            return nv.GetTrinhDo();
        }

        public void add(DTO_TrinhDo trinhdo)
        {
            nv.addTrinhdo(trinhdo);
        }

        public void update(DTO_TrinhDo trinhdo)
        {
            nv.updateTrinhdo(trinhdo);
        }

        public void delete(string idtd)
        {
            nv.deleteTrinhdo(idtd);
        }

        public DataTable timkiem(string key)
        {
            return nv.Timkiem(key);
        }
    }
}
