using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BCrypt.Net;
using MySql.Data.MySqlClient;
using System.CodeDom;

namespace DS_Projeto05
{
    class usuarios
    {
        private int id;
        private string email;
        private string senha;
        private string nome;
        private string usuario;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int ID
        {
            get { return id;  }
            set { id = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!verificarEmail(value))
                    throw new Exception("Email inválido");
                email = value;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string insert = "INSERT INTO cadastro (nome, email, senha, usuario) values (@nome, @email, @senha, @usuario)";
                    MySqlCommand cmd = new MySqlCommand(insert, conexao);

                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@senha", Senha);
                    cmd.Parameters.AddWithValue("@usuario", Usuario);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro -> Método" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//

        public static usuarios LoginUser(string email, string senha)
        {
            using (MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                string query = "SELECT id, nome, email, usuario FROM cadastro WHERE email = @Email AND senha = @Senha";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new usuarios
                        {
                            ID = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Email = reader.GetString("email"),
                            Usuario = reader.GetString("usuario")
                        };
                    }
                }
            }

            return null; // usuário não encontrado
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public void DefinirSenha(string senhaPura)
        {
            senha = BCrypt.Net.BCrypt.HashPassword(senhaPura);
        }
        public bool VerificarSenha(string senhaDigitada, string hashArmazenado)
        {
            return BCrypt.Net.BCrypt.Verify(senhaDigitada, hashArmazenado);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public static bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

    }
}
