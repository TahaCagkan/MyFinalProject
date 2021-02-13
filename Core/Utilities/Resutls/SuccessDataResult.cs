using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resutls
{
    //istediğim T ve sen bir DataResult
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }
        //mesaj girmek istemez ise
        public SuccessDataResult(T data):base(data,true)
        {

        }
        //sadece default hali ile dönmek ister iseö
        public SuccessDataResult(string message):base(default,true,message)
        {

        }

        //hiç birşey vermek istemez isem
        public SuccessDataResult():base(default,true)
        {
                
        }
    }
}
