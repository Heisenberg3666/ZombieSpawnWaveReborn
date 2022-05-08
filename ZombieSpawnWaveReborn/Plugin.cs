using Exiled.API.Features;
using Warhead = Exiled.Events.Handlers.Warhead;
using Server = Exiled.Events.Handlers.Server;
using System;

namespace ZombieSpawnWaveReborn
{
    internal class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        private EventHandlers _events;

        public override string Name => "ZombieSpawnWaveReborn";
        public override string Author => "Heisenberg3666";
        public override Version Version => new Version(1, 0, 0, 0);
        public override Version RequiredExiledVersion => new Version(5, 1, 3);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Instance = this;
            _events = new EventHandlers();
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            UnregisterEvents();
            _events = null;
            Instance = null;
        }

        public void RegisterEvents()
        {
            Warhead.Detonated += _events.OnDetonated;
            Server.RespawningTeam += _events.OnRespawningTeam;
        }

        public void UnregisterEvents()
        {
            Warhead.Detonated -= _events.OnDetonated;
            Server.RespawningTeam -= _events.OnRespawningTeam;
        }
    }
}
