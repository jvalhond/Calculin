using System;

namespace ModeloCore
{   
    public class Historial
    {
        //[Key]
        public int Id { get; set; }  
        public string Idusuario { get; set; }
        public int MonedaOrigen { get; set; }
        public int MonedaDestino { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }
        public double Factor { get; set; }
        public double Resultado { get; set; }

    }
}
