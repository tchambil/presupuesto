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
    public class MetaEspecificoDeGastoModificado_DAL
    {
        public bool Insert_MetaEspecificoDeGastoMoficado(MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado, SqlTransaction TransControlPresupuestal)
        {
            bool b_MetaEspecifica;

            try
            {
                SqlCommand cmdComand = new SqlCommand("USP_A_SICOP_META_ESPECIFICADEGASTO_MODIFICACIONES");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = TransControlPresupuestal.Connection;
                cmdComand.Transaction = TransControlPresupuestal;
                cmdComand.Parameters.Clear();
                cmdComand.Parameters.AddWithValue("@META_VCH_IDMETA", pMetaEspecificoDeGastoModificado.META_VCH_IDMETA);
                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pMetaEspecificoDeGastoModificado.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@MEGM_DEC_PIMMODIFICADO", pMetaEspecificoDeGastoModificado.MEGM_DEC_PIMMODIFICADO);
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

        public bool Update_MetaEspecificoDeGastoModificado(MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado, SqlTransaction TransControlPresupuestal)
        {
            bool b_MetaEspecifica;

            try
            {
                SqlCommand cmdComand = new SqlCommand("USP_U_SICOP_META_ESPECIFICADEGASTO_MODIFICACIONES");
                cmdComand.CommandType = System.Data.CommandType.StoredProcedure;
                cmdComand.Connection = TransControlPresupuestal.Connection;
                cmdComand.Transaction = TransControlPresupuestal;
                cmdComand.Parameters.Clear();
                cmdComand.Parameters.AddWithValue("@META_VCH_IDMETA", pMetaEspecificoDeGastoModificado.META_VCH_IDMETA);
                cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pMetaEspecificoDeGastoModificado.EGAS_VCH_IDESPECIFICADEGASTO);
                cmdComand.Parameters.AddWithValue("@MEGM_DEC_PIMMODIFICADO", pMetaEspecificoDeGastoModificado.MEGM_DEC_PIMMODIFICADO);
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

                    SqlCommand cmdComand = new SqlCommand("USP_S_SICOP_META_ESPECIFICADEGASTO_MODIFICACIONES", sqlConection);
                    cmdComand.CommandType = CommandType.StoredProcedure;
                    cmdComand.Parameters.AddWithValue("@META_VCH_IDMETA", pMetaEspecificoDeGasto.META_VCH_IDMETA);
                    cmdComand.Parameters.AddWithValue("@EGAS_VCH_IDESPECIFICADEGASTO", pMetaEspecificoDeGasto.EGAS_VCH_IDESPECIFICADEGASTO);
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
