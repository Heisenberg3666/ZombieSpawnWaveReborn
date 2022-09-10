using Exiled.Events.EventArgs;
using UnityEngine;
using ZombieSpawnWaveReborn.API;

namespace ZombieSpawnWaveReborn.Events
{
    public class ServerEvents
    {
        private readonly Config _config;

        public ServerEvents(Config config)
        {
            _config = config;
        }

        public void RegisterEvents()
        {
            Exiled.Events.Handlers.Server.RespawningTeam += OnRespawningTeam;
        }

        public void UnregisterEvents()
        {
            Exiled.Events.Handlers.Server.RespawningTeam -= OnRespawningTeam;
        }
        
        private void OnRespawningTeam(RespawningTeamEventArgs e)
        {
            if (ZSWRAPI.HasDetonated || Random.Range(1, 100) >= _config.SpawnChance)
                return;
            
            e.IsAllowed = false;

            ZSWRAPI.CreateSpawnWave(e.Players);
        }
    }
}