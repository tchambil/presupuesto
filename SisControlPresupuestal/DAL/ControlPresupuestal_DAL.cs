﻿using System;
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

        public bool Insert_ControlPresupuestal(ref ControlPresupuestal_VO pControlPresupuestal, SqlTransaction TransControlPresupuestal)
        {
            bool b_ControlPresupuestal;
          
            try
           {
                 SqlCommand cmdComand = new SqlCommand("USP_I_SICOP_CONTROLPRESUPUESTAL");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = TransControlPresupuestal.Connection;
                cmdComand.Transaction = TransControlPresupuestal;
                cmdComand.Parameters.Clear();
                cmdComand.Parameters.AddWithValue("@CPRE_INT_IDCONTROLPRESUPUESTAL", SqlDbType.Int).Value = 0;
                cmdComand.Parameters["@CPRE_INT_IDCONTROLPRESUPUESTAL"].Direction = ParameterDirection.Output;
                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO",pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@DOCU_INT_IDDOCUMENTO", pControlPresupuestal.DOCU_INT_IDDOCUMENTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NRODOCUMENTO", pControlPresupuestal.CPRE_VCH_NRODOCUMENTO);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAINGRESO", pControlPresupuestal.CPRE_DAT_FECHAINGRESO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NROCOMPROBANTEPAGO", pControlPresupuestal.CPRE_VCH_NROCOMPROBANTEPAGO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NROSIAF", pControlPresupuestal.CPRE_VCH_NROSIAF);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAGIRO", pControlPresupuestal.CPRE_DAT_FECHAGIRO);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAPAGO", pControlPresupuestal.CPRE_DAT_FECHAPAGO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_CONCEPTOESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_CONCEPTOESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_DETALLEESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_DETALLEESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_PARTIDACONTABLE", pControlPresupuestal.CPRE_VCH_PARTIDACONTABLE);
                b_ControlPresupuestal = cmdComand.ExecuteNonQuery() > 0;

                if (b_ControlPresupuestal)
                {
                    pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL =Convert.ToInt32( cmdComand.Parameters["@CPRE_INT_IDCONTROLPRESUPUESTAL"].Value);
                }
                
         }
          catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return b_ControlPresupuestal;
        }
        public bool Update_ControlPresupuestal(ControlPresupuestal_VO pControlPresupuestal, SqlTransaction TransControlPresupuestal)
        {
            bool b_ControlPresupuestal;
            try
            {
              
                SqlCommand cmdComand = new SqlCommand("USP_U_SICOP_CONTROLPRESUPUESTAL");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = TransControlPresupuestal.Connection;
                cmdComand.Transaction = TransControlPresupuestal;
                cmdComand.Parameters.Clear();
                cmdComand.Parameters.AddWithValue("@CPRE_INT_IDCONTROLPRESUPUESTAL", pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL);
                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@DOCU_INT_IDDOCUMENTO", pControlPresupuestal.DOCU_INT_IDDOCUMENTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NRODOCUMENTO", pControlPresupuestal.CPRE_VCH_NRODOCUMENTO);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAINGRESO", pControlPresupuestal.CPRE_DAT_FECHAINGRESO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NROCOMPROBANTEPAGO", pControlPresupuestal.CPRE_VCH_NROCOMPROBANTEPAGO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_NROSIAF", pControlPresupuestal.CPRE_VCH_NROSIAF);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAGIRO", pControlPresupuestal.CPRE_DAT_FECHAGIRO);
                cmdComand.Parameters.AddWithValue("@CPRE_DAT_FECHAPAGO", pControlPresupuestal.CPRE_DAT_FECHAPAGO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_CONCEPTOESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_CONCEPTOESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_DETALLEESPECIFICADEGASTO", pControlPresupuestal.CPRE_VCH_DETALLEESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@CPRE_VCH_PARTIDACONTABLE", pControlPresupuestal.CPRE_VCH_PARTIDACONTABLE);
                b_ControlPresupuestal = cmdComand.ExecuteNonQuery() > 0;
                 
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return b_ControlPresupuestal;
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
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return mDtControlPresupuestal;
        }        
    }
}
