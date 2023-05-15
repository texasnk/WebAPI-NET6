﻿using ReviewAPI.Data;
using ReviewAPI.Interface;
using ReviewAPI.Models;

namespace ReviewAPI.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p=>p.Id).ToList();
        }
    }
}
