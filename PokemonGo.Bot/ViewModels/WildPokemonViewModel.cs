﻿using PokemonGo.RocketAPI.GeneratedCode;

namespace PokemonGo.Bot.ViewModels
{
    public class WildPokemonViewModel : PokemonViewModel
    {
        public WildPokemonViewModel(WildPokemon pokemon) : base(pokemon.PokemonData.PokemonId, pokemon.PokemonData.Id)
        {
            EncounterId = pokemon.EncounterId;
            LastModifiedTimestampMs = pokemon.LastModifiedTimestampMs;
            Position = new PositionViewModel(pokemon.Latitude, pokemon.Longitude);
            SpawnpointId = pokemon.SpawnpointId;
            TimeTillHiddenMs = pokemon.TimeTillHiddenMs;
            PokemonData = pokemon.PokemonData;
        }

        public ulong EncounterId { get; }
        public long LastModifiedTimestampMs { get; }
        public string SpawnpointId { get; }
        public int TimeTillHiddenMs { get; }
        public PokemonData PokemonData { get; }
        PositionViewModel Position { get; }
    }
}