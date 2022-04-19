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
    public partial class frmClientes : Form
    {
        Banco _banco;
        frmCliente ClienteAdd;
        ClienteABM amb;
        public frmClientes()
        {
            InitializeComponent();
            _banco = Banco.Instanciar();
            //ActualizarComboBox(_banco.Clientes);
        }
        public void ActualizarGrilla(DataGridView dtgv, object obj)
        {
            dtgv.DataSource = null;
            dtgv.DataSource = obj;
        }
        public void ActualizarComboBox(List<Cliente> lista)
        {
            cmbDniCli.Items.Clear();

            foreach (var item in lista)
            {
                cmbDniCli.Items.Add(item.pDni);
            }
        }
        private void agregarCliente_Click(object sender, EventArgs e)
        {
            ClienteAdd = new frmCliente();
            DialogResult resp = ClienteAdd.ShowDialog();
            if (resp == DialogResult.OK)
            {
                ActualizarGrilla(dataGridView1, _banco.Clientes);
                ClienteAdd.Close();
            }
            ActualizarComboBox(_banco.Clientes);
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
            ClienteAdd.modificarCliente(_cliMod);
            DialogResult resp = ClienteAdd.ShowDialog();

            if (resp == DialogResult.OK)
            {
                ActualizarComboBox(_banco.Clientes);
                ActualizarGrilla(dataGridView1, _banco.Clientes);            
                ClienteAdd.Close();
            }
        }

        private void eliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count>0)
            {
                amb = new ClienteABM();
                Cliente eliminar = dataGridView1.SelectedRows[0].DataBoundItem as Cliente;
                amb.Borrar(eliminar, _banco.Clientes);

                ActualizarGrilla(dataGridView1, _banco.Clientes);
                ActualizarComboBox(_banco.Clientes);
            }
            else
            {
                MessageBox.Show("Lista de clientes vacia");
            }


        }

        private void cmbDniCli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consultarCliente_Click(object sender, EventArgs e)
        {
            Cliente resultado = _banco.Clientes.Find(x => x.pDni == Convert.ToInt32(cmbDniCli.SelectedItem));
            MessageBox.Show("Cliente\n"+
                            "Nombre: "+resultado.pNombre+"\n"+
                            "Apellido: "+resultado.pApellido);
        }
    }
}
