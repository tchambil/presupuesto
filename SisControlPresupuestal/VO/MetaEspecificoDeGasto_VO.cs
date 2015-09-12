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
    public class MetaEspecificoDeGasto_VO
    {
        private string _META_VCH_IDMETA;

        public string META_VCH_IDMETA
        {
            get { return _META_VCH_IDMETA; }
            set { _META_VCH_IDMETA = value; }
        }
        private string _EGAS_VCH_IDESPECIFICADEGASTO;

        public string EGAS_VCH_IDESPECIFICADEGASTO
        {
            get { return _EGAS_VCH_IDESPECIFICADEGASTO; }
            set { _EGAS_VCH_IDESPECIFICADEGASTO = value; }
        }
        private decimal _MEGA_DEC_PIM;

        public decimal MEGA_DEC_PIM
        {
            get { return _MEGA_DEC_PIM; }
            set { _MEGA_DEC_PIM = value; }
        }
        private string _MEGA_VCH_ANIO;

        public string MEGA_VCH_ANIO
        {
            get { return _MEGA_VCH_ANIO; }
            set { _MEGA_VCH_ANIO = value; }
        }
    }
}
