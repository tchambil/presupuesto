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
   public  class MetaEspecificoDeGasto_DAL
    {
   

        public bool Insert_MetaEspecificoDeGasto(MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto, SqlTransaction TransControlPresupuestal)
        {
            bool b_MetaEspecifica;
           
            try
            {
                SqlCommand cmdComand = new SqlCommand("USP_I_SICOP_META_ESPECIFICADEGASTO");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = TransControlPresupuestal.Connection;
                cmdComand.Transaction = TransControlPresupuestal;
                cmdComand.Parameters.Clear();

                cmdComand.Parameters.AddWithValue("@META_VCH_IDMETA", pMetaEspecificoDeGasto.META_VCH_IDMETA);
                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pMetaEspecificoDeGasto.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@MEGA_DEC_PIM", pMetaEspecificoDeGasto.MEGA_DEC_PIM);
                cmdComand.Parameters.AddWithValue("@MEGA_VCH_ANIO", pMetaEspecificoDeGasto.MEGA_VCH_ANIO);
                b_MetaEspecifica = cmdComand.ExecuteNonQuery() > 0;
     
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return b_MetaEspecifica;
        }

        public bool Update_MetaEspecificoDeGasto(MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto, SqlTransaction TransControlPresupuestal)
        {
            bool b_MetaEspecifica;

            try
            {
                SqlCommand cmdComand = new SqlCommand("USP_U_SICOP_META_ESPECIFICADEGASTO");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = TransControlPresupuestal.Connection;
                cmdComand.Transaction = TransControlPresupuestal;
                cmdComand.Parameters.Clear();

                cmdComand.Parameters.AddWithValue("@META_VCH_IDMETA", pMetaEspecificoDeGasto.META_VCH_IDMETA);
                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pMetaEspecificoDeGasto.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@MEGA_DEC_PIM", pMetaEspecificoDeGasto.MEGA_DEC_PIM);
                cmdComand.Parameters.AddWithValue("@MEGA_VCH_ANIO", pMetaEspecificoDeGasto.MEGA_VCH_ANIO);
                b_MetaEspecifica = cmdComand.ExecuteNonQuery() > 0;

            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return b_MetaEspecifica;
        }
        
        public DataTable List_MetaEspecificaDeGasto(MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto)
        {
            DataTable mDtMetaEspecificaDeGasto = new DataTable();
            try
            {
                using (SqlConnection sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion))
                {

                    SqlCommand cmdComand = new SqlCommand("USP_S_SICOP_META_ESPECIFICADEGASTO_REPORT", sqlConection);
                    cmdComand.CommandType = CommandType.StoredProcedure;
                    cmdComand.Parameters.AddWithValue("@_META_VCH_IDMETA", pMetaEspecificoDeGasto.META_VCH_IDMETA);
                    cmdComand.Parameters.AddWithValue("@_MEGA_VCH_ANIO", pMetaEspecificoDeGasto.MEGA_VCH_ANIO);
                    sqlConection.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmdComand);
                    da.Fill(mDtMetaEspecificaDeGasto);
                    return mDtMetaEspecificaDeGasto;
                }
            }
            catch (Exception e)
            {
                if (e.Source != null)
                    Console.WriteLine("IOException source: {0}", e.Source);
                throw;
            }
            return mDtMetaEspecificaDeGasto;
        }
    }
}
