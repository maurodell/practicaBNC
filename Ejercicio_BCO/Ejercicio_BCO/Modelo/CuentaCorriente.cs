using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_BCO.Modelo
{
    public class CuentaCorriente : Cuenta
    {
        public int pLimite { get; set; }

        public override void extraer(double monto)
        {
            if (pSaldo >= pLimite)
            {
                pSaldo -= monto;
            }
            else
            {
                throw new Exception("El monto ingresado excede el límite a descubierto");
            }
        }
    }
}
