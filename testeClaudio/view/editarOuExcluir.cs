using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testeClaudio.controlers;

namespace testeClaudio
{
    public partial class editarOuExcluir : Form
    {
        public editarOuExcluir()
        {
            InitializeComponent();
        }

        private void editarOuExcluir_Load(object sender, EventArgs e)
        {
            controlers.clientesControler.ListaDeClientes(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.Rows[e.RowIndex];
            txtId.Text = line.Cells[0].Value.ToString();
            txtCliente.Text = line.Cells[1].Value.ToString();
            txtCpf.Text = line.Cells[2].Value.ToString();
            txtUf.Text = line.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.Rows[e.RowIndex];
            txtId.Text = line.Cells[0].Value.ToString();
            txtCliente.Text = line.Cells[1].Value.ToString();
            txtCpf.Text = line.Cells[2].Value.ToString();
            txtUf.Text = line.Cells[3].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        
        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string cliente = txtCliente.Text;
            string cpf = txtCpf.Text;
            string uf = txtUf.Text;
            controlers.clientesControler.DeleteCliente(id);
            this.Close();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string cliente = txtCliente.Text;
            string cpf = txtCpf.Text;
            string uf = txtUf.Text;
            controlers.clientesControler.EditarCliente(id, cliente, cpf, uf);
            this.Close();
        }
    }
}

