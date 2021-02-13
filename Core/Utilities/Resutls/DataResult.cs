using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resutls
{
    //çalışıcağımız Tipi T,ayrıca Result sın,ve IDataResult sın
    public class DataResult<T> : Result, IDataResult<T>
    {
        //base kullanılması success ve message tekrar yazmamak için
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        //mesaj istemez ise sadece success için yapıldı
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
