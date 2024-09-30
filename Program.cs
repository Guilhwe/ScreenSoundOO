Musica musica1 = new Musica();
musica1.Nombre="Numb";
musica1.Artista="Linkin Park";
musica1.Duracion= 222;
musica1.Disponible=true;
Console.WriteLine(musica1.Resumen);


Musica musica2 = new Musica();

musica2.Nombre="La Jumpa";
musica2.Artista="BadBunny";
musica2.Duracion= 300;
musica2.Disponible=false;


musica1.MostrarFichaTecnica();
musica2.MostrarFichaTecnica();

