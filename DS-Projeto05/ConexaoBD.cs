using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DS_Projeto05
{
    class ConexaoBD
    {
        private string conexaoBanco = "server=localhost; database=Projeto05; uid=root; pwd=''";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();

            return conexao;
        }
    }
}
