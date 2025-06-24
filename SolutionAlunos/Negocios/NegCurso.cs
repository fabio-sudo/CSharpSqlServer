using AcessoDados;
using Microsoft.Data.SqlClient;
using ObjetoTransferencia;
using System.ComponentModel;
using System.Data;

namespace Negocios
{
    public class NegCurso
    {
        private ConexaoSqlServer sqlserver = new ConexaoSqlServer();

        // Cadastrar Curso
        public bool CadastrarCurso(Curso curso)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new SqlParameter("@nomeCurso", curso.NomeCurso));

                string comando = "exec uspInserirCurso  @nomeCurso";
                object resposta = sqlserver.ExecutarScalar(comando, CommandType.Text);

                return Convert.ToInt32(resposta) == 1;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar curso: " + ex.Message);
            }
        }

        // Atualizar curso
        public bool AtualizarCurso(Curso curso)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new SqlParameter("@Id", curso.Id));
                sqlserver.AdicionarParametro(new SqlParameter("@Nome", curso.NomeCurso));

                sqlserver.ExecutarScalar("exec uspAtualizarCurso @Id, @Nome", CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar curso. Motivo: " + ex.Message);
            }
        }

        // Excluir curso
        public bool ExcluirCurso(Curso curso)
        {
            try
            {
                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new SqlParameter("@Id", curso.Id));

                sqlserver.ExecutarScalar("exec uspExcluirCurso @Id", CommandType.Text);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir curso. Motivo: " + ex.Message);
            }
        }


        // Buscar curso por nome 
        public BindingList<Curso> BuscarCursoPorNome(string nome)
        {
            try
            {
                DataTable tabelaResultado;
                BindingList<Curso> cursos = new BindingList<Curso>();

                sqlserver.LimparParametros();
                sqlserver.AdicionarParametro(new SqlParameter("@Nome", nome));

                string comando = "exec uspListarCursos @Nome";

                tabelaResultado = sqlserver.ExecutarConsulta(comando, CommandType.Text);

                foreach (DataRow registro in tabelaResultado.Rows)
                {
                    Curso curso = new Curso(
                        Convert.ToInt32(registro["Id"]),
                        registro["NomeCurso"].ToString()
                    );

                    cursos.Add(curso);
                }

                return cursos;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível buscar cursos. Motivo: " + ex.Message);
            }
        }


    }
}