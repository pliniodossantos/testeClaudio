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
    public partial class addcliente : Form
    {
        public addcliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nomeCliente = textBox1.Text;
            var cpfCliente = textBox2.Text;
            var ufCliente = textBox3.Text;
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = "INSERT INTO clientes (cliente, cpf, uf) values (@cliente, @cpf, @uf)";
                var comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@cliente", nomeCliente);
                comando.Parameters.AddWithValue("@cpf", cpfCliente);
                comando.Parameters.AddWithValue("@uf", ufCliente);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                this.Close();
                MessageBox.Show("Cliente Adicionado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

       


        }
    }
}
