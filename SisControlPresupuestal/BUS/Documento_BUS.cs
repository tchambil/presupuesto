using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BUS
{
    public class Documento_BUS
    {
        public DataTable getDocumento()
        {
            

            DataTable mDtDocumento = new DataTable();
            try
            {
                mDtDocumento = new DADocumento().getDocumento();
            }
            catch (Exception ex) { throw ex; }
            return mDtDocumento;
        }
    }
}
