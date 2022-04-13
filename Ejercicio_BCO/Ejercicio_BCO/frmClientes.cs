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
        frmCliente _listaCC = new frmCliente();
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
        private void grilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _banco.Clientes;
        }
        private void agregarCliente_Click(object sender, EventArgs e)
        {
            frmCliente ClienteAdd = new frmCliente();
            
            DialogResult resp = ClienteAdd.ShowDialog();
            ClienteAdd.Show();
            if (resp == DialogResult.OK)
            {
                //grilla();
                //ActualizarGrilla(dataGridView1, _banco.Clientes);
                ActualizarGrilla(dataGridView1, _listaCC.);
            }

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            /*----------------------DataGridView CLIENTE-------------------------------*/
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "DNI"; // name
            dataGridView1.Columns[0].HeaderText = "DNI"; // header text
            dataGridView1.Columns[0].DataPropertyName = "DNI";
            dataGridView1.Columns[1].Name = "Nombre"; // name
            dataGridView1.Columns[1].HeaderText = "Nombre"; // header text
            dataGridView1.Columns[1].DataPropertyName = "Nombre";
            dataGridView1.Columns[2].Name = "Apellido"; // name
            dataGridView1.Columns[2].HeaderText = "Apellido"; // header text
            dataGridView1.Columns[2].DataPropertyName = "Apellido";
            dataGridView1.Columns[3].Name = "Telefono"; // name
            dataGridView1.Columns[3].HeaderText = "Telefono"; // header text
            dataGridView1.Columns[3].DataPropertyName = "Telefono";
            dataGridView1.Columns[4].Name = "E-mail"; // name
            dataGridView1.Columns[4].HeaderText = "E-mail"; // header text
            dataGridView1.Columns[4].DataPropertyName = "E-mail";
            dataGridView1.Columns[5].Name = "Fecha Nac."; // name
            dataGridView1.Columns[5].HeaderText = "Fecha Nac."; // header text
            dataGridView1.Columns[5].DataPropertyName = "Fecha Nac.";
            dataGridView1.Columns[6].Name = "Edad"; // name
            dataGridView1.Columns[6].HeaderText = "Edad"; // header text
            dataGridView1.Columns[6].DataPropertyName = "Edad";
            /*---------------------------------------------------------------------------*/

            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
