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
    public partial class editarOuExcluirConteiner : Form
    {
        public editarOuExcluirConteiner()
        {
            InitializeComponent();
        }
        private void editarOuExcluirConteiner_Load(object sender, EventArgs e)
        {
            controlers.conteinerControler.ListarConteiner(dataGridView1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridView1.Rows[e.RowIndex];
            idConteiner.Text = line.Cells[0].Value.ToString();
            letrasConteiner.Text = line.Cells[1].Value.ToString();
            tipo.Text = line.Cells[2].Value.ToString();
            status.Text = line.Cells[3].Value.ToString();
            categoria.Text = line.Cells[4].Value.ToString();
            idcliente.Text = line.Cells[5].Value.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            string codConteiner = letrasConteiner.Text;
            string type = tipo.Text;
            string estado = status.Text;   
            string category = categoria.Text;
            string id_Conteiner = idConteiner.Text;
            controlers.conteinerControler.EditarConteiner(codConteiner, type, estado, category, id_Conteiner);
            this.Close();
        }
        private void btnExc_Click(object sender, EventArgs e)
        {
            string id_Conteiner = idConteiner.Text;
            controlers.conteinerControler.ExcluirConteiner(id_Conteiner);
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
    }
}
