using System;

public class Estudio
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string FechaApertura { get; set; }

    public Estudio(string Nombre, string Direccion, string FechaApertura)
    {
        this.Nombre = Nombre;
        this.Direccion = Direccion;
        this.FechaApertura = FechaApertura;
    }
}
