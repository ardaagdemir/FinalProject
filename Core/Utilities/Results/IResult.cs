using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel void 
    public interface IResult
    {
        bool Success { get; } //get = yalnızca okunabilir, set = yalnızca yazılabilir
        string Message { get; }

    }
}
