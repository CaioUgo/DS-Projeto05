using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DS_Projeto05
{
    class compromissos
    {
        private int id;
        private DateTime prazo;
        private TimeSpan horario;
        private string tarefa;
        private int id_usuario;

        public int ID_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        public DateTime Prazo
        {
            get { return prazo; }
            set { prazo = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public TimeSpan Horario
        {
            get { return horario; }
            set { horario = value; }
        }
        public string Tarefa
        {
            get { return tarefa; }
            set { tarefa = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool CadastrarCompromisso()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string insert = "INSERT INTO tarefas (descricao, prazo, horario, id_cadastro) values (@descricao, @prazo, @horario, @id_cadastro)";
                    MySqlCommand cmd = new MySqlCommand(insert, conexao);

                    cmd.Parameters.AddWithValue("@descricao", Tarefa);
                    cmd.Parameters.AddWithValue("@prazo", Prazo);
                    cmd.Parameters.AddWithValue("@horario", Horario);
                    cmd.Parameters.AddWithValue("@id_cadastro", ID_usuario);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
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
                MessageBox.Show("Não foi possível realizar cadastro -> Método" + ex.Message, "Erro - Cadastrar Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//

        public void ListarCompromisso(DataGridView grid, int idUsuario)
        {
            using(MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                string select = "SELECT id_tarefa, descricao, prazo, horario FROM tarefas WHERE id_cadastro = @id_cadastro;";

                MySqlCommand cmd = new MySqlCommand(select, conexao);
                cmd.Parameters.AddWithValue("@id_cadastro", ID_usuario);
                MySqlDataReader readerSelect = cmd.ExecuteReader();

                grid.Rows.Clear();

                while(readerSelect.Read())
                {
                    int id = Convert.ToInt32(readerSelect["id_tarefa"]);
                    string descricao = readerSelect["descricao"].ToString();
                    string prazo = readerSelect["prazo"].ToString();
                    string horario = readerSelect["horario"].ToString();

                    grid.Rows.Add(false, id, descricao, prazo, horario);
                }
                readerSelect.Close();
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool ExcluirCompromisso()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string delete = "Delete from tarefas WHERE descricao = @descricao and prazo = @prazo and horario = @horario";
                    MySqlCommand cmd = new MySqlCommand(delete, conexao);

                    cmd.Parameters.AddWithValue("@descricao", Tarefa);
                    cmd.Parameters.AddWithValue("@prazo", Prazo);
                    cmd.Parameters.AddWithValue("@horario", Horario);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
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
                MessageBox.Show("Não foi possível excluir compromisso -> Método" + ex.Message, "Erro - Excluir Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        public bool EditarCompromisso()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string update = "UPDATE tarefas SET descricao = @descricao, prazo = @prazo, horario = @horario WHERE id_tarefa = @id_tarefa";
                    MySqlCommand cmd = new MySqlCommand(update, conexao);

                    cmd.Parameters.AddWithValue("@id_tarefa", ID);
                    cmd.Parameters.AddWithValue("@descricao", Tarefa);
                    cmd.Parameters.AddWithValue("@prazo", Prazo);
                    cmd.Parameters.AddWithValue("@horario", Horario);

                    int resultado = cmd.ExecuteNonQuery();

                    if (resultado > 0)
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
                MessageBox.Show("Não foi possível excluir compromisso -> Método" + ex.Message, "Erro - Excluir Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
