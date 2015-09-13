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
    public class MetaEspecificoDeGastoModificado_BUS
    {
         
        public bool Insert_MetaEspecificoDeGastoModificado(MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado)
        {
            SqlConnection sqlConection = null;
            SqlTransaction TransMetaEspecificaMoficado = null;
            bool b_MetaEspecificaModificado = false;

            try
            {
                sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion);
                sqlConection.Open();
                TransMetaEspecificaMoficado = sqlConection.BeginTransaction();
                if (pMetaEspecificoDeGastoModificado != null)
                {
                    b_MetaEspecificaModificado = new MetaEspecificoDeGastoModificado_DAL().Insert_MetaEspecificoDeGastoMoficado(pMetaEspecificoDeGastoModificado, TransMetaEspecificaMoficado);


                }
                if (b_MetaEspecificaModificado)
                {
                    TransMetaEspecificaMoficado.Commit();

                }
                else
                {
                    TransMetaEspecificaMoficado.Rollback();
                }
            }

            catch (Exception exception)
            {
                if (TransMetaEspecificaMoficado != null)
                    TransMetaEspecificaMoficado.Rollback();
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
            return b_MetaEspecificaModificado;
        }
        public bool Update_MetaEspecificoDeGastoModificado(MetaEspecificoDeGastoModificado_VO pMetaEspecificoDeGastoModificado)
        {
            SqlConnection sqlConection = null;
            SqlTransaction TransMetaEspecificaMoficado = null;
            bool b_MetaEspecificaModificado = false;

            try
            {
                sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion);
                sqlConection.Open();
                TransMetaEspecificaMoficado = sqlConection.BeginTransaction();
                if (pMetaEspecificoDeGastoModificado != null)
                {
                    b_MetaEspecificaModificado = new MetaEspecificoDeGastoModificado_DAL().Insert_MetaEspecificoDeGastoMoficado(pMetaEspecificoDeGastoModificado, TransMetaEspecificaMoficado);


                }
                if (b_MetaEspecificaModificado)
                {
                    TransMetaEspecificaMoficado.Commit();

                }
                else
                {
                    TransMetaEspecificaMoficado.Rollback();
                }
            }

            catch (Exception exception)
            {
                if (TransMetaEspecificaMoficado != null)
                    TransMetaEspecificaMoficado.Rollback();
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
            return b_MetaEspecificaModificado;
        }
        public DataTable List_MetaEspecificaDeGastoModificado(MetaEspecificoDeGasto_VO pMetaEspecificoDeGasto)
        {
            DataTable mDtMetaEspecificaDeGasto = new DataTable();
            try
            {
                mDtMetaEspecificaDeGasto = new MetaEspecificoDeGastoModificado_DAL().List_MetaEspecificaDeGasto(pMetaEspecificoDeGasto);

            }
            catch (Exception ex) { throw ex; }
            return mDtMetaEspecificaDeGasto;
        }
    }
}
