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
        public void AgregarDetalleControlPresupuestal(DetalleControlPresupuestal_VO dev)
        {
            DADetalleControlPresupuestal devDAL = new DADetalleControlPresupuestal();
            devDAL.AgregarDetalleControlPresupuestal(dev);
        }
      
    }
}
