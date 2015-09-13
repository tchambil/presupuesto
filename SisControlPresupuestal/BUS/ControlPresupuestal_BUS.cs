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
        public bool Insert_ControlPresupuestal(ref ControlPresupuestal_VO pControlPresupuestal, DataTable DtDetalleControlPresupuestal)
        {
            SqlConnection sqlConection = null;
            SqlTransaction TransControlPresupuestal = null;
            bool b_ControlPresupuestal = false;
            bool b_DetalleControlP = false;
            try
            {
                sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion);
                sqlConection.Open();
                TransControlPresupuestal = sqlConection.BeginTransaction();
                if (pControlPresupuestal != null)
                {
                    b_ControlPresupuestal = new ControlPresupuestal_DAL().Insert_ControlPresupuestal(ref pControlPresupuestal, TransControlPresupuestal);
                    if (b_ControlPresupuestal)
                    {
                        int intDetalleCount = 0;
                        foreach (DataRow dtRow in DtDetalleControlPresupuestal.Rows)
                        {
                            DetalleControlPresupuestal_VO pDetalleControlPresupuestal = new DetalleControlPresupuestal_VO();
                            pDetalleControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL = pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL;
                            pDetalleControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO = pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO;
                            pDetalleControlPresupuestal.DCPR_DEC_IMPORTE = Convert.ToDecimal(dtRow["DCPR_DEC_IMPORTE"]);
                            pDetalleControlPresupuestal.META_VCH_IDMETA = dtRow["META_VCH_IDMETA"].ToString();
                            if (new DetalleControlPresupuestal_DAL().Insert_DetalleControlPresupuestal(pDetalleControlPresupuestal, TransControlPresupuestal))
                            {
                                intDetalleCount++;
                            }


                        }
                        b_DetalleControlP = (intDetalleCount == DtDetalleControlPresupuestal.Rows.Count);

                    }
                }
                if (b_ControlPresupuestal && b_DetalleControlP)
                {
                    TransControlPresupuestal.Commit();

                }
                else
                {
                    TransControlPresupuestal.Rollback();
                }
            }

            catch (Exception exception)
            {
                if (TransControlPresupuestal != null)
                    TransControlPresupuestal.Rollback();
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
            return b_ControlPresupuestal;
        }
        public bool Update_ControlPresupuestal(ControlPresupuestal_VO pControlPresupuestal, DataTable DtDetalleControlPresupuestal)
        {
            SqlConnection sqlConection = null;
            SqlTransaction TransControlPresupuestal = null;
            bool b_ControlPresupuestal = false;
            bool b_DetalleControlP = false;
            bool b_DeleteDetalleControlP = false;
            try
            {
                sqlConection = new SqlConnection(BEConexion.vg_strCadenaConexion);
                sqlConection.Open();
                TransControlPresupuestal = sqlConection.BeginTransaction();
                if (pControlPresupuestal != null)
                {
                    b_DeleteDetalleControlP = new DetalleControlPresupuestal_DAL().Delete_DetalleControlPresupuestal(pControlPresupuestal, TransControlPresupuestal);
                    if (b_DeleteDetalleControlP)
                    {
                        b_ControlPresupuestal = new ControlPresupuestal_DAL().Update_ControlPresupuestal(pControlPresupuestal, TransControlPresupuestal);
                        if (b_ControlPresupuestal)
                        {
                            int intDetalleCount = 0;
                            foreach (DataRow dtRow in DtDetalleControlPresupuestal.Rows)
                            {
                                DetalleControlPresupuestal_VO pDetalleControlPresupuestal = new DetalleControlPresupuestal_VO();
                                pDetalleControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL = pControlPresupuestal.CPRE_INT_IDCONTROLPRESUPUESTAL;
                                pDetalleControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO = pControlPresupuestal.EGAS_VCH_IDESPECIFICADEGASTO;
                                pDetalleControlPresupuestal.DCPR_DEC_IMPORTE = Convert.ToDecimal(dtRow["DCPR_DEC_IMPORTE"]);
                                pDetalleControlPresupuestal.META_VCH_IDMETA = dtRow["META_VCH_IDMETA"].ToString();
                                if (new DetalleControlPresupuestal_DAL().Insert_DetalleControlPresupuestal(pDetalleControlPresupuestal, TransControlPresupuestal))
                                {
                                    intDetalleCount++;
                                }
                            }
                            b_DetalleControlP = (intDetalleCount == DtDetalleControlPresupuestal.Rows.Count);
                        }
                    }

                }
                if (b_ControlPresupuestal && b_DetalleControlP && b_DeleteDetalleControlP)
                {
                    TransControlPresupuestal.Commit();

                }
                else
                {
                    TransControlPresupuestal.Rollback();
                }
            }

            catch (Exception exception)
            {
                if (TransControlPresupuestal != null)
                    TransControlPresupuestal.Rollback();
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
            return b_ControlPresupuestal;
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
