using System;

public class Pelicula
{
    string Nombre;
    string Director;
    string FechaEstreno;
    string Descripcion;
    string Presupuesto;
    string Estudio;

    public Pelicula(string Nombre, string Director, string FechaEstreno, string Descripcion, 
        string Presupuesto, string Estudio)
	{
        this.Nombre = Nombre;
        this.Director = Director;
        this.FechaEstreno = FechaEstreno;
        this.Descripcion = Descripcion;
        this.Presupuesto = Presupuesto;
        this.Estudio = Estudio;
	}
}
