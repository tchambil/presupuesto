using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VO;

namespace DAL
{
    public class ControlPresupuestal_DAL
    {

        SqlConnection con = new CONEXION_DAL().getConexion();

        public bool Insert_ControlPresupuestal(ControlPresupuestal_VO pControlPresupuestal, SqlTransaction Trans)
        {
            bool flag;
            try
            {
                 SqlCommand cmd = new SqlCommand("USP_A_SICOP_CONTROLPRESUPUESTAL");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = Trans.Connection;
                cmd.Transaction = Trans;
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO);
                cmd.Parameters.AddWithValue("@DOCU_INT_IDDOCUMENTO", pControlPresupuestal.DOCU_INT_IDDOCUMENTO);
                cmd.Parameters.AddWithValue("@CPRE_DAT_FECHAINGRESO", pControlPresupuestal.CPRE_DAT_FECHAINGRESO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_NROCOMPROBANTEPAGO", pControlPresupuestal.CPRE_VCH_NROCOMPROBANTEPAGO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_NROSIAF", pControlPresupuestal.CPRE_VCH_NROSIAF);
                cmd.Parameters.AddWithValue("@CPRE_DAT_FECHAGIRO", pControlPresupuestal.CPRE_DAT_FECHAGIRO);
                cmd.Parameters.AddWithValue("@CPRE_DAT_FECHAPAGO", pControlPresupuestal.CPRE_DAT_FECHAPAGO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_CONCEPTOESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_CONCEPTOESPECIFICADEGASTO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_DETALLEESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_DETALLEESPECIFICADEGASTO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_PARTIDACONTABLE", pControlPresupuestal.CPRE_VCH_PARTIDACONTABLE);
                flag = cmd.ExecuteNonQuery() > 0;
                con.Close();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return flag;
        }
        public bool Update_ControlPresupuestal(ControlPresupuestal_VO pControlPresupuestal, SqlTransaction Trans)
        {
            bool flag;
            try
            {
              
                SqlCommand cmd = new SqlCommand("USP_U_SICOP_CONTROLPRESUPUESTAL");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = Trans.Connection;
                cmd.Transaction = Trans;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CPRE_INT_IDCONTROLPRESUPUESTAL", pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL);
                cmd.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO);
                cmd.Parameters.AddWithValue("@DOCU_INT_IDDOCUMENTO", pControlPresupuestal.DOCU_INT_IDDOCUMENTO);
                cmd.Parameters.AddWithValue("@CPRE_DAT_FECHAINGRESO", pControlPresupuestal.CPRE_DAT_FECHAINGRESO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_NROCOMPROBANTEPAGO", pControlPresupuestal.CPRE_VCH_NROCOMPROBANTEPAGO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_NROSIAF", pControlPresupuestal.CPRE_VCH_NROSIAF);
                cmd.Parameters.AddWithValue("@CPRE_DAT_FECHAGIRO", pControlPresupuestal.CPRE_DAT_FECHAGIRO);
                cmd.Parameters.AddWithValue("@CPRE_DAT_FECHAPAGO", pControlPresupuestal.CPRE_DAT_FECHAPAGO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_CONCEPTOESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_CONCEPTOESPECIFICADEGASTO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_DETALLEESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_DETALLEESPECIFICADEGASTO);
                cmd.Parameters.AddWithValue("@CPRE_VCH_PARTIDACONTABLE", pControlPresupuestal.CPRE_VCH_PARTIDACONTABLE);
                flag = cmd.ExecuteNonQuery() > 0;
                 
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return flag;
        }
        public DataTable VerControlPresupuestal()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection Conn = new SqlConnection(BEConexion.cadenaconexion))
                {
 
                SqlCommand cmd = new SqlCommand("USP_S_SICOP_CONTROLPRESUPUESTAL_REPORT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return dt;
        }

        //public DataTable BusquedaDeDatosDePlanilla(string busqueda)
        //{
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("SPR_BusquedaDeDatosDePlanilla", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@busqueda", busqueda);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    con.Close();
        //    return dt;
        //}   
    }
}
