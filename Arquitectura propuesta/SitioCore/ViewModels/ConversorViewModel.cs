using Microsoft.AspNetCore.Mvc;
using ModeloCore;
using System.Collections.Generic;

namespace SitioCore.ViewModels
{
    public class ConversorViewModel
    { 
        public string IdOrigen { get; set; }
        public string IdDestino { get; set; }
        public double Precio { get; set; }
        public double Cantidad { get; set; }
        public double Resultado { get; set; }
    }
}
