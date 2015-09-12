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
    public class ControlPresupuestal_VO
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
        private int _DOCU_INT_IDDOCUMENTO;

        public int DOCU_INT_IDDOCUMENTO
        {
            get { return _DOCU_INT_IDDOCUMENTO; }
            set { _DOCU_INT_IDDOCUMENTO = value; }
        }

       
        private string _CPRE_VCH_NRODOCUMENTO;

        public string CPRE_VCH_NRODOCUMENTO
        {
            get { return _CPRE_VCH_NRODOCUMENTO; }
            set { _CPRE_VCH_NRODOCUMENTO = value; }
        }
        private DateTime _CPRE_DAT_FECHAINGRESO;

        public DateTime CPRE_DAT_FECHAINGRESO
        {
            get { return _CPRE_DAT_FECHAINGRESO; }
            set { _CPRE_DAT_FECHAINGRESO = value; }
        }
        private string _CPRE_VCH_NROCOMPROBANTEPAGO;

        public string CPRE_VCH_NROCOMPROBANTEPAGO
        {
            get { return _CPRE_VCH_NROCOMPROBANTEPAGO; }
            set { _CPRE_VCH_NROCOMPROBANTEPAGO = value; }
        }
        private string _CPRE_VCH_NROSIAF;

        public string CPRE_VCH_NROSIAF
        {
            get { return _CPRE_VCH_NROSIAF; }
            set { _CPRE_VCH_NROSIAF = value; }
        }
        private DateTime _CPRE_DAT_FECHAGIRO;

        public DateTime CPRE_DAT_FECHAGIRO
        {
            get { return _CPRE_DAT_FECHAGIRO; }
            set { _CPRE_DAT_FECHAGIRO = value; }
        }
        private DateTime _CPRE_DAT_FECHAPAGO;

        public DateTime CPRE_DAT_FECHAPAGO
        {
            get { return _CPRE_DAT_FECHAPAGO; }
            set { _CPRE_DAT_FECHAPAGO = value; }
        }
        private string _CPRE_VCH_CONCEPTOESPECIFICADEGASTO;

        public string CPRE_VCH_CONCEPTOESPECIFICADEGASTO
        {
            get { return _CPRE_VCH_CONCEPTOESPECIFICADEGASTO; }
            set { _CPRE_VCH_CONCEPTOESPECIFICADEGASTO = value; }
        }
        private string _CPRE_VCH_DETALLEESPECIFICADEGASTO;

        public string CPRE_VCH_DETALLEESPECIFICADEGASTO
        {
            get { return _CPRE_VCH_DETALLEESPECIFICADEGASTO; }
            set { _CPRE_VCH_DETALLEESPECIFICADEGASTO = value; }
        }
        private string _CPRE_VCH_PARTIDACONTABLE;
        public string CPRE_VCH_PARTIDACONTABLE
        {
          get { return _CPRE_VCH_PARTIDACONTABLE; }
          set { _CPRE_VCH_PARTIDACONTABLE = value; }
        }
    }
}
