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

namespace testeClaudio
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {
            var goToForm = new addcliente();
            goToForm.Show();
        }

        private void listadeclientes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridListaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT * FROM `clientes`";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridListaClientes.DataSource = dt;


                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            var goToForm = new editarOuExcluir();
            goToForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();   
        }
    }
}
