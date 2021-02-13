using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resutls
{
    //Temel vodiler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
