# ZombieSpawnWaveReborn
[![Github All Releases](https://img.shields.io/github/downloads/Heisenberg3666/ZombieSpawnWaveReborn/total.svg)]()

ZombieSpawnWaveReborn is a plugin for the game SCP: SL using the Exiled framework.
When a spawn wave is about to spawn, there is a configurable change that the spawn wave will be replaced with zombies instead.

```yaml
zombie_spawn_wave_reborn:
  is_enabled: true
  # The chance for a zombie wave to spawn instead of a regular one.
  spawn_chance: 25
  # Whether or not all the zombies will spawn at the same location (if false, they will spawn in random Red Rooms across Entrance Zone).
  spawn_together: false
  # The announcement that will be made when a zombie spawnwave spawns.
  announcement:
    cassie: SCP 0 4 9 2 CONTAINMENT BREACH DETECTED . IN ENTRANCE . ZONE
    subtitle: SCP-049-2 containment breach detected in Entrance Zone.
    broadcast:
    hint:
    display_for: 5
```
