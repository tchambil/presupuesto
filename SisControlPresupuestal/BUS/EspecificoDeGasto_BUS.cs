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
    public class EspecificoDeGasto_BUS
    {
        public DataTable VerEspecificasDeGastos()
        {
            return new DAEspecificoDeGasto().VerEspecificasDeGastos();
        }
        public void AgregarEspecificaDeGasto(VO.EspecificoDeGasto_BUS espec)
        {
            DAEspecificoDeGasto espDAL = new DAEspecificoDeGasto();
            espDAL.AgregarEspecificaDeGasto(espec);
        }
        public void ModificarEspecificaDeGasto(VO.EspecificoDeGasto_BUS espec)
        {
            DAEspecificoDeGasto espDAL = new DAEspecificoDeGasto();
            espDAL.ModificarEspecificaDeGasto(espec);
        }
    }
}
