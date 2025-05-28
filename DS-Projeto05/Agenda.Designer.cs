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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panel1 = new Panel();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            Minimizar = new Guna.UI2.WinForms.Guna2ImageButton();
            Fechar = new Guna.UI2.WinForms.Guna2ImageButton();
            ListaCompromisso = new Guna.UI2.WinForms.Guna2DataGridView();
            groupBox1 = new GroupBox();
            btnAdicionar = new Guna.UI2.WinForms.Guna2ImageButton();
            chkFeito = new DataGridViewCheckBoxColumn();
            colTarefa = new DataGridViewTextBoxColumn();
            colData = new DataGridViewTextBoxColumn();
            colHorario = new DataGridViewTextBoxColumn();
            colRemover = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListaCompromisso).BeginInit();
            groupBox1.SuspendLayout();
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
            // ListaCompromisso
            // 
            ListaCompromisso.AllowUserToAddRows = false;
            ListaCompromisso.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            ListaCompromisso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ListaCompromisso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ListaCompromisso.ColumnHeadersHeight = 40;
            ListaCompromisso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ListaCompromisso.Columns.AddRange(new DataGridViewColumn[] { chkFeito, colTarefa, colData, colHorario, colRemover });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ListaCompromisso.DefaultCellStyle = dataGridViewCellStyle3;
            ListaCompromisso.GridColor = Color.FromArgb(231, 229, 255);
            ListaCompromisso.Location = new Point(15, 30);
            ListaCompromisso.Name = "ListaCompromisso";
            ListaCompromisso.RowHeadersVisible = false;
            ListaCompromisso.RowTemplate.Height = 40;
            ListaCompromisso.Size = new Size(831, 496);
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
            ListaCompromisso.ThemeStyle.HeaderStyle.Height = 40;
            ListaCompromisso.ThemeStyle.ReadOnly = false;
            ListaCompromisso.ThemeStyle.RowsStyle.BackColor = Color.White;
            ListaCompromisso.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ListaCompromisso.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ListaCompromisso.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ListaCompromisso.ThemeStyle.RowsStyle.Height = 40;
            ListaCompromisso.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ListaCompromisso.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ListaCompromisso.CellContentClick += ListaCompromisso_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(ListaCompromisso);
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(983, 532);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAdicionar
            // 
            btnAdicionar.CheckedState.ImageSize = new Size(64, 64);
            btnAdicionar.HoverState.Image = Properties.Resources.add;
            btnAdicionar.HoverState.ImageSize = new Size(45, 45);
            btnAdicionar.Image = Properties.Resources.add;
            btnAdicionar.ImageOffset = new Point(0, 0);
            btnAdicionar.ImageRotate = 0F;
            btnAdicionar.ImageSize = new Size(50, 50);
            btnAdicionar.Location = new Point(879, 75);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.PressedState.ImageSize = new Size(64, 64);
            btnAdicionar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdicionar.Size = new Size(80, 74);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // chkFeito
            // 
            chkFeito.FillWeight = 44.5506363F;
            chkFeito.HeaderText = "✓";
            chkFeito.Name = "chkFeito";
            // 
            // colTarefa
            // 
            colTarefa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTarefa.FillWeight = 127.307304F;
            colTarefa.HeaderText = "Tarefa";
            colTarefa.Name = "colTarefa";
            // 
            // colData
            // 
            colData.FillWeight = 110.881973F;
            colData.HeaderText = "Data";
            colData.Name = "colData";
            // 
            // colHorario
            // 
            colHorario.FillWeight = 141.11792F;
            colHorario.HeaderText = "Horário";
            colHorario.Name = "colHorario";
            // 
            // colRemover
            // 
            colRemover.FillWeight = 76.1421356F;
            colRemover.HeaderText = "";
            colRemover.Name = "colRemover";
            colRemover.Text = "🗑️";
            colRemover.UseColumnTextForButtonValue = true;
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ListaCompromisso).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton Minimizar;
        private Guna.UI2.WinForms.Guna2ImageButton Fechar;
        private Guna.UI2.WinForms.Guna2DataGridView ListaCompromisso;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdicionar;
        private DataGridViewCheckBoxColumn chkFeito;
        private DataGridViewTextBoxColumn colTarefa;
        private DataGridViewTextBoxColumn colData;
        private DataGridViewTextBoxColumn colHorario;
        private DataGridViewButtonColumn colRemover;
    }
}