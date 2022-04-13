using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_BCO.Modelo
{
    public class CajaDeAhorro : Cuenta
    {
        int vLimite = 15000;
        public override void extraer(double monto)
        {
            if (pSaldo >= monto && pSaldo >= vLimite)
            {
                pSaldo -= monto;
            }
            else
            {
                throw new Exception("El monto de extracción excede el límite díario o no tiene saldo suficiente");
            }
        }
    }
}
