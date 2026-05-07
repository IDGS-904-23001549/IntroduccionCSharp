using System;

public class PeliculasService
{
	public List<Pelicula>ObtenerPelicula()
	{
		var pelicula1 = new Pelicula()
		{
			Titulo = "Superman",
			Duracion = 120,
			Pais = "USA",
			Publicacion = new DateTime(2013, 12, 5)
		};
		var pelicula2 = new Pelicula()
		{
			Titulo = "Spiderman",
			Duracion = 111,
			Pais = "USA",
			Publicacion = new DateTime(2015, 05, 5)
		};
		return new List<Pelicula> { pelicula1, pelicula2, };
	}
}
