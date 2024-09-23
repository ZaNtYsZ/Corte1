using System;

namespace corte1

public class Registro
{
    private Persona[] personas;
    private int contador;

    public Registro()
    {
        personas = new Persona[30];
        contador = 0;
    }

    public void AgregarPersona(Persona persona)
    {
        if (contador < 30)
        {
            personas[contador] = persona;
            contador++;
        }
        else
        {
            throw new Exception("No se pueden agregar más personas, el registro está lleno.");
        }
    }

    public Persona ObtenerPersona(int index)
    {
        if (index >= 0 && index < contador)
        {
            return personas[index];
        }
        throw new Exception("Persona no encontrada.");
    }

    public int TotalPersonas()
    {
        return contador;
    }

    public Persona[] ObtenerTodasLasPersonas()
    {
        return personas;
    }
}
