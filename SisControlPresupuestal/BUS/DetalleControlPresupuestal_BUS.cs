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
    public class DetalleControlPresupuestal_BUS
    {
        public DataTable List_DetalleControlPresupuestal(int inIdControlPresupuestal )
        {
            DataTable mDtDetalleControlPresupuestal = new DataTable();
            try
            {
                mDtDetalleControlPresupuestal = new DetalleControlPresupuestal_DAL().List_DetalleControlPresupuestal(inIdControlPresupuestal);
                   
            }
            catch (Exception ex) { throw ex; }
            return mDtDetalleControlPresupuestal;
        }

    }
}
