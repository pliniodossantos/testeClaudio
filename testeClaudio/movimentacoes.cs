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
    public partial class movimentacoes : Form
    {
        public movimentacoes()
        {
            InitializeComponent();



        }

        private void idConteiner_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var strSql = $"SELECT conteiner.codigoConteiner, conteiner.id_cliente, clientes.cliente FROM conteiner JOIN clientes on clientes.id_cliente = conteiner.id_cliente WHERE conteiner.id_conteiner = {idConteiner.Text}";
                var comando = new MySqlCommand(strSql, conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    codConteiner.Text = ($"{reader["codigoConteiner"]}");
                    idCliente.Text = ($"{reader["id_cliente"]}");
                    cliente.Text = ($"{reader["cliente"]}");
                }
                conexao.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void movimentacoes_Load(object sender, EventArgs e)
        {
            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                conexao.Open();
                var comando = new MySqlCommand("SELECT `id_conteiner` FROM `conteiner` ORDER BY `id_conteiner` ASC", conexao);
                var reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    idConteiner.Items.Add($"{reader["id_conteiner"]}");


                }
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void idConteiner_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var movimento = movimentacao.Text;
            var dateInit = anoInit.Text + mesInit.Text + diaInit.Text + horaInit.Text.Replace(":", "");
            var dateFim = anoEnd.Text + mesEnd.Text + diaEnd.Text + horaEnd.Text.Replace(":", "");
            var idCont = idConteiner.Text;
            var idClien = idCliente.Text;


            try
            {
                var strConexao = "server=localhost;uid=root;database=testeclaudio";
                var conexao = new MySqlConnection(strConexao);
                var strSql = "INSERT INTO `movimentacao` (`tipoMovimentacao`, `dataInicio`, `dataFim`, `idConteiner`, `idCliente`) VALUES (@movimento, @dateinit, @datefim, @idcont, @idclient)";
                var comando = new MySqlCommand(strSql, conexao);
                comando.Parameters.AddWithValue("@movimento", movimento);
                comando.Parameters.AddWithValue("@dateinit", dateInit);
                comando.Parameters.AddWithValue("@datefim", dateFim);
                comando.Parameters.AddWithValue("@idcont", idCont);
                comando.Parameters.AddWithValue("@idclient", idClien);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                this.Close();
                MessageBox.Show("Movimentação Adicionado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dateInit_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void diaInit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mesInit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void anoInit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void diaEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mesEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void anoEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var goToForm = new editarOuExcluirMovimentacao();
            goToForm.Show();
        }
    }
}
