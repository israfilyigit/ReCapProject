using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, true)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message) // default data yenine kullanılıyor 
        {                                                                  // çok sık kullanılmıyor
                                                                          // mesala data int olursa int in default değeri için kullanmak

        }
        public ErrorDataResult() : base(default, false)
        {

        }


    }
}
