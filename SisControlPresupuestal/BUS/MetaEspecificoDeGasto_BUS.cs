using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class MetaEspecificoDeGasto_BUS
    {
        public bool Insert_MetaEspecificoDeGasto(MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto )
        {
            SqlConnection sqlConection = null;
            SqlTransaction TransMetaEspecifica = null;
            bool b_MetaEspecifica = false;
       
            try
            {
                sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion);
                sqlConection.Open();
                TransMetaEspecifica = sqlConection.BeginTransaction();
                if (pMetaEspecificoDeGasto != null)
                {
                    b_MetaEspecifica = new MetaEspecificoDeGasto_DAL().Insert_MetaEspecificoDeGasto(pMetaEspecificoDeGasto, TransMetaEspecifica);
                
 
                }
                if (b_MetaEspecifica)
                {
                    TransMetaEspecifica.Commit();

                }
                else
                {
                    TransMetaEspecifica.Rollback();
                }
            }

            catch (Exception exception)
            {
                if (TransMetaEspecifica != null)
                    TransMetaEspecifica.Rollback();
                return false;
            }
            finally
            {
                if (sqlConection != null)
                {
                    sqlConection.Close();
                }
                sqlConection.Dispose();

            }
            return b_MetaEspecifica;
        }
        public bool Update_MetaEspecificoDeGasto(MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto)
        {
            SqlConnection sqlConection = null;
            SqlTransaction TransMetaEspecifica = null;
            bool b_MetaEspecifica = false;

            try
            {
                sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion);
                sqlConection.Open();
                TransMetaEspecifica = sqlConection.BeginTransaction();
                if (pMetaEspecificoDeGasto != null)
                {
                    b_MetaEspecifica = new MetaEspecificoDeGasto_DAL().Update_MetaEspecificoDeGasto(pMetaEspecificoDeGasto, TransMetaEspecifica);


                }
                if (b_MetaEspecifica)
                {
                    TransMetaEspecifica.Commit();

                }
                else
                {
                    TransMetaEspecifica.Rollback();
                }
            }

            catch (Exception exception)
            {
                if (TransMetaEspecifica != null)
                    TransMetaEspecifica.Rollback();
                return false;
            }
            finally
            {
                if (sqlConection != null)
                {
                    sqlConection.Close();
                }
                sqlConection.Dispose();

            }
            return b_MetaEspecifica;
        }
        public DataTable List_MetaEspecificaDeGasto(String idMeta)
        {
            DataTable mDtMetaEspecificaDeGasto = new DataTable();
            try
            {
                mDtMetaEspecificaDeGasto = new MetaEspecificoDeGasto_DAL().List_MetaEspecificaDeGasto(idMeta);

            }
            catch (Exception ex) { throw ex; }
            return mDtMetaEspecificaDeGasto;
        }
    }
}
