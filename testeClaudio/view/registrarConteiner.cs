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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testeClaudio
{
    public partial class registrarConteiner : Form
    {
        public registrarConteiner()
        {
            InitializeComponent();

            var ids = controlers.conteinerControler.ListarIdClientes();
            foreach (var item in ids)
            {
                idCliente.Items.Add(item.id_cliente.ToString());
            }

        }

        private void letrasConteiner_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlers.auxControler.OnliLetters(sender, e);
        }

        private void letrasConteiner_TextChanged(object sender, EventArgs e)
        {

        }

        private void numerosConteiner_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlers.auxControler.OnlyNumbers(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        { }

        private void idCliente_DropDownClosed(object sender, EventArgs e)
        {
            string id_Cliente = idCliente.Text;
            var cliente = controlers.conteinerControler.RecebeClientePorId(id_Cliente);
            nomeCliente.Text = cliente.cliente.ToString();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            var codigoContainer = letrasConteiner.Text + numerosConteiner.Text;
            var tipoContainer = tipo.Text;
            var stat = status.Text;
            var categori = categoria.Text;
            var id_Cliente = idCliente.Text;
            controlers.conteinerControler.RegistrarConteiner(codigoContainer, tipoContainer, stat, categori, id_Cliente);
            this.Close();
        }

        private void registrarConteiner_Load(object sender, EventArgs e)
        { }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var goToForm = new editarOuExcluirConteiner();
            goToForm.ShowDialog();
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form goToForm = new Home();
            goToForm.Closed += (s, args) => this.Close();
            goToForm.Show();
        }
    }
}
