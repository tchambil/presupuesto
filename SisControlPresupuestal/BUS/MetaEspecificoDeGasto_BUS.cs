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
    public class MetaEspecificoDeGasto_BUS
    {
        public void AgregarMetaEspecificaDeGasto(MetaEspecificoDeGasto_VO metespec)
        {
            DAMetaEspecificoDeGasto metespDAL = new DAMetaEspecificoDeGasto();
            metespDAL.AgregarMetaEspecificaDeGasto(metespec);
        }
        public DataTable BusquedaDeMetaEspecificaDeGasto(string META_VCH_IDMETA)
        {
            return new DAMetaEspecificoDeGasto().BusquedaDeMetaEspecificaDeGasto(META_VCH_IDMETA);
        }
    }
}
