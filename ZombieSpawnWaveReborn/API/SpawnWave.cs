using Exiled.API.Enums;
using Exiled.API.Features;
using MEC;
using System;
using System.Collections.Generic;
using System.Linq;
using ZombieSpawnWaveReborn.API.Exceptions;

namespace ZombieSpawnWaveReborn.API
{
    public static class SpawnWave
    {
        public static bool HasDetonated = false;
        public static List<Room> RedRooms = Room.List.Where(x => x.Type == RoomType.EzVent).ToList();

        public static void CreateSpawnWave(IEnumerable<Player> players)
        {
            if (HasDetonated)
                throw new WarheadDetonatedException("A spawnwave cannot be made, the warhead has been detonated.");

            if (!string.IsNullOrWhiteSpace(Plugin.Instance.Config.CassieMessage))
                Cassie.MessageTranslated(Plugin.Instance.Config.CassieMessage, Plugin.Instance.Config.CassieSubtitles);

            Room spawnPoint;
            spawnPoint = RedRooms[new Random().Next(RedRooms.Count())];

            foreach (Player player in players)
            {
                player.SetRole(RoleType.Scp0492, SpawnReason.Respawn);

                Timing.CallDelayed(.5f, () =>
                {
                    if (!Plugin.Instance.Config.SpawnTogether)
                        player.Teleport(RedRooms[new Random().Next(RedRooms.Count())]);
                    else
                        player.Teleport(spawnPoint);
                });
            }
        }
    }
}
