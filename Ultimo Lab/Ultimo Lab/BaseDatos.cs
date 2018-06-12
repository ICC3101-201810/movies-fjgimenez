using System;
using System.Collections;
using System.Collections.Generic;
public class BaseDatos
{
    public List<Pelicula> pelicula = new List<Persona>();
    public List<Actor> actor = new List<Actor>();
    public List<Director> director = new List<Director>();
    public List<Productor> productor = new List<Productor>();
    public List<Estudio> estudio = new List<Estudio>();
    public List<PeliculaActor> peliculaactor = new List<PeliculaActor>();
    public List<PeliculaProductor> peliculaproductor = new List<PliculaProductor>();

    public BaseDatos()
	{
	}
}
