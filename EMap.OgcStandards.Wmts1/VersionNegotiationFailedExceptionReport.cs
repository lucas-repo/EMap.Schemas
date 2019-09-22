using EMap.OgcStandards.Ows1_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Wmts1
{
    public class VersionNegotiationFailedExceptionReport : ExceptionReport
    {
        public VersionNegotiationFailedExceptionReport()
        {
            Exception =new ExceptionType[] 
            {
                new ExceptionType()
                {
                    exceptionCode =ExceptionCodes.VersionNegotiationFailed.ToString(),
                    ExceptionText = new string[] { "Bad request" }
                }
            };
        }
    }
}
