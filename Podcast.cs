class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nombre, string host)
    {
        Nombre=nombre;
        Host=host;

    }
    public string Nombre{get;}
    public string Host{get;}
    public int TotalEpisodios=>episodios.Count;

    public void AgregarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void MostrarDetallesPodcast()
    {
        Console.WriteLine($"El Podcast {Nombre} es llevado a cabo por {Host}");
        foreach(Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumen);
        }
        Console.WriteLine ($"Este podcast tierne {TotalEpisodios} episodios.");
    }

}