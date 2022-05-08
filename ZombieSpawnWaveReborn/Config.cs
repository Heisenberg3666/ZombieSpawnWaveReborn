using Exiled.API.Interfaces;
using System.ComponentModel;

namespace ZombieSpawnWaveReborn
{
    internal class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("The chance for a zombie wave to spawn instead of a regular one.")]
        public int SpawnChance { get; set; } = 25;

        [Description("Whether or not all the zombies will spawn at the same location (if false, they will spawn in random Red Rooms across Entrance Zone).")]
        public bool SpawnTogether { get; set; } = true;

        [Description("The message that Cassie will announce on the zombie spawn wave.")]
        public string CassieMessage { get; set; } = "SCP 0 4 9 2 CONTAINMENT BREACH DETECTED IN ENTRANCE ZONE";

        [Description("The subtitles for the Cassie message.")]
        public string CassieSubtitles { get; set; } = "SCP-049-2 Containment breach detected in Entrance zone.";
    }
}
