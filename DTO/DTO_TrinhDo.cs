using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TrinhDo
    {

        public string IDTRINHDO { get; set; }
        public string TENTRINHDO{ get; set; }

        public DTO_TrinhDo() { }

        public DTO_TrinhDo(string idTrinhdo, string tenTrinhdo)
        {
            IDTRINHDO = idTrinhdo;
            TENTRINHDO = tenTrinhdo;

        }
    }
}
