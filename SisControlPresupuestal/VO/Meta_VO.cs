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
    public class Meta_VO


    {
        private string _META_VCH_IDMETA;

        public string META_VCH_IDMETA
        {
            get { return _META_VCH_IDMETA; }
            set { _META_VCH_IDMETA = value; }
        }
        private string _META_VCH_DESCRIPCION;

        public string META_VCH_DESCRIPCION
        {
            get { return _META_VCH_DESCRIPCION; }
            set { _META_VCH_DESCRIPCION = value; }
        }
    }
}
