using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ZombieSpawnWaveReborn.API
{
    public static class ZSWRAPI
    {
        private static readonly Config _config = Plugin.Instance.Config;
        private static readonly List<Room> _redRooms = Room.List.Where(x => x.Type == RoomType.EzVent).ToList();
        
        public static bool HasDetonated = false;

        public static void CreateSpawnWave(IEnumerable<Player> players)
        {
            _config.Announcement.Announce();

            Room spawnPoint = _redRooms[Random.Range(0, _redRooms.Count)];

            foreach (Player player in players)
            {
                player.SetRole(RoleType.Scp0492, SpawnReason.Respawn);

                Timing.CallDelayed(.5f, () =>
                {
                    if (_config.SpawnTogether)
                        player.Teleport(spawnPoint);
                    else
                        player.Teleport(Random.Range(0, _redRooms.Count));
                });
            }
        }
    }
}
