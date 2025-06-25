using Negocios;
using ObjetoTransferencia;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmCurso : FrmModelo
    {
        //objetos
        private TipoOperacao tipoOperacao;
        private Curso cursoSelecionado;
        NegCurso nCurso = new NegCurso();

        //Construtor
        public FrmCurso(TipoOperacao tipo, Curso curso)
        {
            InitializeComponent();

            //Recebendo Parâmetros
            tipoOperacao = tipo;
            cursoSelecionado = curso;
        }

        #region Metodos 

        //métodos de incialização
        private void MetodoFormularioAlterarExcluir()
        {
            txtId.ReadOnly = false;
            btnExcluir.Visible = true;
            btnInserir.Text = "&F10 Alterar";
            btnInserir.BackColor = Color.DodgerBlue;
            lbTitulo.Text = "Alteração - Eclusão de Cursos";
        }

        private void MetodoFormularioInserir()
        {
            txtId.Enabled = false;
            btnExcluir.Visible = false;
            btnInserir.Text = "&F10 Inserir";
            btnInserir.BackColor = Color.LightGreen;
            lbTitulo.Text = "Cadastro de Cursos";
        }

        //Metodos tratamento dos dados do formulário
        private void MetodoPreencherCampos()
        {

            txtId.Text = cursoSelecionado.Id.ToString();
            txtNome.Text = cursoSelecionado.NomeCurso.ToString();
        }

        private bool MetodoValidaCampos()
        {

            errorProviderCurso.Clear(); // Limpa erros anteriores


            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                errorProviderCurso.SetError(txtNome, "Informe o nome do curso.");

                MessageBox.Show("Informe o nome do curso.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else
            {

                errorProviderCurso.Clear(); // Limpa erros anteriores
                return true;
            }

        }

        private void MetodoLimpaCampos()
        {
            txtNome.Text = "";
            txtId.Text = "";
            txtNome.Focus();
        }

        //Métodos manipulação Camada de Negócios
        private void MetodoInserirAlterar()
        {
            //Inserir
            if (tipoOperacao == TipoOperacao.Inserir)
            {
                Curso curso = new Curso();
                curso.NomeCurso = txtNome.Text;

                if (nCurso.CadastrarCurso(curso) == true)
                {
                    DialogResult dialogResult =
                    MessageBox.Show("Cadastro realizado com sucesso.\n" +
                               "Deseja continuar cadastrando?", "Sucesso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        MetodoLimpaCampos();
                    }
                    else
                    {
                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o cadastro.", "Erro",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Alterar
            else
            {
                Curso curso = new Curso();
                curso.Id = Convert.ToInt32(txtId.Text);
                curso.NomeCurso = txtNome.Text;

                if (nCurso.AtualizarCurso(curso) == true)
                {
                    DialogResult dialogResult =
                    MessageBox.Show("Atualização realizado com sucesso.\n" +
                               "Atualizações finalizadas?", "Sucesso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao realizar o alteração.", "Erro",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MetodoExcluirCurso()
        {

            if (nCurso.ExcluirCurso(cursoSelecionado) == true)
            {
                MessageBox.Show("Exclusão realizado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao realizar o cadastro.", "Erro",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion


        #region Eventos do Formulário
        //Evento inicialização do Form
        private void FrmCurso_Load(object sender, EventArgs e)
        {
            if (tipoOperacao == TipoOperacao.Alterar || tipoOperacao == TipoOperacao.Excluir)
            {
                MetodoPreencherCampos();
                MetodoFormularioAlterarExcluir();
            }

            else
            {
                MetodoFormularioInserir();
            }

        }

        //Inserir ou Alterar
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                //Valida campos
                if (MetodoValidaCampos() == true)
                {
                    DialogResult dialogResult =
                    MessageBox.Show("Deseja realmente " + tipoOperacao + " ?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogResult == DialogResult.Yes)
                    {
                        MetodoInserirAlterar();
                    }
                    else { return; }
                }
            }//Captura de Excessão para não travar o software
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Realizar Exclusão
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult =
                   MessageBox.Show("Deseja realmente excluir o Curso ?", "Confirmação",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    MetodoExcluirCurso();
                }
                else { return; }
            }

            //Captura de Excessão para não travar o software
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Sai do formulário
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

        #endregion

        //Teclas de Atalho
        private void FrmCurso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnSair.PerformClick();
                e.Handled = true; // Opcional: evita som de 'ding' ao pressionar Enter
            }
            if (e.KeyCode == Keys.F10)
            {
                btnInserir.PerformClick();
                e.Handled = true; // Opcional: evita som de 'ding' ao pressionar Enter
            }
            if (e.KeyCode == Keys.F2)
            {
                btnExcluir.PerformClick();
                e.Handled = true; // Opcional: evita som de 'ding' ao pressionar Enter
            }
        }
    }
}
