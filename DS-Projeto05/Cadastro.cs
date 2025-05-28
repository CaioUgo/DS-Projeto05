using Org.BouncyCastle.Tls.Crypto;
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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Close();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtSenha.Text) || String.IsNullOrWhiteSpace(txtUsuario.Text) )
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro - Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                usuarios usuario = new usuarios();
                usuario.Nome = txtNome.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Usuario = txtUsuario.Text;

                if (usuario.CadastrarUsuario())
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();

                    Form1 login = new Form1();
                    login.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar cadastro" + ex.Message, "Erro - Cadastrar Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimparCampos();

            }
        }
        public void LimparCampos()
        {
            txtEmail.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
            txtNome.Clear();
        }
    }
}
