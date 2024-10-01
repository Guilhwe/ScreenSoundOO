class Grupo
 {
    private List<Album> albums = new List<Album>();  
    public string? Nombre {get; set;}
    public void AgregarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ExhibirDiscografia()
    {
        Console.WriteLine($"Discografia de la banda {Nombre}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album : {album.Nombre} ({album.DuracionTotal})");
        }

    }
 }