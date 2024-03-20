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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testeClaudio
{
    public partial class registrarConteiner : Form
    {
        public registrarConteiner()
        {
            InitializeComponent();

            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = "SELECT `id_cliente` FROM `clientes`";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    idCliente.Items.Add(($"{reader["id_cliente"]}"));

                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void letrasConteiner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void letrasConteiner_TextChanged(object sender, EventArgs e)
        {

        }

        private void numerosConteiner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idCliente_Click(object sender, EventArgs e)
        {



        }

        private void idCliente_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void idCliente_DropDown(object sender, EventArgs e)
        {

        }

        private void idCliente_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = $"SELECT `cliente` FROM `clientes` WHERE `clientes`.`id_cliente` = {idCliente.Text}";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();


                while (reader.Read())
                {
                    nomeCliente.Text = ($"{reader["cliente"]}");
                }



                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            var id_Cliente = idCliente.Text;
            var codigoContainer = letrasConteiner.Text + numerosConteiner.Text;
            var tipoContainer = tipo.Text;
            var stat = status.Text;
            var categori = categoria.Text;
            
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = "INSERT INTO `conteiner` (`codigoConteiner`, `tipo`, `estado`, `categoria`, `id_cliente`) VALUES ( @codigo, @tipo, @estado, @categoria, @idCliente)";
                var comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@codigo", codigoContainer);
                comando.Parameters.AddWithValue("@tipo", tipoContainer);
                comando.Parameters.AddWithValue("@estado", stat);
                comando.Parameters.AddWithValue("@categoria", categori);
                comando.Parameters.AddWithValue("@idCliente", id_Cliente);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                this.Close();
                MessageBox.Show("Conteiner Adicionado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void registrarConteiner_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var goToForm = new editarOuExcluirConteiner();
            goToForm.Show();
        }
    }
}
