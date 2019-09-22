using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Services
{
    public abstract class OgcService : Service, IOgcService
    {
        public abstract string Service { get; }
        public abstract string Version { get; }
    }
}
