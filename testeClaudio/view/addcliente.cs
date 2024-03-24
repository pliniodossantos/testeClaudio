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
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            string nomeCliente = textBox1.Text;
            string cpfCliente = textBox2.Text;
            string ufCliente = textBox3.Text;
            controlers.clientesControler.AddCliente(nomeCliente, cpfCliente, ufCliente);
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
