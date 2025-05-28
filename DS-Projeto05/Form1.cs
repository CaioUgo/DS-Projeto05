namespace DS_Projeto05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void Cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();

            this.Hide();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Preencha os campos corretamente!", "Erro - Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                usuarios usuario = new usuarios();
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;

                usuarios usuarioLogado = usuarios.LoginUser(usuario.Email, usuario.Senha);
                if (usuarioLogado != null)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso - Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Agenda agenda = new Agenda();
                    agenda.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimparCampos();
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
        }
    }
}
