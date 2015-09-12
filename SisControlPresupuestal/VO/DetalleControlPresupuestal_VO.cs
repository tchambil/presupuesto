using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace VO
{
    public class DetalleControlPresupuestal_VO
    {
        private int _CPRE_INT_IDCONTROLPRESUPUESTAL;

        public int CPRE_INT_IDCONTROLPRESUPUESTAL
        {
            get { return _CPRE_INT_IDCONTROLPRESUPUESTAL; }
            set { _CPRE_INT_IDCONTROLPRESUPUESTAL = value; }
        }

        private string _EGAS_VCH_IDESPECIFICADEGASTO;

        public string EGAS_VCH_IDESPECIFICADEGASTO
        {
            get { return _EGAS_VCH_IDESPECIFICADEGASTO; }
            set { _EGAS_VCH_IDESPECIFICADEGASTO = value; }
        }
        private string _META_VCH_IDMETA;

        public string META_VCH_IDMETA
        {
            get { return _META_VCH_IDMETA; }
            set { _META_VCH_IDMETA = value; }
        }
        private decimal _DCPR_DEC_IMPORTE;

        public decimal DCPR_DEC_IMPORTE
        {
            get { return _DCPR_DEC_IMPORTE; }
            set { _DCPR_DEC_IMPORTE = value; }
        }
    }
}
