using PokemonCD;
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        Pokemon Pokemon = new Pokemon();

        app.MapPost("/api/v1/taller", (PokemonDto pokemon) =>
        {
            Pokemon.Add(pokemon);
        });

        app.MapPut("/api/v1/taller/actualizar/{id}", (int id, PokemonDto pokemon) =>
        {
            Pokemon.Update(id, pokemon);
        }); 

        app.MapGet("/api/v1/taller/solo/{id}", (int id) =>
        {
            return Results.Ok(Pokemon.GetId(id));
        });

        app.MapGet("/api/v1/taller/tipo/{tipo}", (string Tipo) =>
        {
            return Results.Ok(Pokemon.portipo(Tipo)); 
        });

        app.MapPost("/api/v1/taller/addvarios", (PokemonDto[] pokemonDTO) =>
        {
            for (int i = 0; i <= pokemonDTO.Length - 1; i++)
            {
                Pokemon.Add(pokemonDTO[i]);
            }

        });

        app.MapDelete("/api/v1/taller/delete/{id}", (int id) =>
        {
            Pokemon.Delete(id);
        });

       //Personalizados
    
    //01: En teoria  este los ordena alfabeticamente
        app.MapGet("/api/v1/taller/orderby", () =>
        {
            return Results.Ok(Pokemon.OrderedByName());
        });
    //02: Lo mismo del otro pero de la z a la a
         app.MapGet("/api/v1/taller/orderdesc", () =>
        {
            return Results.Ok(Pokemon.OrderedParaAbajo());
        });
    //03: Para filtrar por defensa
         app.MapGet("/api/v1/taller/defensivo", () =>
        {
            return Results.Ok(Pokemon.PorDefensa());
        });
        app.Run();
    }
    
}