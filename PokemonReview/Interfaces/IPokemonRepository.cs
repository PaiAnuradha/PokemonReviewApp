using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemons(int id);
        Pokemon GetPokemons(string name);
        bool PokemonExists(int pokeId);
    }
}
