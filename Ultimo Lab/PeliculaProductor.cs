using System;

public class PeliculaProductor
{
    public string NombrePelicula { get; set; }
    public string NombreProductor { get; set; }
    public string ApellidoProductor { get; set; }

    public PeliculaProductor(string NombrePelicula, string NombreProductor, string ApellidoProductor)
	{
        this.NombrePelicula = NombrePelicula;
        this.NombreProductor = NombreProductor;
        this.ApellidoProductor = ApellidoProductor;
    }
}
