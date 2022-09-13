using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data,string messages):base(data,false,messages)
        {
            //Hepsinden yararlan
        }
        public ErrorDataResult(T data):base(data,false)
        {
            //String değeri döndürme
        }
        public ErrorDataResult(string messages):base(default,false,messages)
        {
            //Data gönderme 
            //string gönder
        }
        public ErrorDataResult():base(default,false)
        {
            //Hiçbir değer için atama yapma boolean değer belirteç'tir(bool hariç).
        }
    }
}
