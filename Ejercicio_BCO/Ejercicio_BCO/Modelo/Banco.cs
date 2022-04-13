using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_BCO.Modelo
{
    public class Banco
    {
        private static Banco instancia;

        public static Banco Instanciar()
        {
            if (instancia == null)
            {
                instancia = new Banco();
            }
            return instancia;
        }
        private Banco()
        {
            Clientes = new List<Cliente>();
            Cuenta = new List<Cuenta>();
        }
        public List<Cliente> Clientes { get; set; }
        public List<Cuenta> Cuenta { get; set; }
    }
}
