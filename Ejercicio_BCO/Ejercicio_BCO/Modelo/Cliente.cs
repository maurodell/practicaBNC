using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_BCO.Modelo
{
    public class Cliente
    {
        #region Propiedades_Clase
        public int pDni { get; set; }
        public string pNombre { get; set; }
        public string pApellido { get; set; }
        public string pTelefono { get; set; }
        public string pEmail { get; set; }
        public DateTime pFechaNac { get; set; }
        
        public int pEdad
        {
            get { return CalculaEdad();  }
        }
        #endregion

        public int CalculaEdad()
        {
            DateTime fechaActual = DateTime.Today;

            int edadC = fechaActual.Year - pFechaNac.Year;

            return (fechaActual < pFechaNac.AddYears(edadC)) ? edadC-- : edadC;
        }


    }
}
