using Ejercicio_BCO.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_BCO
{
    public partial class frmCliente : Form
    {
        Cliente _cliente;
        Banco _banco;
        public frmCliente()
        {
            InitializeComponent();
            _cliente = new Cliente();
            _banco = Banco.Instanciar();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            _cliente.pDni = Convert.ToInt32(txtDni.Text);
            _cliente.pNombre = txtNom.Text;
            _cliente.pApellido = txtApe.Text;
            _cliente.pTelefono = txtTel.Text;
            _cliente.pEmail = txtMail.Text;
            _cliente.pFechaNac = dtpNac.Value;
            textBox6.Text = Convert.ToString(_cliente.pEdad);

            _banco.Clientes.Add(_cliente);
            this.DialogResult = DialogResult.OK;
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
