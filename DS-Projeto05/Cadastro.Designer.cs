namespace DS_Projeto05
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            panel1 = new Panel();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            Minimizar = new Guna.UI2.WinForms.Guna2ImageButton();
            Fechar = new Guna.UI2.WinForms.Guna2ImageButton();
            label4 = new Label();
            txtUsuario = new TextBox();
            label5 = new Label();
            txtNome = new TextBox();
            BtnCadastro = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(284, 265);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 12;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(284, 96);
            label2.Name = "label2";
            label2.Size = new Size(44, 19);
            label2.TabIndex = 11;
            label2.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(361, 33);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 10;
            label1.Text = "Cadastro";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(284, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(284, 287);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(248, 23);
            txtSenha.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(guna2ImageButton1);
            panel1.Controls.Add(Minimizar);
            panel1.Controls.Add(Fechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 19);
            panel1.TabIndex = 7;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.Image = Properties.Resources.de_volta;
            guna2ImageButton1.HoverState.ImageSize = new Size(10, 10);
            guna2ImageButton1.Image = Properties.Resources.de_volta;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(12, 12);
            guna2ImageButton1.Location = new Point(0, 1);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ImageButton1.Size = new Size(15, 15);
            guna2ImageButton1.TabIndex = 3;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // Minimizar
            // 
            Minimizar.CheckedState.ImageSize = new Size(64, 64);
            Minimizar.HoverState.Image = Properties.Resources.menos;
            Minimizar.HoverState.ImageSize = new Size(10, 10);
            Minimizar.Image = Properties.Resources.menos;
            Minimizar.ImageOffset = new Point(0, 0);
            Minimizar.ImageRotate = 0F;
            Minimizar.ImageSize = new Size(12, 12);
            Minimizar.Location = new Point(764, 1);
            Minimizar.Name = "Minimizar";
            Minimizar.PressedState.ImageSize = new Size(64, 64);
            Minimizar.ShadowDecoration.CustomizableEdges = customizableEdges5;
            Minimizar.Size = new Size(15, 15);
            Minimizar.TabIndex = 2;
            Minimizar.Click += Minimizar_Click;
            // 
            // Fechar
            // 
            Fechar.CheckedState.ImageSize = new Size(64, 64);
            Fechar.HoverState.Image = Properties.Resources.x;
            Fechar.HoverState.ImageSize = new Size(10, 10);
            Fechar.Image = Properties.Resources.x;
            Fechar.ImageOffset = new Point(0, 0);
            Fechar.ImageRotate = 0F;
            Fechar.ImageSize = new Size(12, 12);
            Fechar.Location = new Point(785, 0);
            Fechar.Name = "Fechar";
            Fechar.PressedState.ImageSize = new Size(64, 64);
            Fechar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Fechar.Size = new Size(15, 15);
            Fechar.TabIndex = 1;
            Fechar.Click += Fechar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(284, 151);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 14;
            label4.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(284, 173);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(248, 23);
            txtUsuario.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(284, 208);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 16;
            label5.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(284, 230);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 15;
            // 
            // BtnCadastro
            // 
            BtnCadastro.BackColor = Color.CornflowerBlue;
            BtnCadastro.Font = new Font("Segoe UI", 10F);
            BtnCadastro.Location = new Point(370, 365);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(79, 28);
            BtnCadastro.TabIndex = 17;
            BtnCadastro.Text = "Cadastrar";
            BtnCadastro.UseVisualStyleBackColor = false;
            BtnCadastro.Click += BtnCadastro_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCadastro);
            Controls.Add(label5);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += Cadastro_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton Minimizar;
        private Guna.UI2.WinForms.Guna2ImageButton Fechar;
        private Label label4;
        private TextBox txtUsuario;
        private Label label5;
        private TextBox txtNome;
        private Button BtnCadastro;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}