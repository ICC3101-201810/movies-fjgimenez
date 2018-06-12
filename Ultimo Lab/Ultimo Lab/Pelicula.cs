using System;

public class Pelicula
{
    public string Nombre { get; set; }
    public string Director { get; set; }
    public string FechaEstreno { get; set; }
    public string Descripcion { get; set; }
    public string Presupuesto { get; set; }
    public string Estudio { get; set; }

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
