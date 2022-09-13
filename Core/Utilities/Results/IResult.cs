using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //Burada result için gerekli  değişkenleri yazdık.
        //Bu değişkenlerin asıl amacı şu şekildedir.
        //boolean ifade eğer true değer döner ise mesajımız başarılı bir anlam taşımaktadır.
        //Eğer boolean ifademiz false dönecekse messajımız başarısız bir operasyon anlamını taşımalıdır.
        bool Success { get; }
        string Message { get; }
    }
}
