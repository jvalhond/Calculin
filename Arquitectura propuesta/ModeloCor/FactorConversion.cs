
namespace ModeloCore
{
    public class FactorConversion
    {
        //[Key]
        public int id { get; set; }
        public int IdMonedaOrigen { get; set; }
        public int IdMonedaDestino { get; set; }
        //[ForeignKey(nameof(IdMonedaOrigen))]
        //public Moneda MonedaOrigen { get; set; }
        //[ForeignKey(nameof(MonedaDestino))]
        //public Moneda MonedaDestino { get; set; }
        public double Factor { get; set; }
    }
}
