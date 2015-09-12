using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VO;

namespace VO
{
    public class MetaEspecificoDeGastoModificado_VO
    {
        private int _MEGM_INT_IDMODIFICACION;

        public int MEGM_INT_IDMODIFICACION
        {
            get { return _MEGM_INT_IDMODIFICACION; }
            set { _MEGM_INT_IDMODIFICACION = value; }
        }
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
        private decimal _MEGM_DEC_PIMMODIFICADO;

        public decimal MEGM_DEC_PIMMODIFICADO
        {
            get { return _MEGM_DEC_PIMMODIFICADO; }
            set { _MEGM_DEC_PIMMODIFICADO = value; }
        }
    }
}
