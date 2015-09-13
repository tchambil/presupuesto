using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;
using System.Data.SqlClient;
namespace BUS
{
    public class EspecificoDeGasto_BUS
    {
        public DataTable getEspecificasDeGastos()
        {
            DataTable mDtEspecificoDeGasto = new DataTable();
            try
            {
                mDtEspecificoDeGasto = new DAEspecificoDeGasto().getEspecificasDeGastos();
            }
            catch (Exception ex) { throw ex; }
            return mDtEspecificoDeGasto;
             
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
