using DataBaseMemory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DataBaseMemory.DataContext.Data
{
    public static class DbInitializer
    {

        public static void Initializer(IServiceProvider serviceProvider)
        {
            using (var context = new AppDataContext(serviceProvider.GetRequiredService<DbContextOptions<AppDataContext>>()))
            {
                //Agregando Artistas ala BD:
                if (context.Artistas.Any())
                {
                    return;
                }

                context.Artistas.AddRange
                    (
                    new Artista { Nombre = "Luis Miguel" },
                    new Artista { Nombre = "Ricardo Argona" },
                    new Artista
                    {
                        Nombre = "Kalimba"
                    });
                context.SaveChanges();

                //Agregando Albumes a la BD:
                if (context.Albums.Any())
                {
                    return;
                }

                context.Albums.AddRange
                    (
                        new Album
                        {
                            ArtistaId = context.Artistas.FirstOrDefault(a => a.Nombre.Equals("Kalimba")).ArtistaId,
                            Titulo = "Mi Otro YO",
                            Precio = 555,
                        },

                        new Album
                        {
                            ArtistaId = context.Artistas.FirstOrDefault(a => a.Nombre.Equals("Kalimba")).ArtistaId,
                            Titulo = "Aerosoul",
                            Precio = 275,
                        },

                        new Album
                        {
                            ArtistaId = context.Artistas.FirstOrDefault(a => a.Nombre.Equals("Ricardo Argona")).ArtistaId,
                            Titulo = "Circo solead",
                            Precio = 180,
                        },

                          new Album
                          {
                              ArtistaId = context.Artistas.FirstOrDefault(a => a.Nombre.Equals("Luis Miguel")).ArtistaId,
                              Titulo = "Romance",
                              Precio = 290,
                          }
                              
                     );

                context.SaveChanges();
            }

           
        }

    }
}
