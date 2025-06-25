namespace Apresentacao
{
    partial class FrmCurso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCurso));
            pbCurso = new PictureBox();
            lbId = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            lbNome = new Label();
            lbTitulo = new Label();
            btnSair = new Button();
            btnInserir = new Button();
            errorProviderCurso = new ErrorProvider(components);
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCurso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCurso).BeginInit();
            SuspendLayout();
            // 
            // pbCurso
            // 
            pbCurso.Image = Properties.Resources._6771602_book_shelf_books_education_learning_school_icon;
            pbCurso.Location = new Point(12, 12);
            pbCurso.Name = "pbCurso";
            pbCurso.Size = new Size(38, 34);
            pbCurso.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCurso.TabIndex = 0;
            pbCurso.TabStop = false;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbId.ForeColor = SystemColors.Control;
            lbId.Location = new Point(12, 67);
            lbId.Name = "lbId";
            lbId.Size = new Size(20, 15);
            lbId.TabIndex = 1;
            lbId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(56, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(52, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(56, 88);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(242, 23);
            txtNome.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbNome.ForeColor = SystemColors.Control;
            lbNome.Location = new Point(12, 96);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(38, 15);
            lbNome.TabIndex = 3;
            lbNome.Text = "Curso";
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTitulo.ForeColor = SystemColors.Control;
            lbTitulo.Location = new Point(56, 31);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(111, 15);
            lbTitulo.TabIndex = 5;
            lbTitulo.Text = "Cadastro de Cursos";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.IndianRed;
            btnSair.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = SystemColors.ButtonHighlight;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(209, 160);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(89, 32);
            btnSair.TabIndex = 8;
            btnSair.Text = "&Esc Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.LightGreen;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnInserir.ForeColor = SystemColors.ActiveCaptionText;
            btnInserir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserir.Location = new Point(12, 160);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(96, 32);
            btnInserir.TabIndex = 7;
            btnInserir.Text = "&F10 Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // errorProviderCurso
            // 
            errorProviderCurso.ContainerControl = this;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Crimson;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExcluir.ForeColor = SystemColors.ButtonFace;
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(114, 160);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(89, 32);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "&F2 Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Visible = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(311, 204);
            Controls.Add(btnExcluir);
            Controls.Add(btnSair);
            Controls.Add(btnInserir);
            Controls.Add(lbTitulo);
            Controls.Add(txtNome);
            Controls.Add(lbNome);
            Controls.Add(txtId);
            Controls.Add(lbId);
            Controls.Add(pbCurso);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCurso";
            Text = "Curso ";
            Load += FrmCurso_Load;
            KeyDown += FrmCurso_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbCurso).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbCurso;
        private Label lbId;
        private TextBox txtId;
        private TextBox txtNome;
        private Label lbNome;
        private Label lbTitulo;
        private Button btnSair;
        private Button btnInserir;
        private ErrorProvider errorProviderCurso;
        private Button btnExcluir;
    }
}