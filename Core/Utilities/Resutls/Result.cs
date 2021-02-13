using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resutls
{
    //dönüş cevabı
    public class Result : IResult
    {
        //get readonly constructor  içerisine set edilebilir.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        //ekleme işleminde mesaj dönmesin dersek
        public Result(bool success)
        {
            Success = success;

        }
        public bool Success { get; }

        public string Message { get; }
    }
}
