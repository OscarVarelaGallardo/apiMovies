using System;
using Microsoft.AspNetCore.Mvc;
using peliculasApi.Entidades;
using peliculasApi.Entidades.Repositorios;
namespace peliculasApi.Controllers
{
	[Route("api/generos")]
	public class GenerosController
	{
        private IRepositorio repositorio;

        public GenerosController(IRepositorio repositorio)
		{
			this.repositorio = repositorio;
		}
		[HttpGet]
		public List<Genero> Get() {

			return repositorio.ObtenerTodosLosGeneros();
		}
	}
}

