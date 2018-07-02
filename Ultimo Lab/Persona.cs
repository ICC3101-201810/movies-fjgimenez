using System;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string FechaNacimiento { get; set; }
    public string Biografia { get; set; }

    public Persona(string Nombre, string Apellido, string FechaNacimiento, string Biografia)
	{
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.FechaNacimiento = FechaNacimiento;
        this.Biografia = Biografia;
	}
}
