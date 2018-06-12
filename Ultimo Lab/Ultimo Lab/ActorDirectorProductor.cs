using System;

public class Actor: Persona
{
	public Actor(string Nombre, string Apellido, string FechaNacimiento, string Biografia)
	{
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.FechaNacimiento = FechaNacimiento;
        this.Biografia = Biografia;
    }
}

public class Director : Persona
{
    public Director(string Nombre, string Apellido, string FechaNacimiento, string Biografia)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.FechaNacimiento = FechaNacimiento;
        this.Biografia = Biografia;
    }
}

public class Productor : Persona
{
    public Productor(string Nombre, string Apellido, string FechaNacimiento, string Biografia)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.FechaNacimiento = FechaNacimiento;
        this.Biografia = Biografia;
    }
}


