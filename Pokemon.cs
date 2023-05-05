namespace PokemonCD;
using System.Collections.Generic;
public class Pokemon : IPokemon{
private List<PokemonDto> BD;

public Pokemon()
{
    this.BD = new List<PokemonDto>();
}
public void Add(PokemonDto Pokemon)
{
    this.BD.Add(Pokemon);
}

public void Delete(int id)
{
    this.BD.RemoveAll(Pokemon => Pokemon.Id == id);
}

public void Update(int id, PokemonDto Pokemon)
{
    PokemonDto pokemonUpdate=this.BD.Single((Pokemon => Pokemon.Id == id));
    pokemonUpdate.Nombre= Pokemon.Nombre;
    pokemonUpdate.Tipo= Pokemon.Tipo;
    pokemonUpdate.Defensa= Pokemon.Defensa;
}       

public PokemonDto GetId(int id){
    return this.BD.Single(pokemon => pokemon.Id == id);

}
public IEnumerable<PokemonDto> portipo(String Tipo){
return this.BD.Where(Pokemon => Pokemon.Tipo == Tipo);
}

public IEnumerable<PokemonDto> OrderedByName(){
    return this.BD.OrderBy(Pokemon => Pokemon.Nombre);
}

public IEnumerable<PokemonDto> OrderedParaAbajo(){
    return this.BD.OrderByDescending(Pokemon => Pokemon.Nombre);
}

public IEnumerable<PokemonDto> PorDefensa(){
    return this.BD.OrderByDescending(Pokemon => Pokemon.Defensa);
}



    bool IPokemon.Add(PokemonDto pkmn)
    {
        throw new NotImplementedException();
    }

    bool IPokemon.Delete(int id)
    {
        throw new NotImplementedException();
    }

    bool IPokemon.Update(int id, PokemonDto updatedPkmn)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<PokemonDto> GetAll()
    {
        throw new NotImplementedException();
    }
} 
