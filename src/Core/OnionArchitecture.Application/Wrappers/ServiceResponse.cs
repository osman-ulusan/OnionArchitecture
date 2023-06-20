using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Wrappers
{
    public class ServiceResponse<T> : BaseResponse
    {
        public T value { get; set; }

        public ServiceResponse(T value)
        {
            this.value = value;
        }
    }
}
