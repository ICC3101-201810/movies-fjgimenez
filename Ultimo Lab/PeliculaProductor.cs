using System;

public class PeliculaProductor
{
    public object Pelicula { get; set; }
    public object Productor { get; set; }

    public PeliculaProductor(object Pelicula, object Productor)
	{
        this.Pelicula = Pelicula;
        this.Productor = Productor;
	}
}
