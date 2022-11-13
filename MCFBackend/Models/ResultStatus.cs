using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MCFBackend.Models
{
    public class ResultStatus
    {
        public bool IsSuccess { get; set; }
        public string MessageText { get; set; }

        public ResultStatus()
        {
            this.IsSuccess = true;
            this.MessageText = string.Empty;
        }

        public void SetErrorStatus(string message)
        {
            this.IsSuccess = false;
            this.MessageText = message;
        }

        public void SetSuccessStatus(string message = "Success")
        {
            this.IsSuccess = true;
            this.MessageText = message;
        }
    }
}