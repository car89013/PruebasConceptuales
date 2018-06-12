using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundo.Service
{
    public class PeliculasService
    { 
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "XXX",
                Duracion = 110,
                Publicacion = new DateTime(2018, 01, 01),
                Pais = "Mx"
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "YYY",
                Duracion = 130,
                Publicacion = new DateTime(2018, 11, 10),
                Pais = "USA"
            };
            return new List<Pelicula>()
            {
                pelicula1,pelicula2
            };
        }
    }
}