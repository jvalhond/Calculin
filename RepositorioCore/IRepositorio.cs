using ModeloCore;
using System.Collections.Generic;

namespace RepositorioCore
{
    public interface IRepositorio
    {
        List<Moneda> GetMonedas();
        List<Moneda> ListaMonedas { get; set; }
        List<FactorConversion> ListaFactores { get; set; }
        Moneda BuscarMonedaPorId(int IdMoneda);
        Pais BuscarPaisPorId(int idPais);
        Moneda BuscarMoneda(string IdMoneda);
        Pais BuscarPais(string idPais);
        int BuscarMonedaPorSigla(string IdMoneda);
        FactorConversion BuscarFactorPorId(int idFactor);
        FactorConversion BuscarFactorConversion(int origen, int destino);
        void CrearMoneda(Moneda moneda);
        void CrearFactor(FactorConversion factor);
        void CrearPais(Pais pais);
        void CrearHistorial(Historial historial);
        List<Moneda> ObtenerMonedas();
        List<FactorConversion> Obtenerfactores();
        List<Pais> ObtenerPaises();
        List<Historial> ObtenerHistorial(string Usuario);
        void ActualizarMoneda(Moneda moneda);
        void ActualizarFactor(FactorConversion factor);
        void BorrarMoneda(Moneda moneda);
        void BorrarFactor(FactorConversion factor);
        void BorrarPais(Pais pais);
        void BorrarHistorial(Historial historial);
    }
}
