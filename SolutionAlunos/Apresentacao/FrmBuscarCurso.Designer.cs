namespace Apresentacao
{
    partial class FrmBuscarCurso
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarCurso));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            imageListCurso = new ImageList(components);
            txtBuscarCurso = new TextBox();
            btnBuscarCurso = new Button();
            pbCurso = new PictureBox();
            lbCurso = new Label();
            dgvCurso = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            btnInserir = new Button();
            btnSelecionar = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCurso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurso).BeginInit();
            SuspendLayout();
            // 
            // imageListCurso
            // 
            imageListCurso.ColorDepth = ColorDepth.Depth32Bit;
            imageListCurso.ImageStream = (ImageListStreamer)resources.GetObject("imageListCurso.ImageStream");
            imageListCurso.TransparentColor = Color.Transparent;
            imageListCurso.Images.SetKeyName(0, "school_icon.png");
            imageListCurso.Images.SetKeyName(1, "search.png");
            // 
            // txtBuscarCurso
            // 
            txtBuscarCurso.Location = new Point(93, 46);
            txtBuscarCurso.Name = "txtBuscarCurso";
            txtBuscarCurso.PlaceholderText = "Buscar Curso ...";
            txtBuscarCurso.Size = new Size(144, 23);
            txtBuscarCurso.TabIndex = 1;
            txtBuscarCurso.KeyPress += txtBuscarCurso_KeyPress;
            // 
            // btnBuscarCurso
            // 
            btnBuscarCurso.BackColor = Color.DeepSkyBlue;
            btnBuscarCurso.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnBuscarCurso.FlatStyle = FlatStyle.Flat;
            btnBuscarCurso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarCurso.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarCurso.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarCurso.ImageIndex = 1;
            btnBuscarCurso.ImageList = imageListCurso;
            btnBuscarCurso.Location = new Point(243, 39);
            btnBuscarCurso.Name = "btnBuscarCurso";
            btnBuscarCurso.Size = new Size(83, 32);
            btnBuscarCurso.TabIndex = 2;
            btnBuscarCurso.Text = "  Buscar";
            btnBuscarCurso.UseVisualStyleBackColor = false;
            btnBuscarCurso.Click += btnBuscarCurso_Click;
            // 
            // pbCurso
            // 
            pbCurso.Image = Properties.Resources._6771602_book_shelf_books_education_learning_school_icon;
            pbCurso.Location = new Point(12, 12);
            pbCurso.Name = "pbCurso";
            pbCurso.Size = new Size(75, 57);
            pbCurso.SizeMode = PictureBoxSizeMode.CenterImage;
            pbCurso.TabIndex = 2;
            pbCurso.TabStop = false;
            // 
            // lbCurso
            // 
            lbCurso.AutoSize = true;
            lbCurso.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCurso.ForeColor = SystemColors.ControlLightLight;
            lbCurso.Location = new Point(93, 28);
            lbCurso.Name = "lbCurso";
            lbCurso.Size = new Size(38, 15);
            lbCurso.TabIndex = 0;
            lbCurso.Text = "Curso";
            // 
            // dgvCurso
            // 
            dgvCurso.AllowUserToAddRows = false;
            dgvCurso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgvCurso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCurso.BackgroundColor = SystemColors.ButtonHighlight;
            dgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurso.Columns.AddRange(new DataGridViewColumn[] { colId, colNome });
            dgvCurso.Location = new Point(12, 77);
            dgvCurso.MultiSelect = false;
            dgvCurso.Name = "dgvCurso";
            dgvCurso.ReadOnly = true;
            dgvCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCurso.Size = new Size(314, 256);
            dgvCurso.TabIndex = 3;
            dgvCurso.CellDoubleClick += dgvCurso_CellDoubleClick;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.ToolTipText = "Id do Curso";
            colId.Width = 30;
            // 
            // colNome
            // 
            colNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNome.DataPropertyName = "NomeCurso";
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.ToolTipText = "Nome do Curso";
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
            btnInserir.ImageList = imageListCurso;
            btnInserir.Location = new Point(12, 339);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(89, 32);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "&F10 Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.DeepSkyBlue;
            btnSelecionar.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnSelecionar.FlatStyle = FlatStyle.Flat;
            btnSelecionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelecionar.ForeColor = SystemColors.ButtonFace;
            btnSelecionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelecionar.ImageList = imageListCurso;
            btnSelecionar.Location = new Point(107, 339);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(89, 32);
            btnSelecionar.TabIndex = 5;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.IndianRed;
            btnSair.FlatAppearance.MouseDownBackColor = Color.CornflowerBlue;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSair.ForeColor = SystemColors.ButtonHighlight;
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.ImageList = imageListCurso;
            btnSair.Location = new Point(237, 339);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(89, 32);
            btnSair.TabIndex = 6;
            btnSair.Text = "&Esc Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmBuscarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(355, 392);
            Controls.Add(btnSair);
            Controls.Add(btnSelecionar);
            Controls.Add(btnInserir);
            Controls.Add(dgvCurso);
            Controls.Add(lbCurso);
            Controls.Add(pbCurso);
            Controls.Add(btnBuscarCurso);
            Controls.Add(txtBuscarCurso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "FrmBuscarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Curso";
            KeyDown += FrmCurso_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pbCurso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageListCurso;
        private TextBox txtBuscarCurso;
        private Button btnBuscarCurso;
        private PictureBox pbCurso;
        private Label lbCurso;
        private DataGridView dgvCurso;
        private Button btnInserir;
        private Button btnSelecionar;
        private Button btnSair;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
    }
}
