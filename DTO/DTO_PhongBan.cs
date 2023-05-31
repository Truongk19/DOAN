using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhongBan
    {
        public string IDPHONGBAN { get; set; }
        public string TENPB { get; set; }

        public DTO_PhongBan() { }

        public DTO_PhongBan(string idPhongban, string tenPB )
        {
            IDPHONGBAN = idPhongban;
            TENPB = tenPB;
            
        }

    }


}
