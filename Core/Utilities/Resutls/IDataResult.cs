using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resutls
{
    //mesaj dönemek istersek tekrar yazmamak için sen IResult sın diyoruz.
    //ekstra Data döndütüceğiz
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
