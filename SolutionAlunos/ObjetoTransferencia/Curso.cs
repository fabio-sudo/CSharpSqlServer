namespace ObjetoTransferencia
{
    public class Curso
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }


        public Curso() { } // Construtor Vazio


        //Construtor
        public Curso(int id, string nome) {
        
            Id = id;
            NomeCurso = nome;
        
        }
    }

    //Operações do Formulário
    public enum TipoOperacao
    {
        Inserir,
        Alterar,
        Excluir
    }
}
