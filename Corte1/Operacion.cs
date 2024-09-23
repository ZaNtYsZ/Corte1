using System;

namespace Corte1

public class Operacion
{
    public int CalcularEdad(Persona persona)
    {
        DateTime hoy = DateTime.Now;
        int edad = hoy.Year - persona.FechaNacimiento.Year;

        if (persona.FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;

        return edad;
    }

    public bool EsMayorDeEdad(Persona persona)
    {
        return CalcularEdad(persona) >= 18;
    }
}

