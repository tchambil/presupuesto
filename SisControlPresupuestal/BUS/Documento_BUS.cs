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
        public DataTable VerDocumentos()
        {
            return new DADocumento().VerDocumentos();
        }
    }
}
