using EMap.OgcStandards.Ows1_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Wmts1
{
    public class InvalidUpdateSequenceExceptionReport : ExceptionReport
    {
        public InvalidUpdateSequenceExceptionReport()
        {
            Exception =new ExceptionType[] 
            {
                new ExceptionType()
                {
                    exceptionCode =ExceptionCodes.InvalidUpdateSequence.ToString(),
                    ExceptionText = new string[] { "Bad request" }
                }
            };
        }
    }
}
