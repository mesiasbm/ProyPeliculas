using System.Collections.Generic;
using ProyPeliculas.Shared.Entity;
using System;
namespace ProyPeliculas.Client.Services
{
    public class ServiceMovie
    {
        List<Movie> GetMovies(){

            return new List<Movie>(){
                new Movie(){Id = 1, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 2, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 3, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 4, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 5, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 6, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 6, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 7, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 8, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) },
                new Movie(){Id = 9, Name= "Movie", Premier = new DateTime(2021, 12, 31 ) }


            };
        }

    }
}