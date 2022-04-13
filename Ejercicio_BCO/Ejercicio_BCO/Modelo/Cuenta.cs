using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_BCO.Modelo
{
    public abstract class Cuenta
    {
        #region Propiedades Cuenta
        private int pCod;
        public int Cod
        {
            get { return pCod; }
            set { pCod = value; }
        }
        public double pSaldo { get; set; }
        #endregion
        #region Constructores
        public Cuenta(int codigo)
        {
            this.Cod = codigo;
            this.pSaldo = 0;
        }
        public Cuenta(){}
        #endregion
        #region Metodos
        public void depositar(double monto)
        {
            this.pSaldo += monto;
        }
        public abstract void extraer(double monto);
        #endregion
    }
}
