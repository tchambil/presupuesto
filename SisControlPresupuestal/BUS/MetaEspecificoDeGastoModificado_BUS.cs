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
    public class MetaEspecificoDeGastoModificado_BUS
    {
        public void AgregarMetaEspecificaDeGastoModificaciones(MetaEspecificoDeGastoModificado_VO mem)
        {
            DAMetaEspecificoDeGastoModificado memDAL = new DAMetaEspecificoDeGastoModificado();
            memDAL.AgregarMetaEspecificaDeGastoModificaciones(mem);
        }
    }
}
