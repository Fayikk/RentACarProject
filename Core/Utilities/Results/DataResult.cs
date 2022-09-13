using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result,IDataResult<T>
    {
        public T Data { get; }

        //Şimdi ifadelerimizi yazalım 
        //Normal Result class'ı içerisinde boolean ve string değer döndüren property'lerimiz mevcuttu
        //Biz DataResult class'ı ile Result classının özellikleriyle beraber aynı zamanda Data işlmelerinide
        //Döndürmek istiyoruz.Dolayısıyla DataResult klasörünü oluşturmuş oluyoruz.

        public DataResult(T data,bool success,string message):base(success,message)
        {
            //Çift parametreli
            Data = data;
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
            //Tek parametre
        }

    }
}
