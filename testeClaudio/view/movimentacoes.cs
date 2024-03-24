﻿using MySql.Data.MySqlClient;
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
            string id_Conteiner  = idConteiner.Text;
            controlers.movimentacaoControler.RetornaInfosPorId(id_Conteiner, codConteiner, idCliente, cliente);
        }

        private void movimentacoes_Load(object sender, EventArgs e)
        {
            controlers.movimentacaoControler.RetornarIdConteiner(idConteiner);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataI = dateTimePicker1.Value;
            DateTime dataF = dateTimePickerFim.Value;
            var movimento = movimentacao.Text;
            var dateInit = dataI.ToString("yyyy-MM-dd").Replace("-", "") + horaInit.Text.Replace(":", "");
            var dateFim = dataF.ToString("yyyy-MM-dd").Replace("-", "") + horaEnd.Text.Replace(":", "");
            var idCont = idConteiner.Text;
            var idClien = idCliente.Text;

            controlers.movimentacaoControler.RegistrarMovimentacao(movimento, dateInit, dateFim, idCont, idClien);
            this.Close();
        }

        private void dateInit_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var goToForm = new editarOuExcluirMovimentacao();
            goToForm.Show();
        }

    }
}