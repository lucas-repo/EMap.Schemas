using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Services
{
    public interface IWmtsServiceFasctory : IOgcServiceFasctory
    {
        new IWmtsService GetService();
    }
}
