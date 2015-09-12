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
    public class EspecificoDeGasto_BUS
    {
        private string _EGAS_VCH_IDESPECIFICADEGASTO;

        public string EGAS_VCH_IDESPECIFICADEGASTO
        {
            get { return _EGAS_VCH_IDESPECIFICADEGASTO; }
            set { _EGAS_VCH_IDESPECIFICADEGASTO = value; }
        }

        private string _EGAS_VCH_DESCRIPCION;

        public string EGAS_VCH_DESCRIPCION
        {
            get { return _EGAS_VCH_DESCRIPCION; }
            set { _EGAS_VCH_DESCRIPCION = value; }
        }
       
    }
}
