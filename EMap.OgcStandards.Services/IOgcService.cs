using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Services
{
    public interface IOgcService:IService
    {
        string Service { get; }
        string Version { get; }
    }
}
