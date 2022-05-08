using Exiled.Events.EventArgs;
using Random = UnityEngine.Random;
using ZombieSpawnWaveReborn.API;
using ZombieSpawnWaveReborn.API.Exceptions;

namespace ZombieSpawnWaveReborn
{
    internal class EventHandlers
    {
        public void OnDetonated()
        {
            if (!SpawnWave.HasDetonated)
                SpawnWave.HasDetonated = true;
        }

        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            if (Random.Range(1, 100) >= Plugin.Instance.Config.SpawnChance || ev.Players.Count == 0)
                return;

            ev.IsAllowed = false;

            try
            {
                SpawnWave.CreateSpawnWave(ev.Players);
            }
            catch (WarheadDetonatedException)
            {
                return;
            }
        }
    }
}
