using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pelicula.Infraestructure.Repositories;
using Pelicula.Domain.Entities;

namespace Pelicula.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeliculaController : ControllerBase
    {
        [HttpGet]
        [Route("ObtenerPelicula")]

        public IActionResult ObtenerPelicula()
        {
            PeliculaRepositorie pelis = new PeliculaRepositorie();
            return Ok(pelis.ObtenerPelicula());
        }


        [HttpGet]
        [Route("Buscar")]

        public IActionResult ObtenerId(int id)
        {
            PeliculaRepositorie pelis = new PeliculaRepositorie();
            var peli = pelis.ObtenerId(id);
            if (peli == null)
            {
                return NotFound($"El id {id} no existe de la pelicula");

            } 
            return Ok (peli);
            
        }


         [HttpPost]
        [Route("Crear")]

        public IActionResult CrearPelicula (Movie peliculaNueva)
        {
            PeliculaRepositorie pelis = new PeliculaRepositorie();
            pelis.CrearPelicula(peliculaNueva);
            return Ok("Pelicula agregada");
        }

          [HttpPut]
        [Route("Modificar")]

        public IActionResult ModificarPelicula (int id, Movie modificarPeli)
        {
            PeliculaRepositorie pelis = new PeliculaRepositorie();
            var actualizar = pelis.ObtenerId(id);
            if (actualizar == null)
            {
                return NotFound($"Ingresaste el Id {id}, no existe la pelicula");

            }

            pelis.ModificarPelicula(id, modificarPeli);
            return Ok("Se actualizo correctamente la pelicula");

        }

          [HttpDelete]
        [Route("Borrar")]

        public IActionResult BorrarPelicula (int id)
        {
            PeliculaRepositorie pelis = new PeliculaRepositorie();
            var actuali = pelis.ObtenerId(id);
            if (actuali == null)
            {
                return NotFound($"Ingresaste el Id {id}, no existe la pelicula");
            }
            pelis.BorrarPelicula(id);
            return Ok($"La pelicula con Id {id}, se ha eliminado correctamente");
        }

        [HttpGet]
        [Route("BuscarDirector")]

        public IActionResult ObtenerDirect (string direc)
        {
            PeliculaRepositorie pelis = new PeliculaRepositorie();
            var peli = pelis.ObtenerDirector(direc);
            if (peli.Count() == 0)
            {
                return NotFound($"El director {direc}, no existe");
            }
            return Ok(peli);

        }

    }
}