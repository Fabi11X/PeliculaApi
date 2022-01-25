using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pelicula.Domain.Entities
{
    public class Movie
    {
        public int idPelicula {get;set;}

        public string tituloPelicula {get;set;}

        public string directorPelicula {get;set;}

        public string generoPelicula {get;set;}

        public int puntuacionPelicula {get;set;}

        public int ratingPelicula {get;set;}

        public int publiPelicula {get;set;}
    }
}