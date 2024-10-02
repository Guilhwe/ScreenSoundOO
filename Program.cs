
Grupo LinkinPark = new Grupo("Linkin Park");

Album albumLinkinPark = new Album("Hybrid Theory");


Musica musica1 = new Musica(LinkinPark, "Numb")
{
    Duracion = 200,
    Disponible = true
};


Musica musica2 = new Musica(LinkinPark,"In The End")
{
    Duracion=230,
    Disponible=false
};


albumLinkinPark.AgregarMusica(musica1);
albumLinkinPark.AgregarMusica(musica2);
LinkinPark.AgregarAlbum(albumLinkinPark);

albumLinkinPark.ExhibirAlbum();

musica1.MostrarFichaTecnica();
musica2.MostrarFichaTecnica();


LinkinPark.ExhibirDiscografia();
