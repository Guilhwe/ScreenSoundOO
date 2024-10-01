Album albumLinkinPark = new Album();
albumLinkinPark.Nombre= "Hybrid Theory";

Musica musica1 = new Musica();
musica1.Nombre = "Numb";
musica1.Duracion=200;
Musica musica2 = new Musica();
musica2.Nombre="In The End";
musica2.Duracion=230;

albumLinkinPark.AgregarMusica(musica1);
albumLinkinPark.AgregarMusica(musica2);

Grupo LinkinPark = new Grupo();
LinkinPark.Nombre = "Linkin Park";
LinkinPark.AgregarAlbum(albumLinkinPark);
LinkinPark.ExhibirDiscografia();