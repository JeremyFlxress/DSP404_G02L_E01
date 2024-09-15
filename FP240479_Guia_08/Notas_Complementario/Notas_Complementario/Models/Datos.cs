namespace Notas_Complementario.Models
{
    public class Alumno
    {
        public string Codigo_alumno { get; set; }
        public string Nombre_alumno { get; set; }
    }

    public class Curso
    {
        public string Codigo_curso { get; set; }
        public string Nombre_curso { get; set; }
    }

    public class Nota
    {
        public string Codigo_alumno { get; set; }
        public string Codigo_curso { get; set; }
        public float Nota40T { get; set; }
        public float Nota60L { get; set; }
        public float NotaFinal { get; set; }
    }
}
