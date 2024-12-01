using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class VoucherNegocio
    {
        public bool buscar(string codigo, ref bool usado)
        {
            List<Voucher> lista = new List<Voucher>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT CodigoVoucher,IdCliente,FechaCanje,IdArticulo FROM Vouchers where CodigoVoucher = @CodigoVoucher");
                datos.setearParametro("@CodigoVoucher", codigo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    DateTime? fechaUsado = datos.Lector["FechaCanje"] != DBNull.Value
               ? (DateTime?)datos.Lector["FechaCanje"]
               : null;
                    if (fechaUsado != null)
                    {
                        usado = true;
                    }
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}