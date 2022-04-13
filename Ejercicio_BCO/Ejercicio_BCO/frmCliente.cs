using Ejercicio_BCO.Modelo;
using Ejercicio_BCO.Servicios;
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
        ClienteABM _clienteABM;
        public frmCliente()
        {
            InitializeComponent();
            _cliente = new Cliente();
            _banco = Banco.Instanciar();
            _clienteABM = new ClienteABM();
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

            _clienteABM.Agregar(_cliente, _banco.Clientes);

            this.DialogResult = DialogResult.OK;
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void modificarCliente(Cliente clMod)
        {
            btnMod.Visible = true;
            btnAddCliente.Visible = false;

            txtDni.Text = clMod.pDni.ToString();
            txtNom.Text = clMod.pNombre;
            txtApe.Text = clMod.pApellido;
            txtTel.Text = clMod.pTelefono;
            txtMail.Text = clMod.pEmail;
            dtpNac.Value = clMod.pFechaNac;

            txtDni.Enabled = false;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            _cliente = new Cliente() { 
                    pDni = Convert.ToInt32(txtDni.Text), 
                    pNombre = txtNom.Text,
                    pApellido = txtApe.Text,
                    pTelefono = txtTel.Text,
                    pEmail = txtMail.Text,
                    pFechaNac = dtpNac.Value};

            _clienteABM.Modificar(_cliente, _banco.Clientes);
            this.DialogResult = DialogResult.OK;
        }
    }
}
