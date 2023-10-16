using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcode.Models
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        public string StatusCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
