using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieSpawnWaveReborn.API.Exceptions
{
    public class WarheadDetonatedException : Exception
    {
        public WarheadDetonatedException(string msg) : base(msg)
        {
        }
    }
}
