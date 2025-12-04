namespace GestorTareas
{
    public class Tarea
    {
        // PROPIEDADES (Datos)
        public string Descripcion { get; set; }
        public bool EstaCompletada { get; set; }

        // CONSTRUCTOR (Inicialización)
        public Tarea(string descripcion)
        {
            Descripcion = descripcion;
            EstaCompletada = false; // Al crearla, siempre nace incompleta
        }
    }
}