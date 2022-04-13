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
    public partial class frmClientes : Form
    {
        Banco _banco;
        frmCliente ClienteAdd;
        public frmClientes()
        {
            InitializeComponent();
            _banco = Banco.Instanciar();
        }
        public void ActualizarGrilla(DataGridView dtgv, object obj)
        {
            dtgv.DataSource = null;
            dtgv.DataSource = obj;
        }

        private void agregarCliente_Click(object sender, EventArgs e)
        {
            ClienteAdd = new frmCliente();
            DialogResult resp = ClienteAdd.ShowDialog();
            ClienteAdd.Show();
            if (resp == DialogResult.OK)
            {
                ActualizarGrilla(dataGridView1, _banco.Clientes);
                ClienteAdd.Close();
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void modificarCliente_Click(object sender, EventArgs e)
        {
            ClienteAdd = new frmCliente();
            Cliente _cliMod = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
            ClienteAdd.modificarCliente(_cliMod, _banco.Clientes);
            DialogResult resp = ClienteAdd.ShowDialog();
            ClienteAdd.Show();
            if (resp == DialogResult.OK)
            {
                ActualizarGrilla(dataGridView1, _banco.Clientes);
                ClienteAdd.Close();
            }
        }
    }
}
