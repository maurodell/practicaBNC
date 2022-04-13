using Ejercicio_BCO.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_BCO.Servicios
{
    public class ClienteABM
    {
        public void Agregar(Cliente pCliente, List<Cliente> pListaCliente)
        {
            pListaCliente.Add(pCliente);
        }
        public void Borrar(Cliente pCliente, List<Cliente> pListaCliente)
        {
            try
            {
                Cliente _aux = pListaCliente.Find(x => x.pDni == pCliente.pDni);
                if (_aux != null)
                {
                    pListaCliente.Remove(_aux);
                }
                else
                {
                    throw new Exception("El cliente no existe");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Modificar(Cliente pCliente, List<Cliente> pListaCliente)
        {
            try
            {
                Cliente _aux = pListaCliente.Find(x => x.pDni == pCliente.pDni);
                if (_aux != null)
                {
                    pListaCliente.Remove(_aux);
                    pListaCliente.Add(pCliente);
                }
                else
                {
                    throw new Exception("No exíste");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
