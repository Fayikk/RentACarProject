using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //IResult sınıfındaki property'lerin implementasyonu'nu burada gerçekleştirelim.
        public bool Success { get; }

        public string Message { get; }

        //constructor'larımızı yazalım.

        public Result(bool success, string message) : this(success)
        {
            Message = message;
            //Burada 2 parametreye ihtiyaç duyulduğu zaman bu metod kullanılmaktadır.
            //Yani boolean bir değer döndürürken aynı zamanda kullanıcı yada herhangi biride olabilr mesaj çıktısı da verilecektir.
        }

        public Result(bool success)
        {
            //Burada ise tek parametre söz konusudur.Yani parametre olaark sizinde gördüğünüz gibi sadece boolean değer döndürecektir
            //True yada False
            Success = success;
        }

        //Şimdi birde gelin bu ifadeleri kullanmak için hem Successresult hemde Error Result ifadelerinin yazalım
        //Hemen öncesinde ise Utilities'lerimizi gidip Ana class'lardan birinde tanımlamasını gerçekleştirelim.
    }
}
