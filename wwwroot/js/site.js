function MostrarActores(IdS,title, img)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/getActores',
            data: { IdSerie: IdS },
            success:
                function (actores)
                {
                    $("#NombreSerie").html("Serie "+title);
                    let listActores = "";
                    for (let index = 0; index < actores.length; index++) {
                        listActores += actores[index].nombre + " "; 
                    }
                    console.log(listActores);
                    $("#img-resp").attr("src",img);
                    $("#informacion").html("Actores: "+ listActores);
                }
    });
}

function MostrarInfoSerie(IdS,title,img)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/getSerie',
            data: { IdSerie: IdS },
            success:
                function (serie)
                {
                    $("#NombreSerie").html("Serie "+title);
                    $("#img-resp").attr("src",img);
                    $("#informacion").html("Año de inicio: "+ serie.añoInicio + "<br>Sinopsis: " + serie.sinopsis);
                }
    });
}

function MostrarTemporadas(IdS,title, img)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/getSeasons',
            data: { IdSerie: IdS },
            success:
                function (temporadas)
                {
                    $("#NombreSerie").html("Serie "+title);
                    $("#img-resp").attr("src",img);
                    let temps = "";
                    for (let i = 0; i < temporadas.length; i++) {
                        temps += "Temporada " + (i + 1) + ": " + temporadas[i].tituloTemporada + "<br>";
                    }
                    $("#informacion").html(temps);
                }
    });
}