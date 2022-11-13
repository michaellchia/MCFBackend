using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCFBackend.Models
{
    public class ResponseBase
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}