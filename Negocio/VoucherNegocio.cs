using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dominio;

namespace Negocio
{
    public class VoucherNegocio
    {
        public bool buscar(string codigo)
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
                    Voucher aux = new Voucher
                    {
                        CodigoVoucher = (string)datos.Lector["CodigoVoucher"],
                        IdCliente = (int)datos.Lector["IdCliente"],
                        FechaCanje = (DateTime)datos.Lector["FechaCanje"],
                        IdArticulo = (int)datos.Lector["IdArticulo"]

                    };

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