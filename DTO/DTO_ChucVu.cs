using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChucVu
    {

        public string IDCHUCVU { get; set; }
        public string TENCV { get; set; }

        public DTO_ChucVu() { }

        public DTO_ChucVu(string idChucvu, string tenCV)
        {
            IDCHUCVU = idChucvu;
            TENCV = tenCV;

        }

    }
}
