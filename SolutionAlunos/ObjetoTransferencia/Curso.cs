namespace ObjetoTransferencia
{
    public class Curso
    {
        public int Id { get; set; }
        public string NomeCurso { get; set; }



        //Construtor
        public Curso(int id, string nome) {
        
            Id = id;
            NomeCurso = nome;
        
        }
    }
}
