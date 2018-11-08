using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ForexQuotes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModeloCore;
using RepositorioCore;
using SitioCore.Models;
using SitioCore.ViewModels;

namespace SitioCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepositorio _repositorio;

        public HomeController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [Authorize]
        [HttpGet]
        public IActionResult VerMonedas()
        {
            //ActualizarMonedas();
            var listaMonedas = _repositorio.ObtenerMonedas();
            if (listaMonedas.Count == 0)
            {
                ActualizarMonedas();
                ActualizarFactores();
            }
            else
            {
                ActualizarFactores();
            }

            var homeViewModel = new HomeViewModel
            {
                Titulo = "Calculin",
                ListaMonedas = listaMonedas,
                ImagenMoneda = "https://www.worldatlas.com/r/w728-h425-c728x425/upload/d0/91/86/shutterstock-403371907.jpg"
            };

            return View(homeViewModel);
        }

        [Authorize]
        public IActionResult DetalleMoneda(int id)
        {
            var moneda = _repositorio.BuscarMonedaPorId(id);
            if (moneda == null)
                return NotFound();

            return View(moneda);
        }


        [Authorize]
        [HttpPost]
        public IActionResult DetalleMoneda(Moneda moneda)
        {
            if (ModelState.IsValid)
            {
                _repositorio.ActualizarMoneda(moneda);
                return RedirectToAction("VerMonedas");
            }
            return View(moneda);
        }

        [Authorize]
        [HttpPost]
        public IActionResult VerConversor(HomeViewModel model)
        {
            var cantidad = model.Cantidad;
            var idOrigen = _repositorio.BuscarMonedaPorSigla(model.IdOrigen);
            var idDestino = _repositorio.BuscarMonedaPorSigla(model.IdDestino);
            var factor = _repositorio.BuscarFactorConversion(idOrigen, idDestino);

            if (factor != null)
            {
                cantidad = model.Cantidad * factor.Factor;
            }
            var conversor = new ConversorViewModel { Cantidad = model.Cantidad, Resultado = cantidad, IdOrigen = model.IdOrigen, IdDestino = model.IdDestino, Precio = factor.Factor };
            return View(conversor);
        }

        public IActionResult Index()
        {
            //ActualizarMonedas();
            return View();
        }
        public IActionResult ActualizarFactores()
        {
            var client = new ForexDataClient("UqGdNXCYs3QMuKLRfzURoseh8okx8hAY");
            var symbols = client.GetSymbols();
            var quotes = client.GetQuotes(symbols);

            foreach (var quote in quotes)
            {
                UpdateQuote(quote);
            }
            return View();
        }
        public IActionResult ActualizarMonedas()
        {
            var client = new ForexDataClient("UqGdNXCYs3QMuKLRfzURoseh8okx8hAY");
            var symbols = client.GetSymbols();
            var quotes = client.GetQuotes(symbols);

            foreach (var symbol in symbols)
            {
                Extraer(symbol, 0);
                Extraer(symbol, 3);
            }

            foreach (var quote in quotes)
            {
                UpdateQuote(quote);
            }
            ViewBag.NumeroMonedas = symbols.Length;
            return View();
        }

        private void UpdateQuote (Quote quote)
        {
            var origen = quote.symbol.Substring(0, 3);
            var destino = quote.symbol.Substring(3, 3);
            var factor = new FactorConversion {IdMonedaOrigen = _repositorio.BuscarMonedaPorSigla(origen), IdMonedaDestino = _repositorio.BuscarMonedaPorSigla(destino), Factor = quote.price};
            _repositorio.CrearFactor(factor);
        }

        private void Extraer(string symbol, int pos)
        {
            var left = symbol.Substring(pos, 3);

            var moneda = new Moneda { IdentificadorMoneda = left, Nombre = left};
            _repositorio.CrearMoneda(moneda);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}