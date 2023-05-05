namespace PokemonCD;
public interface IPokemon 
{
  bool Add(PokemonDto pkmn);    
  bool Delete(int id);
  bool Update(int id,PokemonDto updatedPkmn);
  IEnumerable<PokemonDto> GetAll();
}  