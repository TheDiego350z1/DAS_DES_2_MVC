using Microsoft.AspNetCore.Mvc;
using DAS_DES_2_MVC.Models;
using System;

namespace DAS_DES_2_MVC.Controllers
{
    public class PeliculasController : Controller
    {
        public IActionResult Index()
        {
            var pelicula = new PeliculasModel();
            pelicula.IdPelicula = Guid.NewGuid().ToString();
            pelicula.NombrePelicula = "Una pelicula bien mamalona";
            pelicula.DescipcionPelicula = "Es una descripción bastante creible de una super producción que gano todos los premios";
            pelicula.GeneroPelicula = "¿Importa el genero?";
            pelicula.DirectorPelicula = "Un gran director que te conmueve el corazón";

            return View(pelicula);
        }
        
    }
}