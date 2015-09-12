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

        //SqlConnection con = new CONEXION_DAL().getConexion();

        public bool Insert_ControlPresupuestal(ControlPresupuestal_VO pControlPresupuestal, SqlTransaction Trans)
        {
            bool b_state;
            try
            {
                 SqlCommand cmdComand = new SqlCommand("USP_A_SICOP_CONTROLPRESUPUESTAL");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = Trans.Connection;
                cmdComand.Transaction = Trans;
                cmdComand.Parameters.Clear();

                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@DOCU_INT_IDDOCUMENTO", pControlPresupuestal.DOCU_INT_IDDOCUMENTO);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAINGRESO", pControlPresupuestal.CPRE_DAT_FECHAINGRESO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NROCOMPROBANTEPAGO", pControlPresupuestal.CPRE_VCH_NROCOMPROBANTEPAGO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NROSIAF", pControlPresupuestal.CPRE_VCH_NROSIAF);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAGIRO", pControlPresupuestal.CPRE_DAT_FECHAGIRO);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAPAGO", pControlPresupuestal.CPRE_DAT_FECHAPAGO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_CONCEPTOESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_CONCEPTOESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_DETALLEESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_DETALLEESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_PARTIDACONTABLE", pControlPresupuestal.CPRE_VCH_PARTIDACONTABLE);
                b_state = cmdComand.ExecuteNonQuery() > 0;
                
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return b_state;
        }
        public bool Update_ControlPresupuestal(ControlPresupuestal_VO pControlPresupuestal, SqlTransaction Trans)
        {
            bool b_state;
            try
            {
              
                SqlCommand cmdComand = new SqlCommand("USP_U_SICOP_CONTROLPRESUPUESTAL");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = Trans.Connection;
                cmdComand.Transaction = Trans;
                cmdComand.Parameters.Clear();
                cmdComand.Parameters.AddWithValue("@CPRE_INT_IDCONTROLPRESUPUESTAL", pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL);
                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@DOCU_INT_IDDOCUMENTO", pControlPresupuestal.DOCU_INT_IDDOCUMENTO);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAINGRESO", pControlPresupuestal.CPRE_DAT_FECHAINGRESO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NROCOMPROBANTEPAGO", pControlPresupuestal.CPRE_VCH_NROCOMPROBANTEPAGO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NROSIAF", pControlPresupuestal.CPRE_VCH_NROSIAF);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAGIRO", pControlPresupuestal.CPRE_DAT_FECHAGIRO);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAPAGO", pControlPresupuestal.CPRE_DAT_FECHAPAGO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_CONCEPTOESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_CONCEPTOESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_DETALLEESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_DETALLEESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_PARTIDACONTABLE", pControlPresupuestal.CPRE_VCH_PARTIDACONTABLE);
                b_state = cmdComand.ExecuteNonQuery() > 0;
                 
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return b_state;
        }
        public DataTable List_ControlPresupuestal()
        {
            DataTable mDtControlPresupuestal = new DataTable();
            try
            {
                using (SqlConnection sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion))
                {
 
                SqlCommand cmdComand = new SqlCommand("USP_S_SICOP_CONTROLPRESUPUESTAL_REPORT", sqlConection);
                cmdComand.CommandType = CommandType.StoredProcedure;
                sqlConection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmdComand);
                da.Fill(mDtControlPresupuestal);
                return mDtControlPresupuestal;
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
            return mDtControlPresupuestal;
        }        
    }
}
