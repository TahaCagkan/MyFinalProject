using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resutls
{
    //istediğim T ve sen bir DataResult

    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //mesaj girmek istemez ise
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //sadece default hali ile dönmek ister iseö
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        //hiç birşey vermek istemez isem
        public ErrorDataResult() : base(default, false)
        {

        }
    }

}
