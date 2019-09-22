using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Services
{
    public interface IOgcServiceFasctory: IServiceFasctory
    {
        new IOgcService GetService();
    }
}
