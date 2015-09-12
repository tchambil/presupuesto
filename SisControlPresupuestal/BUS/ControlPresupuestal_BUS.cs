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
    public class ControlPresupuestal_BUS
    {
        public bool Insert_ControlPresupuestal(ControlPresupuestal_VO ControlPresupuestal)
        {
            SqlConnection Conn = null;
            SqlTransaction Trans = null;
            bool flag = false;
            try
            {
                Conn = new SqlConnection(BEConexion.cadenaconexion);
                Conn.Open();
                Trans = Conn.BeginTransaction();
                if (ControlPresupuestal != null)
                {
                    flag = new ControlPresupuestal_DAL().Insert_ControlPresupuestal(ControlPresupuestal, Trans);
                }
                if (flag)
                {
                    Trans.Commit();

                }
                else
                {
                    Trans.Rollback();
                }
            }

            catch (Exception exception)
            {
                if (Trans != null)
                    Trans.Rollback();
                return false;
            }
            finally {
                if (Conn != null)
                {
                    Conn.Close();
                }
                Conn.Dispose();

            }
            return flag;
        }
        public bool Update_ControlPresupuestal(ControlPresupuestal_VO ControlPresupuestal)
        {
            SqlConnection Conn = null;
            SqlTransaction Trans = null;
            bool flag = false;
            try
            {
                Conn = new SqlConnection(BEConexion.cadenaconexion);
                Conn.Open();
                Trans = Conn.BeginTransaction();
                if (ControlPresupuestal != null)
                {
                    flag = new ControlPresupuestal_DAL().Update_ControlPresupuestal(ControlPresupuestal, Trans);
                }
                if (flag)
                {
                    Trans.Commit();

                }
                else
                {
                    Trans.Rollback();
                }
            }

            catch (Exception exception)
            {
                if (Trans != null)
                    Trans.Rollback();
                return false;
            }
            finally
            {
                if (Conn != null)
                {
                    Conn.Close();
                }
                Conn.Dispose();

            }
            return flag;
        }

    } 

        //public DataTable BusquedaDeDatosDePlanilla(string busqueda)
        //{
        //    DevengadosDAL datosDAL = new DevengadosDAL();
        //    DataTable dt = datosDAL.BusquedaDeDatosDePlanilla(busqueda);
        //    return dt;
        //}
    
}
