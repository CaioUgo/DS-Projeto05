namespace DS_Projeto05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            Minimizar = new Guna.UI2.WinForms.Guna2ImageButton();
            Fechar = new Guna.UI2.WinForms.Guna2ImageButton();
            txtSenha = new TextBox();
            txtEmail = new TextBox();
            BtnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Cadastrar = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(Minimizar);
            panel1.Controls.Add(Fechar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 19);
            panel1.TabIndex = 0;
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
            Minimizar.ShadowDecoration.CustomizableEdges = customizableEdges1;
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
            Fechar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Fechar.Size = new Size(15, 15);
            Fechar.TabIndex = 1;
            Fechar.Click += Fechar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(284, 229);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(248, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(284, 146);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 23);
            txtEmail.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.CornflowerBlue;
            BtnLogin.Font = new Font("Segoe UI", 10F);
            BtnLogin.Location = new Point(366, 324);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(79, 28);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 47);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 4;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(284, 124);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 5;
            label2.Text = "Email ou usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(284, 207);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 6;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(284, 274);
            label4.Name = "label4";
            label4.Size = new Size(117, 13);
            label4.TabIndex = 7;
            label4.Text = "Não possui cadastro?";
            // 
            // Cadastrar
            // 
            Cadastrar.AutoSize = true;
            Cadastrar.Font = new Font("Segoe UI", 8F);
            Cadastrar.Location = new Point(407, 274);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(67, 13);
            Cadastrar.TabIndex = 8;
            Cadastrar.TabStop = true;
            Cadastrar.Text = "Cadastre-se";
            Cadastrar.LinkClicked += Cadastrar_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(Cadastrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Controls.Add(txtEmail);
            Controls.Add(txtSenha);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton Fechar;
        private Guna.UI2.WinForms.Guna2ImageButton Minimizar;
        private TextBox txtSenha;
        private TextBox txtEmail;
        private Button BtnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel Cadastrar;
    }
}
