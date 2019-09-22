using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Services
{
    public abstract class ServiceFasctory : IServiceFasctory
    {
        public virtual IService GetService()
        {
            throw new NotImplementedException();
        }
    }
}
