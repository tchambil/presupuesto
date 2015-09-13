using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DetalleControlPresupuestal_DAL
    {

 

        public bool Insert_DetalleControlPresupuestal(DetalleControlPresupuestal_VO pDetalleControlPresupuestal, SqlTransaction TransDetalleControlPresupuestal)
        {
        
            bool b_DetalleControlPresupuestal;
            try
            { 
                SqlCommand cmdComand = new SqlCommand("USP_A_SICOP_DETALLECONTROLPRESUPUESTAL");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = TransDetalleControlPresupuestal.Connection;
                cmdComand.Transaction = TransDetalleControlPresupuestal;
                cmdComand.Parameters.Clear();
                cmdComand.Parameters.AddWithValue("@CPRE_INT_IDCONTROLPRESUPUESTAL", pDetalleControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL);
                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pDetalleControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@META_VCH_IDMETA", pDetalleControlPresupuestal.META_VCH_IDMETA);
                cmdComand.Parameters.AddWithValue("@DCPR_DEC_IMPORTE", pDetalleControlPresupuestal.DCPR_DEC_IMPORTE);
                b_DetalleControlPresupuestal = cmdComand.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return b_DetalleControlPresupuestal;
        }
        public bool Delete_DetalleControlPresupuestal(ControlPresupuestal_VO pControlPresupuestal, SqlTransaction TransDetalleControlPresupuestal)
        {

            bool b_DetalleControlPresupuestal;
            try
            {
                SqlCommand cmdComand = new SqlCommand("USP_D_SICOP_DETALLECONTROLPRESUPUESTAL");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = TransDetalleControlPresupuestal.Connection;
                cmdComand.Transaction = TransDetalleControlPresupuestal;
                cmdComand.Parameters.Clear();
                cmdComand.Parameters.AddWithValue("@CPRE_INT_IDCONTROLPRESUPUESTAL", pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL); 
                b_DetalleControlPresupuestal = cmdComand.ExecuteNonQuery() > 0;
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return b_DetalleControlPresupuestal;
        }
        public DataTable List_DetalleControlPresupuestal(int inIdControlPresupuestal)
        {
            DataTable mDtDetalleControlPresupuestal = new DataTable();
            try
            {
                using (SqlConnection sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion))
                {

                    SqlCommand cmdComand = new SqlCommand("USP_S_SICOP_DETALLECONTROLPRESUPUESTAL", sqlConection);
                    cmdComand.CommandType = CommandType.StoredProcedure;
                    cmdComand.Parameters.AddWithValue("@CPRE_INT_IDCONTROLPRESUPUESTAL", inIdControlPresupuestal);
                    sqlConection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmdComand);
                    da.Fill(mDtDetalleControlPresupuestal);
                    return mDtDetalleControlPresupuestal;
                }
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return mDtDetalleControlPresupuestal;
        }
    }
}
