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
        public bool Insert_ControlPresupuestal(ref ControlPresupuestal_VO ControlPresupuestal, DataTable DtDetalleControlPresupuestal)
        {
            SqlConnection Conn = null;
            SqlTransaction Trans = null;
            bool b_state = false;
            try
            {
                Conn = new SqlConnection(BEConexion.vg_strCadenaConexion);
                Conn.Open();
                Trans = Conn.BeginTransaction();
                if (ControlPresupuestal != null)
                {
                    b_state = new ControlPresupuestal_DAL().Insert_ControlPresupuestal(ref ControlPresupuestal, Trans);
                }
                if (b_state)
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
            return b_state;
        }
        public bool Update_ControlPresupuestal(ControlPresupuestal_VO ControlPresupuestal)
        {
            SqlConnection Conn = null;
            SqlTransaction Trans = null;
            bool b_state = false;
            try
            {
                Conn = new SqlConnection(BEConexion.vg_strCadenaConexion);
                Conn.Open();
                Trans = Conn.BeginTransaction();
                if (ControlPresupuestal != null)
                {
                    b_state = new ControlPresupuestal_DAL().Update_ControlPresupuestal(ControlPresupuestal, Trans);
                }
                if (b_state)
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
            return b_state;
        }


        public DataTable List_ControlPresupuestal()
        {
            DataTable mDtControlPresupuestal = new DataTable();
            try
            {
                mDtControlPresupuestal = new ControlPresupuestal_DAL().List_ControlPresupuestal();
            }
            catch (Exception ex) { throw ex; }
            return mDtControlPresupuestal;
        }
        //public DataTable BusquedaDeDatosDePlanilla(string busqueda)
        //{
        //    DevengadosDAL datosDAL = new DevengadosDAL();
        //    DataTable dt = datosDAL.BusquedaDeDatosDePlanilla(busqueda);
        //    return dt;
        //}
    }
}
