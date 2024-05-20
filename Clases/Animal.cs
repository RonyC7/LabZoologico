namespace Lab15Zoologico.Clases 
{
    public class Animal
    {
        public string NombrePropio { get; set; }
        public string Especie { get; set; }
        public string TipoAlimentacion { get; set; }
        public int TiempoMaximoVida { get; set; }
    }

    public class Ave : Animal
    {
        public bool Vuela { get; set; }
        public int PeriodoIncubacion { get; set; }
    }

    public class Serpiente : Animal
    {
        public bool Venenosa { get; set; }
        public float LongitudMaxima { get; set; }
    }
}
