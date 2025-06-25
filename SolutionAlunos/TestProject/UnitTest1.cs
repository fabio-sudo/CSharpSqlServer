using ObjetoTransferencia;
using Negocios;

namespace TestProject
{
    public class CursoTests
    {
        private NegCurso negCurso;

        [SetUp]
        public void Setup()
        {
            negCurso = new NegCurso();
        }

        [Test]
        public void DeveRetornarTrueAoCadastrarCursoValido()
        {
            // Arrange
            Curso novoCurso = new Curso
            {
                NomeCurso = "Curso Teste"
            };

            // Act
            bool resultado = negCurso.CadastrarCurso(novoCurso);

            // Assert
            Assert.IsTrue(resultado, "Esperado que o cadastro retorne true para curso válido.");
        }
    }
}
