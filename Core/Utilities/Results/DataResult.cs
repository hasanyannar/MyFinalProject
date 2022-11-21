using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool suceess, string message):base(suceess,message)
        {
            Data = data;
        }
        public DataResult(T data, bool suceess):base(suceess)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
