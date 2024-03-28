using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testeClaudio.model;

namespace testeClaudio.controlers
{
    internal class auxControler
    {
        public static (MySqlDataReader, MySqlConnection) LerDb(string strSql)
        {
            var strConexao = "server=localhost;uid=root;database=testeclaudio";
            var conexao = new MySqlConnection(strConexao);
            conexao.Open();
            var comando = new MySqlCommand(strSql, conexao);
            var reader = comando.ExecuteReader();
            return (reader, conexao);
        }
        public static void EscreverDb(string strSql) {
            var strConexao = "server=localhost;uid=root;database=testeclaudio";
            var conexao = new MySqlConnection(strConexao);
            var comando = new MySqlCommand(strSql, conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public static void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
        }
        public static void OnliLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
