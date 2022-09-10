using Exiled.API.Features;
using System;
using ZombieSpawnWaveReborn.Events;

namespace ZombieSpawnWaveReborn
{
    internal class Plugin : Plugin<Config>
    {
        private ServerEvents _serverEvents;
        private WarheadEvents _warheadEvents;
        
        public static Plugin Instance;

        public override string Name { get; } = "ZombieSpawnWaveReborn";
        public override string Author { get; } = "Heisenberg3666";
        public override Version Version { get; } = new Version(1, 0, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 3, 0);

        public override void OnEnabled()
        {
            Instance = this;

            _serverEvents = new ServerEvents(Config);
            _warheadEvents = new WarheadEvents();
            
            RegisterEvents();
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();

            _warheadEvents = null;
            _serverEvents = null;

            Instance = null;
            
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            _serverEvents.RegisterEvents();
            _warheadEvents.RegisterEvents();
        }

        private void UnregisterEvents()
        {
            _serverEvents.UnregisterEvents();
            _warheadEvents.UnregisterEvents();
        }
    }
}
