using ZombieSpawnWaveReborn.API;

namespace ZombieSpawnWaveReborn.Events
{
    public class WarheadEvents
    {
        public void RegisterEvents()
        {
            Exiled.Events.Handlers.Warhead.Detonated += OnDetonated;
        }

        public void UnregisterEvents()
        {
            Exiled.Events.Handlers.Warhead.Detonated -= OnDetonated;
        }
        
        private void OnDetonated()
        {
            if (!ZSWRAPI.HasDetonated)
                ZSWRAPI.HasDetonated = true;
        }
    }
}