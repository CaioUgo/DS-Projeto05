namespace DS_Projeto05
{
    partial class Agenda
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            Minimizar = new Guna.UI2.WinForms.Guna2ImageButton();
            Fechar = new Guna.UI2.WinForms.Guna2ImageButton();
            groupBox1 = new GroupBox();
            txtHorario = new MaskedTextBox();
            txtData = new MaskedTextBox();
            ListaCompromisso = new Guna.UI2.WinForms.Guna2DataGridView();
            btnExcluir = new Button();
            btnEditar = new Button();
            Adicionar = new Button();
            Prazo = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            txtID = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListaCompromisso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(520, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 12;
            label1.Text = "Agenda";
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
            panel1.Size = new Size(1028, 19);
            panel1.TabIndex = 11;
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
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
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
            Minimizar.Location = new Point(992, 1);
            Minimizar.Name = "Minimizar";
            Minimizar.PressedState.ImageSize = new Size(64, 64);
            Minimizar.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            Fechar.Location = new Point(1013, 1);
            Fechar.Name = "Fechar";
            Fechar.PressedState.ImageSize = new Size(64, 64);
            Fechar.ShadowDecoration.CustomizableEdges = customizableEdges3;
            Fechar.Size = new Size(15, 15);
            Fechar.TabIndex = 1;
            Fechar.Click += Fechar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(txtHorario);
            groupBox1.Controls.Add(txtData);
            groupBox1.Controls.Add(ListaCompromisso);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(Adicionar);
            groupBox1.Controls.Add(Prazo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtID);
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(983, 532);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(722, 183);
            txtHorario.Mask = "00:00";
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(241, 23);
            txtHorario.TabIndex = 15;
            // 
            // txtData
            // 
            txtData.Location = new Point(722, 124);
            txtData.Mask = "00/00/0000";
            txtData.Name = "txtData";
            txtData.Size = new Size(241, 23);
            txtData.TabIndex = 14;
            // 
            // ListaCompromisso
            // 
            ListaCompromisso.AllowUserToAddRows = false;
            ListaCompromisso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            ListaCompromisso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaCompromisso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaCompromisso.ColumnHeadersHeight = 17;
            ListaCompromisso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListaCompromisso.DefaultCellStyle = dataGridViewCellStyle3;
            ListaCompromisso.GridColor = Color.FromArgb(231, 229, 255);
            ListaCompromisso.Location = new Point(20, 22);
            ListaCompromisso.Name = "ListaCompromisso";
            ListaCompromisso.ReadOnly = true;
            ListaCompromisso.RowHeadersVisible = false;
            ListaCompromisso.Size = new Size(674, 462);
            ListaCompromisso.TabIndex = 13;
            ListaCompromisso.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ListaCompromisso.ThemeStyle.AlternatingRowsStyle.Font = null;
            ListaCompromisso.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ListaCompromisso.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ListaCompromisso.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ListaCompromisso.ThemeStyle.BackColor = Color.White;
            ListaCompromisso.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ListaCompromisso.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ListaCompromisso.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ListaCompromisso.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            ListaCompromisso.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ListaCompromisso.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListaCompromisso.ThemeStyle.HeaderStyle.Height = 17;
            ListaCompromisso.ThemeStyle.ReadOnly = true;
            ListaCompromisso.ThemeStyle.RowsStyle.BackColor = Color.White;
            ListaCompromisso.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaCompromisso.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ListaCompromisso.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ListaCompromisso.ThemeStyle.RowsStyle.Height = 25;
            ListaCompromisso.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ListaCompromisso.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ListaCompromisso.CellContentClick += ListaCompromisso_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(793, 379);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(793, 325);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(793, 270);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(98, 23);
            Adicionar.TabIndex = 10;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // Prazo
            // 
            Prazo.AutoSize = true;
            Prazo.Font = new Font("Segoe UI", 10F);
            Prazo.Location = new Point(722, 161);
            Prazo.Name = "Prazo";
            Prazo.Size = new Size(58, 19);
            Prazo.TabIndex = 9;
            Prazo.Text = "Horário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(722, 93);
            label3.Name = "label3";
            label3.Size = new Size(41, 19);
            label3.TabIndex = 7;
            label3.Text = "Data:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(722, 30);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 7;
            label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(722, 52);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(241, 23);
            txtDescricao.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(371, 255);
            txtID.Name = "txtID";
            txtID.Size = new Size(241, 23);
            txtID.TabIndex = 16;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1028, 599);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            Load += Agenda_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListaCompromisso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton Minimizar;
        private Guna.UI2.WinForms.Guna2ImageButton Fechar;
        private GroupBox groupBox1;
        private Button Adicionar;
        private Label Prazo;
        private Label label2;
        private TextBox txtDescricao;
        private Button btnExcluir;
        private Button btnEditar;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView ListaCompromisso;
        private MaskedTextBox txtData;
        private MaskedTextBox txtHorario;
        private TextBox txtID;
    }
}