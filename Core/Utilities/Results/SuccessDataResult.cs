using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //Bu class içerisinde true değer döndüren mantık ifadeleri geçerlil olacaktır.
        public SuccessDataResult(T Data,string messages):base(Data,true,messages)
        {
            //Bütün parametreleri birden gönder
        }

        public SuccessDataResult(T Data):base(Data,true)
        {
            //Mesaj göndermedik
        }

        public SuccessDataResult(string messages):base(default,true,messages)
        {
            //Data'yı default değer olarak bırakıyoruz
        }
        public SuccessDataResult():base(default,true)
        {

        }

    }
}
