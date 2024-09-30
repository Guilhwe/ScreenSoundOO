using System.Reflection;

class Musica
{
    public string? Nombre{get; set;  }// pongo la interrogacion para marcar el campo como nullable aunque no lo vaya a ser, el public es para que la parte de la calse sea visible fuera de la calse
    public string? Artista{get; set; }
    public bool Disponible{get; set;    }
    public int Duracion{get; set;   }
    public string Resumen => $"La musica {Nombre} pertenece al artista {Artista}";// ARROW FUNCTION
   
    
    public void MostrarFichaTecnica()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duración: {Duracion}");
        if(Disponible)
        {
            Console.WriteLine("Disponible\n");
        }else{
            Console.WriteLine("No Disponible\n");
        }

    }
}
