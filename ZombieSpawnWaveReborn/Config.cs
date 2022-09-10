using Exiled.API.Interfaces;
using System.ComponentModel;
using ZombieSpawnWaveReborn.API.Entities;

namespace ZombieSpawnWaveReborn
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("The chance for a zombie wave to spawn instead of a regular one.")]
        public int SpawnChance { get; set; } = 25;

        [Description("Whether or not all the zombies will spawn at the same location (if false, they will spawn in random Red Rooms across Entrance Zone).")]
        public bool SpawnTogether { get; set; } = true;

        [Description("The announcement that will be made when a zombie spawnwave spawns.")]
        public Announcement Announcement { get; set; } = new Announcement()
        {
            Cassie = "SCP 0 4 9 2 CONTAINMENT BREACH DETECTED . IN ENTRANCE . ZONE",
            Subtitle = "SCP-049-2 containment breach detected in Entrance Zone.",
            Broadcast = null,
            Hint = null,
            DisplayFor = 5
        };
    }
}
