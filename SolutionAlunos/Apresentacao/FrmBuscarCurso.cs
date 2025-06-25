using Negocios;
using ObjetoTransferencia;
using System.ComponentModel;

namespace Apresentacao
{
    public partial class FrmBuscarCurso : Form
    {
        BindingList<Curso> listaCurso = new BindingList<Curso>();
        NegCurso nCurso = new NegCurso();



        public FrmBuscarCurso()
        {
            InitializeComponent();

        }

        //Preencher Grid DataSource
        private void MetodoPreencherGrid()
        {

            //DATA SOURCE
            //dgvCurso.AutoGenerateColumns = false;
            //dgvCurso.DataSource = null;
            //dgvCurso.DataSource = listaCurso;


            //Manualmente
            dgvCurso.Rows.Clear(); // Limpa as linhas atuais

            foreach (var curso in listaCurso)
            {
                // Adiciona uma nova linha com os valores das colunas manualmente
                int rowIndex = dgvCurso.Rows.Add(curso.Id, curso.NomeCurso);

                dgvCurso.Rows[rowIndex].Tag = curso; // Aqui você armazena o objeto inteiro
            }
        }

        #region Botões
        //Botão Sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Deseja realmente sair?",   // Mensagem
            "Sair",                      // Título da janela
             MessageBoxButtons.YesNo,    // Botões "Sim" e "Não"
             MessageBoxIcon.Question     // Ícone de interrogação
             );

            if (result == DialogResult.Yes)
            {
                this.Close(); // Fecha o formulário
            }
        }

        //Buscar Por nome do Curso
        private void btnBuscarCurso_Click(object sender, EventArgs e)
        {
            listaCurso = nCurso.BuscarCursoPorNome(txtBuscarCurso.Text);
            if (listaCurso.Count > 0)
            {
                MetodoPreencherGrid();
            }
        }

        //Selecionar Curso 
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvCurso.SelectedRows.Count > 0)
            {
                // Pega a primeira linha selecionada
                DataGridViewRow linhaSelecionada = dgvCurso.SelectedRows[0];

                // Supondo que a primeira célula dessa linha contém o Id do curso
                int idSelecionado = Convert.ToInt32(linhaSelecionada.Cells[0].Value);

                // Busca o curso na lista pelo Id
                Curso cursoSelecionado = listaCurso.FirstOrDefault(c => c.Id == idSelecionado);

                if (cursoSelecionado != null)
                { //Chama o formulario de alterar excluir

                    FrmCurso frmCurso = new FrmCurso(TipoOperacao.Alterar, cursoSelecionado);
                    
                    DialogResult result =
                    frmCurso.ShowDialog();

                    if (result == DialogResult.Yes) { btnBuscarCurso.PerformClick(); }
                }

            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            FrmCurso frmCurso = new FrmCurso(TipoOperacao.Inserir, null);

            DialogResult result =
            frmCurso.ShowDialog();

            if (result == DialogResult.Yes) { btnBuscarCurso.PerformClick(); }
        }
        #endregion

        //Criar eventos para tecla de atalho
        private void FrmCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSair.PerformClick();
                e.Handled = true; // Opcional: evita som de 'ding' ao pressionar Enter
            }
        }

        //Tecla de atalhon Buscar
        private void txtBuscarCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscarCurso.PerformClick();
                e.Handled = true; // Opcional: evita som de 'ding' ao pressionar Enter
            }
        }

        //Selecionar o objeto da lista
        private void dgvCurso_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Garante que não clicou no header
            {
                //DATA SOURCE
                //var cursoSelecionado = dgvCurso.Rows[e.RowIndex].DataBoundItem as Curso;

                // Exemplo Buscar com Linq
                //int idSelecionado = Convert.ToInt32(dgvCurso.Rows[e.RowIndex].Cells[0].Value);
                //Curso curso = listaCurso.FirstOrDefault(c => c.Id == idSelecionado);

                //Manualmente com Tag -> É um campo generico para guardar informações
                var row = dgvCurso.Rows[e.RowIndex];
                var cursoSelecionado = row.Tag as Curso;


                if (cursoSelecionado != null)
                {

                    FrmCurso frmCurso = new FrmCurso(TipoOperacao.Alterar, cursoSelecionado);

                    DialogResult result =
                    frmCurso.ShowDialog();

                    if (result == DialogResult.Yes) { btnBuscarCurso.PerformClick(); }

                }
            }
        }


    }
}
