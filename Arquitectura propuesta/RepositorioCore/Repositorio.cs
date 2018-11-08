using System.Collections.Generic;
using System.Linq;
using ContextoCore;
using InfraestructuraCore;
using ModeloCore;

namespace RepositorioCore
{
    public class Repositorio : IRepositorio
    {
        private readonly MonedaDb _contexto;

        public Repositorio(MonedaDb contexto)
        {
            _contexto = contexto;
            ListaMonedas = new List<Moneda>();
        }

        // U - UPDATE
        public void ActualizarMoneda(Moneda moneda)
        {
            var buscarMoneda = BuscarMonedaPorId(moneda.Id);
            if (buscarMoneda != null)
            {
                buscarMoneda.Nombre = moneda.Nombre;
                buscarMoneda.IdentificadorMoneda = moneda.IdentificadorMoneda;
                _contexto.SaveChanges();
            }
        }

        public void ActualizarFactor(FactorConversion factor)
        {
            var buscarFactor = BuscarFactorConversion(factor.IdMonedaOrigen, factor.IdMonedaDestino);
            if(buscarFactor != null)
            {
                buscarFactor.IdMonedaOrigen = factor.IdMonedaOrigen;
                buscarFactor.IdMonedaDestino = factor.IdMonedaDestino;
                buscarFactor.Factor = factor.Factor;
                _contexto.SaveChanges();
            }
        }

        public void ActualizarPais (Pais pais)
        {
            var buscarPais = BuscarPaisPorId(pais.Id);
            if (buscarPais != null)
            {
                buscarPais.IdPais = pais.IdPais;
                buscarPais.Nombre = pais.Nombre;
                _contexto.SaveChanges();
            }
        }


        // D - DELETE

        public void BorrarMoneda(Moneda moneda)
        {
            var buscarMoneda = BuscarMoneda(moneda.IdentificadorMoneda);
            if (buscarMoneda == null) return;
            _contexto.Monedas.Remove(buscarMoneda);
            _contexto.SaveChanges();
        }

        public void BorrarFactor(FactorConversion factor)
        {
            var buscarFactor = BuscarFactorPorId(factor.id);
            if (buscarFactor == null) return;
            _contexto.FactoresConversion.Remove(factor);
            _contexto.SaveChanges();
        }

        public void BorrarPais (Pais pais)
        {
            var buscarPais = BuscarPaisPorId(pais.Id);
            if (buscarPais == null) return;
            _contexto.Paises.Remove(pais);
            _contexto.SaveChanges();
        }

        public void BorrarHistorial(Historial historial)
        {
            throw new System.NotImplementedException();
        }

        public Moneda BuscarMoneda(string IdMoneda)
        {
            return _contexto.Monedas.FirstOrDefault(
                p => p.IdentificadorMoneda == IdMoneda);
        }

        public FactorConversion BuscarFactorConversion(int origen, int destino)
        {
            return _contexto.FactoresConversion.FirstOrDefault(p => (p.IdMonedaOrigen == origen) && (p.IdMonedaDestino == destino));
        }

        public Pais BuscarPais(string idPais)
        {
            return _contexto.Paises.FirstOrDefault(p => p.IdPais == idPais);
        }

        public Moneda BuscarMonedaPorId(int IdMoneda)
        {
            return _contexto.Monedas.FirstOrDefault(
                p => p.Id == IdMoneda);
        }

        public FactorConversion BuscarFactorPorId(int idFactor)
        {
            return _contexto.FactoresConversion.FirstOrDefault(p => p.id == idFactor);
        }

        public Pais BuscarPaisPorId(int IdPais)
        {
            return _contexto.Paises.FirstOrDefault(
                p => p.Id == IdPais);
        }

        // C - CREATE

        public void CrearMoneda(Moneda moneda)
        {
            var buscarMoneda = BuscarMonedaPorSigla(moneda.IdentificadorMoneda);
            var mon = BuscarMonedaPorId(buscarMoneda);
            // Comprueba si ha encontrado la moneda
            if (mon != null)
            {
                // Ha encontrado la moneda
                // La actualizamos
                moneda.Id = mon.Id;
                ActualizarMoneda(moneda);
            }
            else
            {
                // No ha encontrado la moneda
                // Creamos la moneda
                _contexto.Monedas.Add(moneda);
                _contexto.SaveChanges();
            }
        }

        public void CrearFactor(FactorConversion factor)
        {
            var buscarFactor = BuscarFactorConversion(factor.IdMonedaOrigen, factor.IdMonedaDestino);
            if (buscarFactor != null)
            {
                ActualizarFactor(factor);
            }
            else
            {
                _contexto.FactoresConversion.Add(factor);
                _contexto.SaveChanges();
            }
        }

        public void CrearPais(Pais pais)
        {
            var buscarPais = BuscarPais(pais.IdPais);
            if (buscarPais != null)
            {
                ActualizarPais(pais);
            }
            else
            {
                _contexto.Paises.Add(pais);
                _contexto.SaveChanges();
            }

        }

        public void CrearHistorial(Historial historial)
        {
            _contexto.Histrorial.Add(historial);
            _contexto.SaveChanges();
        }

        public List<Moneda> GetMonedas()
        {
            return new List<Moneda>();
        }

        public void GetPaises()
        {
            ListaPaises = Seed.CrearListaPaises();
            foreach (var pais in ListaPaises)
            {
                CrearPais(pais);
            }
        }

        public List<Moneda> ListaMonedas { get; set; }
        public List<FactorConversion> ListaFactores { get; set; }
        public List<Pais>ListaPaises { get; set; }

        // R - RETRIEVE
        public List<Moneda> ObtenerMonedas()
        {
            return _contexto.Monedas.ToList();
        }

        public List<FactorConversion> Obtenerfactores()
        {
            return _contexto.FactoresConversion.ToList();
        }

        public List<Pais> ObtenerPaises()
        {
            GetPaises();
            return _contexto.Paises.ToList();
        } 

        public int BuscarMonedaPorSigla(string IdMoneda)
        {
            Moneda mon = _contexto.Monedas.FirstOrDefault(
                p => p.IdentificadorMoneda == IdMoneda);
            if (mon == null)
            {
                return -1;
            }
            return mon.Id;
        }

       

      

        

        public List<Historial> ObtenerHistorial(string Usuario)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
