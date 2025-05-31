using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_Projeto05
{
    public partial class Agenda : Form
    {
        private int idUsuarioLogado;
        public Agenda(int idUsuario)
        {
            InitializeComponent();
            idUsuarioLogado = idUsuario;
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescricao.Text) || string.IsNullOrWhiteSpace(txtData.Text) || string.IsNullOrWhiteSpace(txtHorario.Text))
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro - Campos em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime prazo;
                if (!DateTime.TryParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out prazo))
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro - Campos em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimeSpan horario;
                if (!TimeSpan.TryParse(txtHorario.Text, out horario))
                {
                    MessageBox.Show("Horário inválido! Use o formato HH:mm.", "Erro - Horário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                compromissos comp = new compromissos();
                comp.Tarefa = txtDescricao.Text;
                comp.Prazo = prazo;
                comp.Horario = horario;
                comp.ID_usuario = idUsuarioLogado;

                if (comp.CadastrarCompromisso())
                {
                    MessageBox.Show("Cadastro realizado com sucesso", "Sucesso - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comp.ListarCompromisso(ListaCompromisso, idUsuarioLogado);

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar", "Erro - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro" + ex.Message, "Erro - Cadastrar Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    MessageBox.Show("Informe uma linha para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime prazo;
                if (!DateTime.TryParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out prazo))
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro - Campos em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimeSpan horario;
                if (!TimeSpan.TryParse(txtHorario.Text, out horario))
                {
                    MessageBox.Show("Horário inválido! Use o formato HH:mm.", "Erro - Horário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                compromissos comp = new compromissos();
                comp.ID = int.Parse(txtID.Text);
                comp.Tarefa = txtDescricao.Text;
                comp.Prazo = prazo;
                comp.Horario = horario;
                comp.ID_usuario = idUsuarioLogado;

                if (comp.EditarCompromisso())
                {
                    MessageBox.Show("Compromisso editado com sucesso", "Sucesso - Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comp.ListarCompromisso(ListaCompromisso, idUsuarioLogado);

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao editar", "Erro - editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a edição" + ex.Message, "Erro - Editar Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    MessageBox.Show("Informe uma linha para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime prazo;
                if (!DateTime.TryParseExact(txtData.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out prazo))
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro - Campos em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TimeSpan horario;
                if (!TimeSpan.TryParse(txtHorario.Text, out horario))
                {
                    MessageBox.Show("Horário inválido! Use o formato HH:mm.", "Erro - Horário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                compromissos comp = new compromissos();
                comp.Tarefa = txtDescricao.Text;
                comp.Prazo = prazo;
                comp.Horario = horario;
                comp.ID_usuario = idUsuarioLogado;

                if (comp.ExcluirCompromisso())
                {
                    MessageBox.Show("Compromisso excluído com sucesso", "Sucesso - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comp.ListarCompromisso(ListaCompromisso, idUsuarioLogado);

                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Erro - Excluir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a exclusão" + ex.Message, "Erro - Excluir Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------//
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
        private void ListaCompromisso_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (ListaCompromisso.IsCurrentCellDirty)
            {
                ListaCompromisso.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ListaCompromisso_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaCompromisso.Columns[e.ColumnIndex].Name == "Concluido")
            {
                bool marcado = (bool)ListaCompromisso.Rows[e.RowIndex].Cells["Concluido"].Value;
                MessageBox.Show($"Tarefa {(marcado ? "concluída" : "não concluída")} na linha {e.RowIndex + 1}");
            }
        }


        private void Agenda_Load(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn colConcluido = new DataGridViewCheckBoxColumn();
            colConcluido.Name = "Concluido";
            colConcluido.HeaderText = "✅";
            ListaCompromisso.Columns.Insert(0, colConcluido);
            ListaCompromisso.Columns.Add("ID", "ID");
            ListaCompromisso.Columns["ID"].Visible = false;
            ListaCompromisso.Columns.Add("Descricao", "Descrição");
            ListaCompromisso.Columns.Add("Prazo", "Data");
            ListaCompromisso.Columns.Add("Horario", "Horário");

            ListaCompromisso.EditMode = DataGridViewEditMode.EditOnEnter;
            ListaCompromisso.AllowUserToAddRows = false;
        }

        public void LimparCampos()
        {
            txtData.Clear();
            txtDescricao.Clear();
            txtHorario.Clear();
        }

        private void ListaCompromisso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ListaCompromisso.Rows[e.RowIndex];

                txtID.Text = row.Cells["ID"].Value?.ToString();
                txtDescricao.Text = row.Cells["Descricao"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["Prazo"].Value?.ToString(), out DateTime data))
                {
                    txtData.Text = data.ToString("dd/MM/yyyy");
                }

                var valorHorario = row.Cells["Horario"].Value;

                if (TimeSpan.TryParse(valorHorario?.ToString(), out TimeSpan ts))
                {
                    txtHorario.Text = ts.ToString(@"hh\:mm");
                }
                else if (DateTime.TryParse(valorHorario?.ToString(), out DateTime dt))
                {
                    txtHorario.Text = dt.ToString("HH:mm");
                }
            }
        }
    }
}

