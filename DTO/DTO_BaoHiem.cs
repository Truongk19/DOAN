using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BaoHiem
    {
        public string IDbaohiem { get; set; }
        public string SOBH { get; set; }
        public DateTime NgayCap { get; set; }
        public string NoiCap { get; set; }
        public string MANV { get; set; }




        public DTO_BaoHiem() { }
        public DTO_BaoHiem(string idbaohiem,string sobh,DateTime ngaycap,string noicap,string manv)
        {   IDbaohiem   =idbaohiem;
            SOBH        =sobh;
            NgayCap     =ngaycap;
            NoiCap      =noicap;
            MANV       =manv;
        
        
        }
    }       
}
