using EMap.OgcStandards.Ows1_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMap.OgcStandards.Wmts1
{
    public class InvalidParameterValueExceptionReport : ExceptionReport
    {
        public InvalidParameterValueExceptionReport()
        {
            Exception =new ExceptionType[] 
            {
                new ExceptionType()
                {
                    exceptionCode =ExceptionCodes.InvalidParameterValue.ToString(),
                    ExceptionText = new string[] { "Bad request" }
                }
            };
        }
    }
}
