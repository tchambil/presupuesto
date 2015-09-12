using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;
using System.Data;

namespace BUS
{
    public class Meta_BUS
    {
        public DataTable VerMetas()
        {
            return new DAMeta().VerMetas();
        }
      
    }
}
