using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Resutls
{
    //Başarılı dönüş mesajı
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message)
        {
                
        }
        public SuccessResult():base(true)
        {

        }
    }
}
