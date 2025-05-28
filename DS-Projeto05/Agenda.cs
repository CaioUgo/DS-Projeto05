using Guna.UI2.WinForms;
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

namespace DS_Projeto05
{
    public partial class Agenda : Form
    {
        private usuarios usuarioAtual;
        public Agenda()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int rowIndex = ListaCompromisso.Rows.Add(false, "", "");

            ListaCompromisso.CurrentCell = ListaCompromisso.Rows[rowIndex].Cells[1];

            ListaCompromisso.BeginEdit(true);
        }

        private void ListaCompromisso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaCompromisso.Columns[e.ColumnIndex].Name == "colRemover" && e.RowIndex >= 0 )
            {
                DialogResult confirmar = MessageBox.Show("Deseja excluir esta tarefa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmar == DialogResult.Yes)
                {
                    compromissos comp = new compromissos();
                    comp.Tarefa = ListaCompromisso.Rows[e.RowIndex].Cells["colTarefa"].Value.ToString();
                    comp.Prazo = Convert.ToDateTime(ListaCompromisso.Rows[e.RowIndex].Cells["colData"].Value);
                    comp.Horario = TimeSpan.Parse(ListaCompromisso.Rows[e.RowIndex].Cells["colHorario"].Value.ToString());

                    using (MySqlConnection conexao = new ConexaoBD().Conectar())
                    {
                        string delete = "DELETE from tarefas WHERE descricao = @descricao and prazo = @prazo and horario = @horario";

                        MySqlCommand cmd = new MySqlCommand(delete, conexao);

                        cmd.Parameters.AddWithValue("@descricao", comp.Tarefa);
                        cmd.Parameters.AddWithValue("@prazo", comp.Prazo);
                        cmd.Parameters.AddWithValue("@horario", comp.Horario);

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado>0)
                        {
                            MessageBox.Show("Tarefa excluída com sucesso!");
                            ListaCompromisso.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir a tarefa.");
                        }
                    }
                    }
                }
            }
        }
    }

