using System;
using System.Collections.Generic;
using System.Text;

namespace TwoHundredEleven.Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
