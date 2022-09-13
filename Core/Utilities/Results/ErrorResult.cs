using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(true)//Farkettiysek eğer kalıtım ile alınan sınıf için base kullanılır.
        {
            //Eğer bir string ifade ile mantık ifadesini döndürmek istiyorsak eğer
            //Bu metodu çift parametreli işlemler için tasarladık
        }

        public ErrorResult(bool success) : base(true)
        {
            //Tek parametreli ifadelerimiz için ise kullanılan constructor budur.
        }
    }
}
