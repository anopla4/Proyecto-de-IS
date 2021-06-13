using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cine__backend.Authentication
{
    public enum Status
    {
        Error,
        Succes
    }
    public class Response
    {
        public Status Status { get; set; }
        public string Message { get; set; }
    }
}
