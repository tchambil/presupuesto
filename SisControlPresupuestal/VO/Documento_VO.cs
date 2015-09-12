using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VO;

namespace VO
{
    public class Documento_VO
    {
        private int _DOCU_INT_IDDOCUMENTO;

        public int DOCU_INT_IDDOCUMENTO
        {
            get { return _DOCU_INT_IDDOCUMENTO; }
            set { _DOCU_INT_IDDOCUMENTO = value; }
        }


        private string _DOCU_VCH_NOMBRE;

        public string DOCU_VCH_NOMBRE
        {
            get { return _DOCU_VCH_NOMBRE; }
            set { _DOCU_VCH_NOMBRE = value; }
        }

       
    }
}
