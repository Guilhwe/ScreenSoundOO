
Grupo LinkinPark = new Grupo();
LinkinPark.Nombre = "Linkin Park";
Album albumLinkinPark = new Album();
albumLinkinPark.Nombre= "Hybrid Theory";

Musica musica1 = new Musica(LinkinPark);
musica1.Nombre = "Numb";
musica1.Duracion=200;
Musica musica2 = new Musica(LinkinPark);
musica2.Nombre="In The End";
musica2.Duracion=230;

albumLinkinPark.AgregarMusica(musica1);
albumLinkinPark.AgregarMusica(musica2);


LinkinPark.AgregarAlbum(albumLinkinPark);
LinkinPark.ExhibirDiscografia();