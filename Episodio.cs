class Episodio
{
    private List<string> invitados = new List<string>();
    public Episodio(string? titulo, int orden, double duracion)
    {
        Titulo = titulo;
        Orden = orden;
        Duracion = duracion;
    }

    public string? Titulo{get; }
    public int Orden{get; }
    public double Duracion{get; }
    public string Resumen=>$"Este es el episodio {Orden} con título {Titulo} y dura {Duracion}. Los invitados son {string.Join(", ", invitados)}";

    public void AgregarInvitados(string invitado)
    {
        invitados.Add(invitado);
    }
}