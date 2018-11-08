using System.Collections.Generic;
using ModeloCore;

namespace SitioCore.ViewModels
{
    public class HomeViewModel
    {
        public List<Moneda> ListaMonedas { get; set; }

        public string Titulo { get; set; }

        public string ImagenMoneda { get; set; }

        public string IdOrigen { get; set; }
        public string IdDestino { get; set; }
        public double Cantidad { get; set; }

    }
}
